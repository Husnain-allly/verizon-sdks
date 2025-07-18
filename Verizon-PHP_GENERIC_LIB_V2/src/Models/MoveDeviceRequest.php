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
 * Request to move active devices from one billing account to another within a customer profile.
 */
class MoveDeviceRequest implements \JsonSerializable
{
    /**
     * @var string
     */
    private $accountName;

    /**
     * @var DeviceFilter|null
     */
    private $filter;

    /**
     * @var CustomFields[]|null
     */
    private $customFields;

    /**
     * @var AccountDeviceList[]|null
     */
    private $devices;

    /**
     * @var string|null
     */
    private $groupName;

    /**
     * @var string|null
     */
    private $carrierIpPoolName;

    /**
     * @var string|null
     */
    private $servicePlan;

    /**
     * @param string $accountName
     */
    public function __construct(string $accountName)
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Account Name.
     * The name of the billing account that you want to move the devices to.
     */
    public function getAccountName(): string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * The name of the billing account that you want to move the devices to.
     *
     * @required
     * @maps accountName
     */
    public function setAccountName(string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Filter.
     * Specify the kind of the device identifier, the type of match, and the string that you want to match.
     */
    public function getFilter(): ?DeviceFilter
    {
        return $this->filter;
    }

    /**
     * Sets Filter.
     * Specify the kind of the device identifier, the type of match, and the string that you want to match.
     *
     * @maps filter
     */
    public function setFilter(?DeviceFilter $filter): void
    {
        $this->filter = $filter;
    }

    /**
     * Returns Custom Fields.
     * Custom field names and values, if you want to only include devices that have matching values.
     *
     * @return CustomFields[]|null
     */
    public function getCustomFields(): ?array
    {
        return $this->customFields;
    }

    /**
     * Sets Custom Fields.
     * Custom field names and values, if you want to only include devices that have matching values.
     *
     * @maps customFields
     *
     * @param CustomFields[]|null $customFields
     */
    public function setCustomFields(?array $customFields): void
    {
        $this->customFields = $customFields;
    }

    /**
     * Returns Devices.
     * Up to 10,000 devices that you want to move to a different account, specified by device identifier.
     *
     * @return AccountDeviceList[]|null
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
     * @param AccountDeviceList[]|null $devices
     */
    public function setDevices(?array $devices): void
    {
        $this->devices = $devices;
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
     * Returns Carrier Ip Pool Name.
     * The pool from which device IP addresses will be derived in the new account. If you do not include
     * this element, the default pool will be used.
     */
    public function getCarrierIpPoolName(): ?string
    {
        return $this->carrierIpPoolName;
    }

    /**
     * Sets Carrier Ip Pool Name.
     * The pool from which device IP addresses will be derived in the new account. If you do not include
     * this element, the default pool will be used.
     *
     * @maps carrierIpPoolName
     */
    public function setCarrierIpPoolName(?string $carrierIpPoolName): void
    {
        $this->carrierIpPoolName = $carrierIpPoolName;
    }

    /**
     * Returns Service Plan.
     * The service plan code that you want to assign to the devices in the new account. If you do not
     * include this element, ThingSpace will attempt to use the current service plan, which will result in
     * a error if the new account does not have that service plan.
     */
    public function getServicePlan(): ?string
    {
        return $this->servicePlan;
    }

    /**
     * Sets Service Plan.
     * The service plan code that you want to assign to the devices in the new account. If you do not
     * include this element, ThingSpace will attempt to use the current service plan, which will result in
     * a error if the new account does not have that service plan.
     *
     * @maps servicePlan
     */
    public function setServicePlan(?string $servicePlan): void
    {
        $this->servicePlan = $servicePlan;
    }

    /**
     * Converts the MoveDeviceRequest object to a human-readable string representation.
     *
     * @return string The string representation of the MoveDeviceRequest object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'MoveDeviceRequest',
            [
                'accountName' => $this->accountName,
                'filter' => $this->filter,
                'customFields' => $this->customFields,
                'devices' => $this->devices,
                'groupName' => $this->groupName,
                'carrierIpPoolName' => $this->carrierIpPoolName,
                'servicePlan' => $this->servicePlan,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = [
        'accountName',
        'filter',
        'customFields',
        'devices',
        'groupName',
        'carrierIpPoolName',
        'servicePlan'
    ];

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
        $json['accountName']           = $this->accountName;
        if (isset($this->filter)) {
            $json['filter']            = $this->filter;
        }
        if (isset($this->customFields)) {
            $json['customFields']      = $this->customFields;
        }
        if (isset($this->devices)) {
            $json['devices']           = $this->devices;
        }
        if (isset($this->groupName)) {
            $json['groupName']         = $this->groupName;
        }
        if (isset($this->carrierIpPoolName)) {
            $json['carrierIpPoolName'] = $this->carrierIpPoolName;
        }
        if (isset($this->servicePlan)) {
            $json['servicePlan']       = $this->servicePlan;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
