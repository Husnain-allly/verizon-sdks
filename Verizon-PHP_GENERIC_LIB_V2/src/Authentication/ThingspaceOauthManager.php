<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Authentication;

use Closure;
use Exception;
use CoreInterfaces\Core\Request\TypeValidatorInterface;
use Core\Authentication\CoreAuth;
use Core\Client;
use Core\Request\Parameters\HeaderParam;
use Core\Utils\CoreHelper;
use InvalidArgumentException;
use VerizonLib\Models\OauthToken;
use VerizonLib\Apis\OauthAuthorizationApi;
use VerizonLib\ConfigurationDefaults;

/**
 * Utility class for OAuth 2 authorization and token management
 */
class ThingspaceOauthManager extends CoreAuth implements ThingspaceOauthCredentials
{
    /**
     * Singleton instance of OAuth 2 API controller
     * @var OauthAuthorizationApi
     */
    private $oAuthApi;

    /**
     * @var array
     */
    private $config;

    /**
     * @var OAuthToken|null
     */
    private $internalOAuthToken;

    public function __construct(array $config)
    {
        parent::__construct();
        $this->config = $config;
        $this->internalOAuthToken = $this->getOAuthToken();
    }

    public function setClient(Client $client): void
    {
        $this->oAuthApi = new OAuthAuthorizationController($client);
    }

    /**
     * String value for oauthClientId.
     */
    public function getOauthClientId(): string
    {
        return $this->config['oauthClientId'] ?? ConfigurationDefaults::O_AUTH_CLIENT_ID;
    }

    /**
     * String value for oauthClientSecret.
     */
    public function getOauthClientSecret(): string
    {
        return $this->config['oauthClientSecret'] ?? ConfigurationDefaults::O_AUTH_CLIENT_SECRET;
    }

    /**
     * OauthToken value for oauthToken.
     */
    public function getOauthToken(): ?OauthToken
    {
        $oauthToken = $this->config['oauthToken'];
        if ($oauthToken instanceof OauthToken) {
            return clone $oauthToken;
        }
        return ConfigurationDefaults::O_AUTH_TOKEN;
    }

    /**
     * OauthScopeThingspaceOauth value for oauthScopes.
     */
    public function getOauthScopes(): ?array
    {
        $oauthScopes = $this->config['oauthScopes'];
        if (is_array($oauthScopes)) {
            return $oauthScopes;
        }
        return ConfigurationDefaults::O_AUTH_SCOPES;
    }

    /**
     * Checks if provided credentials match with existing ones.
     *
     * @param string $oauthClientId OAuth 2 Client ID
     * @param string $oauthClientSecret OAuth 2 Client Secret
     */
    public function equals(string $oauthClientId, string $oauthClientSecret): bool
    {
        return $oauthClientId == $this->getOauthClientId() &&
            $oauthClientSecret == $this->getOauthClientSecret();
    }

    /**
     * Clock skew time in seconds applied while checking the OAuth Token expiry.
     */
    public function getOAuthClockSkew(): int
    {
        return $this->config['thingspace_oauth-ClockSkew'] ?? ConfigurationDefaults::THINGSPACE_OAUTH_CLOCK_SKEW;
    }

    /**
     * Fetch the OAuth token.
     * @param  array|null        $additionalParams  Additional parameters to send during authorization
     */
    public function fetchToken(?array $additionalParams = null): OauthToken
    {
        //send request for access token
        $response = $this->oAuthApi->requestTokenThingspaceOauth(
            $this->buildBasicHeader(),
            implode(' ', $this->getOauthScopes() ?? []),
            $additionalParams
        );

        if ($response->isError()) {
            $reason = CoreHelper::serialize($response->getResult());
            throw new InvalidArgumentException("Failed to fetch OAuthToken: $reason");
        }

        $this->addExpiryTime($response->getResult());

        return $response->getResult();
    }

    /**
     * Has the OAuth token expired? If the token argument is not provided then this function will check the expiry of
     * the initial oauthToken, that's set in the client initialization.
     */
    public function isTokenExpired(?OAuthToken $token = null): bool
    {
        $token = $token ?? $this->getOAuthToken();
        if ($token == null || empty($token->getExpiry())) {
            return true;
        }
        return $token->getExpiry() < time() + $this->getOAuthClockSkew();
    }

    private function getTokenFromProvider(): ?OAuthToken
    {
        if ($this->internalOAuthToken != null && !$this->isTokenExpired($this->internalOAuthToken)) {
            return $this->internalOAuthToken;
        }
        $provider = $this->config['thingspace_oauth-TokenProvider'];
        if (is_callable($provider)) {
            $token = Closure::fromCallable($provider)($this->internalOAuthToken, $this);
        } else {
            try {
                $token = $this->fetchToken();
            } catch (Exception $exp) {
                return $this->internalOAuthToken;
            }
        }
        $updateCallback = $this->config['thingspace_oauth-OnTokenUpdate'];
        if (is_callable($updateCallback)) {
            Closure::fromCallable($updateCallback)($token);
        }
        return $token;
    }

    /**
     * Check if client is authorized, throws exceptions when token is null or expired.
     *
     * @throws InvalidArgumentException
     */
    public function validate(TypeValidatorInterface $validator): void
    {
        $this->internalOAuthToken = $this->getTokenFromProvider();
        if ($this->internalOAuthToken == null) {
            throw new InvalidArgumentException('Client is not authorized. An OAuth token is needed to make API calls.');
        }
        if ($this->isTokenExpired($this->internalOAuthToken)) {
            throw new InvalidArgumentException('OAuth token is expired. A valid token is needed to make API calls.');
        }
        parent::__construct(
            HeaderParam::init(
                'Authorization',
                CoreHelper::getBearerAuthString($this->internalOAuthToken->getAccessToken())
            )->requiredNonEmpty()
        );
        parent::validate($validator);
    }

    /**
     * Build authorization header value for basic auth.
     */
    private function buildBasicHeader(): string
    {
        return 'Basic ' . base64_encode(
            $this->getOauthClientId() . ':' . $this->getOauthClientSecret()
        );
    }

    /**
     * Adds the expiry time to the given oAuthToken instance.
     */
    private function addExpiryTime(OAuthToken $oAuthToken): void
    {
        $expiresIn = $oAuthToken->getExpiresIn();
        if (empty($expiresIn)) {
            return;
        }
        $oAuthToken->setExpiry(time() + $expiresIn);
    }
}
