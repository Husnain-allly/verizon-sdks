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
 * Response for a request to list down account devices.
 */
class AccountDeviceListResult implements \JsonSerializable
{
    /**
     * @var ThingspaceDevice[]|null
     */
    private $devices;

    /**
     * @var bool|null
     */
    private $hasMoreData;

    /**
     * Returns Devices.
     * Up to 10,000 devices that you want to move to a different account, specified by device identifier.
     *
     * @return ThingspaceDevice[]|null
     */
    public function getDevices(): ?array
    {
        return $this->devices;
    }

    /**
     * Sets Devices.
     * Up to 10,000 devices that you want to move to a different account, specified by device identifier.
     *
     * @maps devices
     *
     * @param ThingspaceDevice[]|null $devices
     */
    public function setDevices(?array $devices): void
    {
        $this->devices = $devices;
    }

    /**
     * Returns Has More Data.
     * False for a status 200 response.True for a status 202 response, indicating that there is more data
     * to be retrieved.
     */
    public function getHasMoreData(): ?bool
    {
        return $this->hasMoreData;
    }

    /**
     * Sets Has More Data.
     * False for a status 200 response.True for a status 202 response, indicating that there is more data
     * to be retrieved.
     *
     * @maps hasMoreData
     */
    public function setHasMoreData(?bool $hasMoreData): void
    {
        $this->hasMoreData = $hasMoreData;
    }

    /**
     * Converts the AccountDeviceListResult object to a human-readable string representation.
     *
     * @return string The string representation of the AccountDeviceListResult object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'AccountDeviceListResult',
            [
                'devices' => $this->devices,
                'hasMoreData' => $this->hasMoreData,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['devices', 'hasMoreData'];

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
        if (isset($this->devices)) {
            $json['devices']     = $this->devices;
        }
        if (isset($this->hasMoreData)) {
            $json['hasMoreData'] = $this->hasMoreData;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
