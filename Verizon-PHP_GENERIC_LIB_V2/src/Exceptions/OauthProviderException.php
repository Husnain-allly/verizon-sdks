<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Exceptions;

use VerizonLib\ApiHelper;

/**
 * OAuth 2 Authorization endpoint exception.
 */
class OauthProviderException extends ApiException
{
    /**
     * @var string
     */
    private $error;

    /**
     * @var string|null
     */
    private $errorDescription;

    /**
     * @var string|null
     */
    private $errorUri;

    /**
     * @param string $reason
     * @param \VerizonLib\Http\HttpRequest $request
     * @param \VerizonLib\Http\HttpResponse $response
     * @param string $error
     */
    public function __construct(
        string $reason,
        \VerizonLib\Http\HttpRequest $request,
        \VerizonLib\Http\HttpResponse $response,
        string $error
    ) {
        parent::__construct($reason, $request, $response);
        $this->error = $error;
    }

    /**
     * Returns Error.
     * Gets or sets error code.
     */
    public function getError(): string
    {
        return $this->error;
    }

    /**
     * Sets Error.
     * Gets or sets error code.
     *
     * @required
     * @maps error
     * @factory \VerizonLib\Models\OauthProviderError::checkValue
     */
    public function setError(string $error): void
    {
        $this->error = $error;
    }

    /**
     * Returns Error Description.
     * Gets or sets human-readable text providing additional information on error.
     * Used to assist the client developer in understanding the error that occurred.
     */
    public function getErrorDescription(): ?string
    {
        return $this->errorDescription;
    }

    /**
     * Sets Error Description.
     * Gets or sets human-readable text providing additional information on error.
     * Used to assist the client developer in understanding the error that occurred.
     *
     * @maps error_description
     */
    public function setErrorDescription(?string $errorDescription): void
    {
        $this->errorDescription = $errorDescription;
    }

    /**
     * Returns Error Uri.
     * Gets or sets a URI identifying a human-readable web page with information about the error, used to
     * provide the client developer with additional information about the error.
     */
    public function getErrorUri(): ?string
    {
        return $this->errorUri;
    }

    /**
     * Sets Error Uri.
     * Gets or sets a URI identifying a human-readable web page with information about the error, used to
     * provide the client developer with additional information about the error.
     *
     * @maps error_uri
     */
    public function setErrorUri(?string $errorUri): void
    {
        $this->errorUri = $errorUri;
    }

    /**
     * Converts the OauthProviderException object to a human-readable string representation.
     *
     * @return string The string representation of the OauthProviderException object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'OauthProviderException',
            [
                'error' => $this->error,
                'errorDescription' => $this->errorDescription,
                'errorUri' => $this->errorUri,
                'additionalProperties' => $this->additionalProperties
            ],
            parent::__toString()
        );
    }

    protected $propertyNames = ['error', 'error_description', 'error_uri'];

    private $additionalProperties = [];

    /**
     * Add an additional property to this model.
     *
     * @param string $name Name of property.
     * @param mixed $value Value of property.
     */
    public function addAdditionalProperty(string $name, $value)
    {
        if (in_array($name, $this->propertyNames, true)) {
            throw new \InvalidArgumentException(
                "The additional property key, '$name' conflicts with one of the model's properties"
            );
        }

        $this->additionalProperties[$name] = $value;
    }

    /**
     * Find an additional property by name in this model or false if property does not exist.
     *
     * @param string $name Name of property.
     *
     * @return mixed|false Value of the property.
     */
    public function findAdditionalProperty(string $name)
    {
        if (isset($this->additionalProperties[$name])) {
            return $this->additionalProperties[$name];
        }
        return false;
    }
}
