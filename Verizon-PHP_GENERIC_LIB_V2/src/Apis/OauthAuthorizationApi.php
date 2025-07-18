<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Apis;

use Core\Request\Parameters\AdditionalFormParams;
use Core\Request\Parameters\FormParam;
use Core\Request\Parameters\HeaderParam;
use Core\Response\Types\ErrorType;
use CoreInterfaces\Core\Request\RequestMethod;
use VerizonLib\Exceptions\OauthProviderException;
use VerizonLib\Http\ApiResponse;
use VerizonLib\Models\OauthToken;
use VerizonLib\Server;

class OauthAuthorizationApi extends BaseApi
{
    /**
     * Create a new OAuth 2 token.
     *
     * @param string $authorization Authorization header in Basic auth format
     * @param string|null $scope Requested scopes as a space-delimited list.
     * @param array|null $fieldParameters Additional optional form parameters are supported by this
     *        endpoint
     *
     * @return ApiResponse Response from the API call
     */
    public function requestTokenThingspaceOauth(
        string $authorization,
        ?string $scope = null,
        ?array $fieldParameters = null
    ): ApiResponse {
        $_reqBuilder = $this->requestBuilder(RequestMethod::POST, '/oauth2/token')
            ->server(Server::OAUTH_SERVER)
            ->parameters(
                FormParam::init('grant_type', 'client_credentials'),
                HeaderParam::init('Authorization', $authorization)->required(),
                FormParam::init('scope', $scope),
                AdditionalFormParams::init($fieldParameters)
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn(
                '400',
                ErrorType::init('OAuth 2 provider returned an error.', OauthProviderException::class)
            )
            ->throwErrorOn(
                '401',
                ErrorType::init(
                    'OAuth 2 provider says client authentication failed.',
                    OauthProviderException::class
                )
            )
            ->type(OauthToken::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }

    /**
     * Create a new OAuth 2 token.
     *
     * @param string $authorization Authorization header in Basic auth format
     * @param string|null $scope Requested scopes as a space-delimited list.
     * @param array|null $fieldParameters Additional optional form parameters are supported by this
     *        endpoint
     *
     * @return ApiResponse Response from the API call
     */
    public function requestTokenThingspaceOauth1(
        string $authorization,
        ?string $scope = null,
        ?array $fieldParameters = null
    ): ApiResponse {
        $_reqBuilder = $this->requestBuilder(RequestMethod::POST, '/')
            ->server(Server::OAUTH_SERVER)
            ->parameters(
                FormParam::init('grant_type', 'client_credentials'),
                HeaderParam::init('Authorization', $authorization)->required(),
                FormParam::init('scope', $scope),
                AdditionalFormParams::init($fieldParameters)
            );

        $_resHandler = $this->responseHandler()
            ->throwErrorOn(
                '400',
                ErrorType::init('OAuth 2 provider returned an error.', OauthProviderException::class)
            )
            ->throwErrorOn(
                '401',
                ErrorType::init(
                    'OAuth 2 provider says client authentication failed.',
                    OauthProviderException::class
                )
            )
            ->type(OauthToken::class)
            ->returnApiResponse();

        return $this->execute($_reqBuilder, $_resHandler);
    }
}
