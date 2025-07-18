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
 * Contains the device identifiers and a success or failure response for each device in the request.
 */
class AddDevicesResult implements \JsonSerializable
{
    /**
     * @var DeviceId[]|null
     */
    private $deviceIds;

    /**
     * @var string|null
     */
    private $response;

    /**
     * Returns Device Ids.
     * Identifiers for the device.
     *
     * @return DeviceId[]|null
     */
    public function getDeviceIds(): ?array
    {
        return $this->deviceIds;
    }

    /**
     * Sets Device Ids.
     * Identifiers for the device.
     *
     * @maps deviceIds
     *
     * @param DeviceId[]|null $deviceIds
     */
    public function setDeviceIds(?array $deviceIds): void
    {
        $this->deviceIds = $deviceIds;
    }

    /**
     * Returns Response.
     * The success message or error message for the current device.
     */
    public function getResponse(): ?string
    {
        return $this->response;
    }

    /**
     * Sets Response.
     * The success message or error message for the current device.
     *
     * @maps response
     */
    public function setResponse(?string $response): void
    {
        $this->response = $response;
    }

    /**
     * Converts the AddDevicesResult object to a human-readable string representation.
     *
     * @return string The string representation of the AddDevicesResult object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'AddDevicesResult',
            [
                'deviceIds' => $this->deviceIds,
                'response' => $this->response,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['deviceIds', 'response'];

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
        if (isset($this->deviceIds)) {
            $json['deviceIds'] = $this->deviceIds;
        }
        if (isset($this->response)) {
            $json['response']  = $this->response;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
