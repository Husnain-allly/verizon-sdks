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
 * Check-in history for a device.
 */
class CheckInHistoryItem implements \JsonSerializable
{
    /**
     * @var string
     */
    private $deviceId;

    /**
     * @var string
     */
    private $clientType;

    /**
     * @var string
     */
    private $result;

    /**
     * @var string
     */
    private $failureType;

    /**
     * @var \DateTime
     */
    private $timeCompleted;

    /**
     * @param string $deviceId
     * @param string $clientType
     * @param string $result
     * @param string $failureType
     * @param \DateTime $timeCompleted
     */
    public function __construct(
        string $deviceId,
        string $clientType,
        string $result,
        string $failureType,
        \DateTime $timeCompleted
    ) {
        $this->deviceId = $deviceId;
        $this->clientType = $clientType;
        $this->result = $result;
        $this->failureType = $failureType;
        $this->timeCompleted = $timeCompleted;
    }

    /**
     * Returns Device Id.
     * Device IMEI.
     */
    public function getDeviceId(): string
    {
        return $this->deviceId;
    }

    /**
     * Sets Device Id.
     * Device IMEI.
     *
     * @required
     * @maps deviceId
     */
    public function setDeviceId(string $deviceId): void
    {
        $this->deviceId = $deviceId;
    }

    /**
     * Returns Client Type.
     * Type of client.
     */
    public function getClientType(): string
    {
        return $this->clientType;
    }

    /**
     * Sets Client Type.
     * Type of client.
     *
     * @required
     * @maps clientType
     */
    public function setClientType(string $clientType): void
    {
        $this->clientType = $clientType;
    }

    /**
     * Returns Result.
     */
    public function getResult(): string
    {
        return $this->result;
    }

    /**
     * Sets Result.
     *
     * @required
     * @maps result
     */
    public function setResult(string $result): void
    {
        $this->result = $result;
    }

    /**
     * Returns Failure Type.
     */
    public function getFailureType(): string
    {
        return $this->failureType;
    }

    /**
     * Sets Failure Type.
     *
     * @required
     * @maps failureType
     */
    public function setFailureType(string $failureType): void
    {
        $this->failureType = $failureType;
    }

    /**
     * Returns Time Completed.
     */
    public function getTimeCompleted(): \DateTime
    {
        return $this->timeCompleted;
    }

    /**
     * Sets Time Completed.
     *
     * @required
     * @maps timeCompleted
     * @factory \VerizonLib\Utils\DateTimeHelper::fromRfc3339DateTime
     */
    public function setTimeCompleted(\DateTime $timeCompleted): void
    {
        $this->timeCompleted = $timeCompleted;
    }

    /**
     * Converts the CheckInHistoryItem object to a human-readable string representation.
     *
     * @return string The string representation of the CheckInHistoryItem object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'CheckInHistoryItem',
            [
                'deviceId' => $this->deviceId,
                'clientType' => $this->clientType,
                'result' => $this->result,
                'failureType' => $this->failureType,
                'timeCompleted' => $this->timeCompleted,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['deviceId', 'clientType', 'result', 'failureType', 'timeCompleted'];

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
        $json['deviceId']      = $this->deviceId;
        $json['clientType']    = $this->clientType;
        $json['result']        = $this->result;
        $json['failureType']   = $this->failureType;
        $json['timeCompleted'] = DateTimeHelper::toRfc3339DateTime($this->timeCompleted);
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
