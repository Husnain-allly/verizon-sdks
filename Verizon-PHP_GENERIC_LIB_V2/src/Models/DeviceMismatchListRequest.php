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
 * Request to list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI
 * (hardware) during a specified time frame.
 */
class DeviceMismatchListRequest implements \JsonSerializable
{
    /**
     * @var DateFilter
     */
    private $filter;

    /**
     * @var AccountDeviceList[]|null
     */
    private $devices;

    /**
     * @var string|null
     */
    private $accountName;

    /**
     * @var string|null
     */
    private $groupName;

    /**
     * @param DateFilter $filter
     */
    public function __construct(DateFilter $filter)
    {
        $this->filter = $filter;
    }

    /**
     * Returns Filter.
     * Filter out the dates.
     */
    public function getFilter(): DateFilter
    {
        return $this->filter;
    }

    /**
     * Sets Filter.
     * Filter out the dates.
     *
     * @required
     * @maps filter
     */
    public function setFilter(DateFilter $filter): void
    {
        $this->filter = $filter;
    }

    /**
     * Returns Devices.
     * A list of specific devices that you want to check, specified by ICCID or MDN.
     *
     * @return AccountDeviceList[]|null
     */
    public function getDevices(): ?array
    {
        return $this->devices;
    }

    /**
     * Sets Devices.
     * A list of specific devices that you want to check, specified by ICCID or MDN.
     *
     * @maps devices
     *
     * @param AccountDeviceList[]|null $devices
     */
    public function setDevices(?array $devices): void
    {
        $this->devices = $devices;
    }

    /**
     * Returns Account Name.
     * The account that you want to search for mismatched devices. If you don't specify an accountName, the
     * search includes all devices to which you have access.
     */
    public function getAccountName(): ?string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * The account that you want to search for mismatched devices. If you don't specify an accountName, the
     * search includes all devices to which you have access.
     *
     * @maps accountName
     */
    public function setAccountName(?string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Group Name.
     * The name of a device group, to only include devices in that group.
     */
    public function getGroupName(): ?string
    {
        return $this->groupName;
    }

    /**
     * Sets Group Name.
     * The name of a device group, to only include devices in that group.
     *
     * @maps groupName
     */
    public function setGroupName(?string $groupName): void
    {
        $this->groupName = $groupName;
    }

    /**
     * Converts the DeviceMismatchListRequest object to a human-readable string representation.
     *
     * @return string The string representation of the DeviceMismatchListRequest object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DeviceMismatchListRequest',
            [
                'filter' => $this->filter,
                'devices' => $this->devices,
                'accountName' => $this->accountName,
                'groupName' => $this->groupName,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['filter', 'devices', 'accountName', 'groupName'];

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
        $json['filter']          = $this->filter;
        if (isset($this->devices)) {
            $json['devices']     = $this->devices;
        }
        if (isset($this->accountName)) {
            $json['accountName'] = $this->accountName;
        }
        if (isset($this->groupName)) {
            $json['groupName']   = $this->groupName;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
