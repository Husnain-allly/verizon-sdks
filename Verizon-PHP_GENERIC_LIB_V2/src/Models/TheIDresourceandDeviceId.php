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

class TheIDresourceandDeviceId implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $id;

    /**
     * @var string|null
     */
    private $deviceid;

    /**
     * Returns Id.
     * UUID of the user record, assigned at creation
     */
    public function getId(): ?string
    {
        return $this->id;
    }

    /**
     * Sets Id.
     * UUID of the user record, assigned at creation
     *
     * @maps id
     */
    public function setId(?string $id): void
    {
        $this->id = $id;
    }

    /**
     * Returns Deviceid.
     * This is a UUID value of the device created when the device is onboarded
     */
    public function getDeviceid(): ?string
    {
        return $this->deviceid;
    }

    /**
     * Sets Deviceid.
     * This is a UUID value of the device created when the device is onboarded
     *
     * @maps deviceid
     */
    public function setDeviceid(?string $deviceid): void
    {
        $this->deviceid = $deviceid;
    }

    /**
     * Converts the TheIDresourceandDeviceId object to a human-readable string representation.
     *
     * @return string The string representation of the TheIDresourceandDeviceId object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'TheIDresourceandDeviceId',
            [
                'id' => $this->id,
                'deviceid' => $this->deviceid,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['id', 'deviceid'];

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
        if (isset($this->id)) {
            $json['id']       = $this->id;
        }
        if (isset($this->deviceid)) {
            $json['deviceid'] = $this->deviceid;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
