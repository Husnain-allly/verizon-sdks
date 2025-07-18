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
use VerizonLib\Utils\DateTimeHelper;

/**
 * The list of devices that have licenses assigned, including the date and time of when each license
 * was assigned.
 */
class AccountLicenseDeviceListItem implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $deviceId;

    /**
     * @var \DateTime|null
     */
    private $assignmentTime;

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
     * Returns Assignment Time.
     * Timestamp of when a license was assigned to the device.
     */
    public function getAssignmentTime(): ?\DateTime
    {
        return $this->assignmentTime;
    }

    /**
     * Sets Assignment Time.
     * Timestamp of when a license was assigned to the device.
     *
     * @maps assignmentTime
     * @factory \VerizonLib\Utils\DateTimeHelper::fromRfc3339DateTime
     */
    public function setAssignmentTime(?\DateTime $assignmentTime): void
    {
        $this->assignmentTime = $assignmentTime;
    }

    /**
     * Converts the AccountLicenseDeviceListItem object to a human-readable string representation.
     *
     * @return string The string representation of the AccountLicenseDeviceListItem object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'AccountLicenseDeviceListItem',
            [
                'deviceId' => $this->deviceId,
                'assignmentTime' => $this->assignmentTime,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['deviceId', 'assignmentTime'];

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
            $json['deviceId']       = $this->deviceId;
        }
        if (isset($this->assignmentTime)) {
            $json['assignmentTime'] = DateTimeHelper::toRfc3339DateTime($this->assignmentTime);
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
