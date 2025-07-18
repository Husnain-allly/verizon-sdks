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
 * Session and usage details for up to 10 devices.
 */
class AggregateSessionReport implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $txid;

    /**
     * @var AggregateUsageItem[]|null
     */
    private $usage;

    /**
     * @var AggregateUsageError[]|null
     */
    private $errors;

    /**
     * Returns Txid.
     * A unique string that associates the request with the location report information that is sent in
     * asynchronous callback message.ThingSpace will send a separate callback message for each device that
     * was in the request. All of the callback messages will have the same txid.
     */
    public function getTxid(): ?string
    {
        return $this->txid;
    }

    /**
     * Sets Txid.
     * A unique string that associates the request with the location report information that is sent in
     * asynchronous callback message.ThingSpace will send a separate callback message for each device that
     * was in the request. All of the callback messages will have the same txid.
     *
     * @maps txid
     */
    public function setTxid(?string $txid): void
    {
        $this->txid = $txid;
    }

    /**
     * Returns Usage.
     * Contains usage per device.
     *
     * @return AggregateUsageItem[]|null
     */
    public function getUsage(): ?array
    {
        return $this->usage;
    }

    /**
     * Sets Usage.
     * Contains usage per device.
     *
     * @maps usage
     *
     * @param AggregateUsageItem[]|null $usage
     */
    public function setUsage(?array $usage): void
    {
        $this->usage = $usage;
    }

    /**
     * Returns Errors.
     * An object containing any errors reported by the device.
     *
     * @return AggregateUsageError[]|null
     */
    public function getErrors(): ?array
    {
        return $this->errors;
    }

    /**
     * Sets Errors.
     * An object containing any errors reported by the device.
     *
     * @maps errors
     *
     * @param AggregateUsageError[]|null $errors
     */
    public function setErrors(?array $errors): void
    {
        $this->errors = $errors;
    }

    /**
     * Converts the AggregateSessionReport object to a human-readable string representation.
     *
     * @return string The string representation of the AggregateSessionReport object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'AggregateSessionReport',
            [
                'txid' => $this->txid,
                'usage' => $this->usage,
                'errors' => $this->errors,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['txid', 'usage', 'errors'];

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
        $json['txid']       = $this->txid;
        if (isset($this->usage)) {
            $json['usage']  = $this->usage;
        }
        if (isset($this->errors)) {
            $json['errors'] = $this->errors;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
