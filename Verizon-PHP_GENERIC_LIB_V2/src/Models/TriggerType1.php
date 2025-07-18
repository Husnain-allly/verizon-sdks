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
 * Trigger details.
 */
class TriggerType1 implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $name;

    /**
     * @var string|null
     */
    private $triggerCategory;

    /**
     * @var string|null
     */
    private $accountName;

    /**
     * @var AnomalyTriggerRequest|null
     */
    private $anomalyTriggerRequest;

    /**
     * @var TriggerNotification|null
     */
    private $notification;

    /**
     * Returns Name.
     * Trigger name.
     */
    public function getName(): ?string
    {
        return $this->name;
    }

    /**
     * Sets Name.
     * Trigger name.
     *
     * @maps name
     */
    public function setName(?string $name): void
    {
        $this->name = $name;
    }

    /**
     * Returns Trigger Category.
     * This is the value to use in the request body to detect anomalous behaivior. The values in this table
     * will only be relevant when this parameter is set to this value.
     */
    public function getTriggerCategory(): ?string
    {
        return $this->triggerCategory;
    }

    /**
     * Sets Trigger Category.
     * This is the value to use in the request body to detect anomalous behaivior. The values in this table
     * will only be relevant when this parameter is set to this value.
     *
     * @maps triggerCategory
     */
    public function setTriggerCategory(?string $triggerCategory): void
    {
        $this->triggerCategory = $triggerCategory;
    }

    /**
     * Returns Account Name.
     * Account name.
     */
    public function getAccountName(): ?string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * Account name.
     *
     * @maps accountName
     */
    public function setAccountName(?string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Anomaly Trigger Request.
     * The details of the UsageAnomaly trigger.
     */
    public function getAnomalyTriggerRequest(): ?AnomalyTriggerRequest
    {
        return $this->anomalyTriggerRequest;
    }

    /**
     * Sets Anomaly Trigger Request.
     * The details of the UsageAnomaly trigger.
     *
     * @maps anomalyTriggerRequest
     */
    public function setAnomalyTriggerRequest(?AnomalyTriggerRequest $anomalyTriggerRequest): void
    {
        $this->anomalyTriggerRequest = $anomalyTriggerRequest;
    }

    /**
     * Returns Notification.
     * The notification details of the trigger.
     */
    public function getNotification(): ?TriggerNotification
    {
        return $this->notification;
    }

    /**
     * Sets Notification.
     * The notification details of the trigger.
     *
     * @maps notification
     */
    public function setNotification(?TriggerNotification $notification): void
    {
        $this->notification = $notification;
    }

    /**
     * Converts the TriggerType1 object to a human-readable string representation.
     *
     * @return string The string representation of the TriggerType1 object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'TriggerType1',
            [
                'name' => $this->name,
                'triggerCategory' => $this->triggerCategory,
                'accountName' => $this->accountName,
                'anomalyTriggerRequest' => $this->anomalyTriggerRequest,
                'notification' => $this->notification
            ]
        );
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
        if (isset($this->name)) {
            $json['name']                  = $this->name;
        }
        if (isset($this->triggerCategory)) {
            $json['triggerCategory']       = $this->triggerCategory;
        }
        if (isset($this->accountName)) {
            $json['accountName']           = $this->accountName;
        }
        if (isset($this->anomalyTriggerRequest)) {
            $json['anomalyTriggerRequest'] = $this->anomalyTriggerRequest;
        }
        if (isset($this->notification)) {
            $json['notification']          = $this->notification;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
