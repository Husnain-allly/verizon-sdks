<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models;

use stdClass;
use VerizonLib\ApiHelper;

/**
 * Error reported by a device.
 */
class AggregateUsageError implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $imei;

    /**
     * @var string|null
     */
    private $errorMessage;

    /**
     * @var IErrorMessage|null
     */
    private $errorResponse;

    /**
     * Returns Imei.
     * International Mobile Equipment Identifier. This is the ID of the device reporting errors.
     */
    public function getImei(): ?string
    {
        return $this->imei;
    }

    /**
     * Sets Imei.
     * International Mobile Equipment Identifier. This is the ID of the device reporting errors.
     *
     * @maps imei
     */
    public function setImei(?string $imei): void
    {
        $this->imei = $imei;
    }

    /**
     * Returns Error Message.
     * A general error message.
     */
    public function getErrorMessage(): ?string
    {
        return $this->errorMessage;
    }

    /**
     * Sets Error Message.
     * A general error message.
     *
     * @maps errorMessage
     */
    public function setErrorMessage(?string $errorMessage): void
    {
        $this->errorMessage = $errorMessage;
    }

    /**
     * Returns Error Response.
     * Error message.
     */
    public function getErrorResponse(): ?IErrorMessage
    {
        return $this->errorResponse;
    }

    /**
     * Sets Error Response.
     * Error message.
     *
     * @maps errorResponse
     */
    public function setErrorResponse(?IErrorMessage $errorResponse): void
    {
        $this->errorResponse = $errorResponse;
    }

    /**
     * Converts the AggregateUsageError object to a human-readable string representation.
     *
     * @return string The string representation of the AggregateUsageError object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'AggregateUsageError',
            [
                'imei' => $this->imei,
                'errorMessage' => $this->errorMessage,
                'errorResponse' => $this->errorResponse,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['imei', 'errorMessage', 'errorResponse'];

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

    /**
     * Encode this object to JSON
     *
     * @param bool $asArrayWhenEmpty Whether to serialize this model as an array whenever no fields
     *        are set. (default: false)
     *
     * @return array|stdClass
     */
    #[\ReturnTypeWillChange] // @phan-suppress-current-line PhanUndeclaredClassAttribute for (php < 8.1)
    public function jsonSerialize(bool $asArrayWhenEmpty = false)
    {
        $json = [];
        if (isset($this->imei)) {
            $json['imei']          = $this->imei;
        }
        if (isset($this->errorMessage)) {
            $json['errorMessage']  = $this->errorMessage;
        }
        if (isset($this->errorResponse)) {
            $json['errorResponse'] = $this->errorResponse;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
