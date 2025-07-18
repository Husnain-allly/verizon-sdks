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

class DailyUsage implements \JsonSerializable
{
    /**
     * @var GioDeviceId|null
     */
    private $deviceId;

    /**
     * @var string|null
     */
    private $earliest;

    /**
     * @var string|null
     */
    private $latest;

    /**
     * Returns Device Id.
     */
    public function getDeviceId(): ?GioDeviceId
    {
        return $this->deviceId;
    }

    /**
     * Sets Device Id.
     *
     * @maps deviceId
     */
    public function setDeviceId(?GioDeviceId $deviceId): void
    {
        $this->deviceId = $deviceId;
    }

    /**
     * Returns Earliest.
     * The start date of the time period queried as "$datetime"
     */
    public function getEarliest(): ?string
    {
        return $this->earliest;
    }

    /**
     * Sets Earliest.
     * The start date of the time period queried as "$datetime"
     *
     * @maps earliest
     */
    public function setEarliest(?string $earliest): void
    {
        $this->earliest = $earliest;
    }

    /**
     * Returns Latest.
     * The end date of the time period being queried as "$datetime"
     */
    public function getLatest(): ?string
    {
        return $this->latest;
    }

    /**
     * Sets Latest.
     * The end date of the time period being queried as "$datetime"
     *
     * @maps latest
     */
    public function setLatest(?string $latest): void
    {
        $this->latest = $latest;
    }

    /**
     * Converts the DailyUsage object to a human-readable string representation.
     *
     * @return string The string representation of the DailyUsage object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DailyUsage',
            [
                'deviceId' => $this->deviceId,
                'earliest' => $this->earliest,
                'latest' => $this->latest,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['deviceId', 'earliest', 'latest'];

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
        if (isset($this->deviceId)) {
            $json['deviceId'] = $this->deviceId;
        }
        if (isset($this->earliest)) {
            $json['earliest'] = $this->earliest;
        }
        if (isset($this->latest)) {
            $json['latest']   = $this->latest;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
