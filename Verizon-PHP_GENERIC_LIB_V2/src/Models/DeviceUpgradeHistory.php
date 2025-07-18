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
 * Firmware upgrade information.
 */
class DeviceUpgradeHistory implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $deviceId;

    /**
     * @var string|null
     */
    private $id;

    /**
     * @var string|null
     */
    private $accountName;

    /**
     * @var string|null
     */
    private $firmwareFrom;

    /**
     * @var string|null
     */
    private $firmwareTo;

    /**
     * @var string|null
     */
    private $startDate;

    /**
     * @var string|null
     */
    private $upgradeStartTime;

    /**
     * @var string|null
     */
    private $status;

    /**
     * @var string|null
     */
    private $reason;

    /**
     * Returns Device Id.
     * Device IMEI.
     */
    public function getDeviceId(): ?string
    {
        return $this->deviceId;
    }

    /**
     * Sets Device Id.
     * Device IMEI.
     *
     * @maps deviceId
     */
    public function setDeviceId(?string $deviceId): void
    {
        $this->deviceId = $deviceId;
    }

    /**
     * Returns Id.
     * The unique identifier for the upgrade.
     */
    public function getId(): ?string
    {
        return $this->id;
    }

    /**
     * Sets Id.
     * The unique identifier for the upgrade.
     *
     * @maps id
     */
    public function setId(?string $id): void
    {
        $this->id = $id;
    }

    /**
     * Returns Account Name.
     * The name (number) of the billing account that the device belongs to.
     */
    public function getAccountName(): ?string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * The name (number) of the billing account that the device belongs to.
     *
     * @maps accountName
     */
    public function setAccountName(?string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Firmware From.
     * The firmware version that was on the device before the upgrade.
     */
    public function getFirmwareFrom(): ?string
    {
        return $this->firmwareFrom;
    }

    /**
     * Sets Firmware From.
     * The firmware version that was on the device before the upgrade.
     *
     * @maps firmwareFrom
     */
    public function setFirmwareFrom(?string $firmwareFrom): void
    {
        $this->firmwareFrom = $firmwareFrom;
    }

    /**
     * Returns Firmware To.
     * The name of the firmware version that was on the device after the upgrade.
     */
    public function getFirmwareTo(): ?string
    {
        return $this->firmwareTo;
    }

    /**
     * Sets Firmware To.
     * The name of the firmware version that was on the device after the upgrade.
     *
     * @maps firmwareTo
     */
    public function setFirmwareTo(?string $firmwareTo): void
    {
        $this->firmwareTo = $firmwareTo;
    }

    /**
     * Returns Start Date.
     * The date of the upgrade.
     */
    public function getStartDate(): ?string
    {
        return $this->startDate;
    }

    /**
     * Sets Start Date.
     * The date of the upgrade.
     *
     * @maps startDate
     */
    public function setStartDate(?string $startDate): void
    {
        $this->startDate = $startDate;
    }

    /**
     * Returns Upgrade Start Time.
     * The date and time that the upgrade actually started for this device.
     */
    public function getUpgradeStartTime(): ?string
    {
        return $this->upgradeStartTime;
    }

    /**
     * Sets Upgrade Start Time.
     * The date and time that the upgrade actually started for this device.
     *
     * @maps upgradeStartTime
     */
    public function setUpgradeStartTime(?string $upgradeStartTime): void
    {
        $this->upgradeStartTime = $upgradeStartTime;
    }

    /**
     * Returns Status.
     * The status of the upgrade for this device.
     */
    public function getStatus(): ?string
    {
        return $this->status;
    }

    /**
     * Sets Status.
     * The status of the upgrade for this device.
     *
     * @maps status
     */
    public function setStatus(?string $status): void
    {
        $this->status = $status;
    }

    /**
     * Returns Reason.
     * More information about the status.
     */
    public function getReason(): ?string
    {
        return $this->reason;
    }

    /**
     * Sets Reason.
     * More information about the status.
     *
     * @maps reason
     */
    public function setReason(?string $reason): void
    {
        $this->reason = $reason;
    }

    /**
     * Converts the DeviceUpgradeHistory object to a human-readable string representation.
     *
     * @return string The string representation of the DeviceUpgradeHistory object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DeviceUpgradeHistory',
            [
                'deviceId' => $this->deviceId,
                'id' => $this->id,
                'accountName' => $this->accountName,
                'firmwareFrom' => $this->firmwareFrom,
                'firmwareTo' => $this->firmwareTo,
                'startDate' => $this->startDate,
                'upgradeStartTime' => $this->upgradeStartTime,
                'status' => $this->status,
                'reason' => $this->reason,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = [
        'deviceId',
        'id',
        'accountName',
        'firmwareFrom',
        'firmwareTo',
        'startDate',
        'upgradeStartTime',
        'status',
        'reason'
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
        if (isset($this->deviceId)) {
            $json['deviceId']         = $this->deviceId;
        }
        if (isset($this->id)) {
            $json['id']               = $this->id;
        }
        if (isset($this->accountName)) {
            $json['accountName']      = $this->accountName;
        }
        if (isset($this->firmwareFrom)) {
            $json['firmwareFrom']     = $this->firmwareFrom;
        }
        if (isset($this->firmwareTo)) {
            $json['firmwareTo']       = $this->firmwareTo;
        }
        if (isset($this->startDate)) {
            $json['startDate']        = $this->startDate;
        }
        if (isset($this->upgradeStartTime)) {
            $json['upgradeStartTime'] = $this->upgradeStartTime;
        }
        if (isset($this->status)) {
            $json['status']           = $this->status;
        }
        if (isset($this->reason)) {
            $json['reason']           = $this->reason;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
