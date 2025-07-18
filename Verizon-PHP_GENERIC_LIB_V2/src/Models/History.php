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
 * History data for a selected device and its attributes at a specific time.
 */
class History implements \JsonSerializable
{
    /**
     * @var string
     */
    private $accountName;

    /**
     * @var Device
     */
    private $device;

    /**
     * @var HistoryAttributeValue|null
     */
    private $attributes;

    /**
     * @param string $accountName
     * @param Device $device
     */
    public function __construct(string $accountName, Device $device)
    {
        $this->accountName = $accountName;
        $this->device = $device;
    }

    /**
     * Returns Account Name.
     * The name of the billing account for which you want retrieve history data. An account name is usually
     * numeric, and must include any leading zeros.
     */
    public function getAccountName(): string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * The name of the billing account for which you want retrieve history data. An account name is usually
     * numeric, and must include any leading zeros.
     *
     * @required
     * @maps accountName
     */
    public function setAccountName(string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Device.
     * Identifies a particular IoT device.
     */
    public function getDevice(): Device
    {
        return $this->device;
    }

    /**
     * Sets Device.
     * Identifies a particular IoT device.
     *
     * @required
     * @maps device
     */
    public function setDevice(Device $device): void
    {
        $this->device = $device;
    }

    /**
     * Returns Attributes.
     * Streaming RF parameter for which you want to retrieve history data.
     */
    public function getAttributes(): ?HistoryAttributeValue
    {
        return $this->attributes;
    }

    /**
     * Sets Attributes.
     * Streaming RF parameter for which you want to retrieve history data.
     *
     * @maps attributes
     */
    public function setAttributes(?HistoryAttributeValue $attributes): void
    {
        $this->attributes = $attributes;
    }

    /**
     * Converts the History object to a human-readable string representation.
     *
     * @return string The string representation of the History object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'History',
            [
                'accountName' => $this->accountName,
                'device' => $this->device,
                'attributes' => $this->attributes,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['accountName', 'device', 'attributes'];

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
        $json['accountName']    = $this->accountName;
        $json['device']         = $this->device;
        if (isset($this->attributes)) {
            $json['attributes'] = $this->attributes;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
