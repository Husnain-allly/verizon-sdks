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
 * All error messages are returned in this format. Error codes and messages are listed on the Error
 * Codes page, along with explanations and suggestions for corrective actions.
 */
class DeviceDiagnosticsResultException extends ApiException
{
    /**
     * @var string
     */
    private $errorCode;

    /**
     * @var string
     */
    private $errorMessage;

    /**
     * @param string $reason
     * @param \VerizonLib\Http\HttpRequest $request
     * @param \VerizonLib\Http\HttpResponse $response
     * @param string $errorCode
     * @param string $errorMessage
     */
    public function __construct(
        string $reason,
        \VerizonLib\Http\HttpRequest $request,
        \VerizonLib\Http\HttpResponse $response,
        string $errorCode,
        string $errorMessage
    ) {
        parent::__construct($reason, $request, $response);
        $this->errorCode = $errorCode;
        $this->errorMessage = $errorMessage;
    }

    /**
     * Returns Error Code.
     * Simple error code.
     */
    public function getErrorCode(): string
    {
        return $this->errorCode;
    }

    /**
     * Sets Error Code.
     * Simple error code.
     *
     * @required
     * @maps errorCode
     */
    public function setErrorCode(string $errorCode): void
    {
        $this->errorCode = $errorCode;
    }

    /**
     * Returns Error Message.
     * Detailed error message.
     */
    public function getErrorMessage(): string
    {
        return $this->errorMessage;
    }

    /**
     * Sets Error Message.
     * Detailed error message.
     *
     * @required
     * @maps errorMessage
     */
    public function setErrorMessage(string $errorMessage): void
    {
        $this->errorMessage = $errorMessage;
    }

    /**
     * Converts the DeviceDiagnosticsResultException object to a human-readable string representation.
     *
     * @return string The string representation of the DeviceDiagnosticsResultException object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DeviceDiagnosticsResultException',
            [
                'errorCode' => $this->errorCode,
                'errorMessage' => $this->errorMessage,
                'additionalProperties' => $this->additionalProperties
            ],
            parent::__toString()
        );
    }

    protected $propertyNames = ['errorCode', 'errorMessage'];

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
