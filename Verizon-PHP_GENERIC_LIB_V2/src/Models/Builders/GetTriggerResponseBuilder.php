<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\GetTriggerResponse;

/**
 * Builder for model GetTriggerResponse
 *
 * @see GetTriggerResponse
 */
class GetTriggerResponseBuilder
{
    /**
     * @var GetTriggerResponse
     */
    private $instance;

    private function __construct(GetTriggerResponse $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Get Trigger Response Builder object.
     */
    public static function init(): self
    {
        return new self(new GetTriggerResponse());
    }

    /**
     * Sets account Name field.
     *
     * @param string|null $value
     */
    public function accountName(?string $value): self
    {
        $this->instance->setAccountName($value);
        return $this;
    }

    /**
     * Sets comparator field.
     *
     * @param string|null $value
     */
    public function comparator(?string $value): self
    {
        $this->instance->setComparator($value);
        return $this;
    }

    /**
     * Sets created At field.
     *
     * @param \DateTime|null $value
     */
    public function createdAt(?\DateTime $value): self
    {
        $this->instance->setCreatedAt($value);
        return $this;
    }

    /**
     * Sets group Name field.
     *
     * @param string|null $value
     */
    public function groupName(?string $value): self
    {
        $this->instance->setGroupName($value);
        return $this;
    }

    /**
     * Sets modified At field.
     *
     * @param \DateTime|null $value
     */
    public function modifiedAt(?\DateTime $value): self
    {
        $this->instance->setModifiedAt($value);
        return $this;
    }

    /**
     * Sets notification Group Name field.
     *
     * @param string|null $value
     */
    public function notificationGroupName(?string $value): self
    {
        $this->instance->setNotificationGroupName($value);
        return $this;
    }

    /**
     * Sets organization Name field.
     *
     * @param string|null $value
     */
    public function organizationName(?string $value): self
    {
        $this->instance->setOrganizationName($value);
        return $this;
    }

    /**
     * Sets sms Type field.
     *
     * @param string|null $value
     */
    public function smsType(?string $value): self
    {
        $this->instance->setSmsType($value);
        return $this;
    }

    /**
     * Sets threshold field.
     *
     * @param string|null $value
     */
    public function threshold(?string $value): self
    {
        $this->instance->setThreshold($value);
        return $this;
    }

    /**
     * Sets threshold Unit field.
     *
     * @param string|null $value
     */
    public function thresholdUnit(?string $value): self
    {
        $this->instance->setThresholdUnit($value);
        return $this;
    }

    /**
     * Sets trigger Category field.
     *
     * @param string|null $value
     */
    public function triggerCategory(?string $value): self
    {
        $this->instance->setTriggerCategory($value);
        return $this;
    }

    /**
     * Sets trigger Cycle field.
     *
     * @param string|null $value
     */
    public function triggerCycle(?string $value): self
    {
        $this->instance->setTriggerCycle($value);
        return $this;
    }

    /**
     * Sets trigger Id field.
     *
     * @param string|null $value
     */
    public function triggerId(?string $value): self
    {
        $this->instance->setTriggerId($value);
        return $this;
    }

    /**
     * Sets trigger Name field.
     *
     * @param string|null $value
     */
    public function triggerName(?string $value): self
    {
        $this->instance->setTriggerName($value);
        return $this;
    }

    /**
     * Initializes a new Get Trigger Response object.
     */
    public function build(): GetTriggerResponse
    {
        return CoreHelper::clone($this->instance);
    }
}
