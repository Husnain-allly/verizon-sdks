<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountLevelFilter;
use VerizonLib\Models\Cellphonenumber;
use VerizonLib\Models\DataTrigger4;
use VerizonLib\Models\Notificationarray;
use VerizonLib\Models\PricePlanTrigger1;
use VerizonLib\Models\Rateplantype2Condition;
use VerizonLib\Models\V2TriggersRequest;

/**
 * Builder for model V2TriggersRequest
 *
 * @see V2TriggersRequest
 */
class V2TriggersRequestBuilder
{
    /**
     * @var V2TriggersRequest
     */
    private $instance;

    private function __construct(V2TriggersRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new V2 Triggers Request Builder object.
     */
    public static function init(): self
    {
        return new self(new V2TriggersRequest());
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
     * Sets ecpd Id field.
     *
     * @param string|null $value
     */
    public function ecpdId(?string $value): self
    {
        $this->instance->setEcpdId($value);
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
     * Sets data Trigger field.
     *
     * @param DataTrigger4|null $value
     */
    public function dataTrigger(?DataTrigger4 $value): self
    {
        $this->instance->setDataTrigger($value);
        return $this;
    }

    /**
     * Sets notification field.
     *
     * @param Notificationarray|null $value
     */
    public function notification(?Notificationarray $value): self
    {
        $this->instance->setNotification($value);
        return $this;
    }

    /**
     * Sets notification Type field.
     *
     * @param string|null $value
     */
    public function notificationType(?string $value): self
    {
        $this->instance->setNotificationType($value);
        return $this;
    }

    /**
     * Sets callback field.
     *
     * @param bool|null $value
     */
    public function callback(?bool $value): self
    {
        $this->instance->setCallback($value);
        return $this;
    }

    /**
     * Sets email Notification field.
     *
     * @param bool|null $value
     */
    public function emailNotification(?bool $value): self
    {
        $this->instance->setEmailNotification($value);
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
     * Sets notification Frequency Factor field.
     *
     * @param int|null $value
     */
    public function notificationFrequencyFactor(?int $value): self
    {
        $this->instance->setNotificationFrequencyFactor($value);
        return $this;
    }

    /**
     * Sets notification Frequency Interval field.
     *
     * @param string|null $value
     */
    public function notificationFrequencyInterval(?string $value): self
    {
        $this->instance->setNotificationFrequencyInterval($value);
        return $this;
    }

    /**
     * Sets external Email Recipients field.
     *
     * @param string|null $value
     */
    public function externalEmailRecipients(?string $value): self
    {
        $this->instance->setExternalEmailRecipients($value);
        return $this;
    }

    /**
     * Sets sms Notification field.
     *
     * @param bool|null $value
     */
    public function smsNotification(?bool $value): self
    {
        $this->instance->setSmsNotification($value);
        return $this;
    }

    /**
     * Sets sms Numbers field.
     *
     * @param Cellphonenumber[]|null $value
     */
    public function smsNumbers(?array $value): self
    {
        $this->instance->setSmsNumbers($value);
        return $this;
    }

    /**
     * Sets reminder field.
     *
     * @param bool|null $value
     */
    public function reminder(?bool $value): self
    {
        $this->instance->setReminder($value);
        return $this;
    }

    /**
     * Sets severity field.
     *
     * @param string|null $value
     */
    public function severity(?string $value): self
    {
        $this->instance->setSeverity($value);
        return $this;
    }

    /**
     * Sets active field.
     *
     * @param string|null $value
     */
    public function active(?string $value): self
    {
        $this->instance->setActive($value);
        return $this;
    }

    /**
     * Sets filter Criteria field.
     *
     * @param AccountLevelFilter|null $value
     */
    public function filterCriteria(?AccountLevelFilter $value): self
    {
        $this->instance->setFilterCriteria($value);
        return $this;
    }

    /**
     * Sets condition field.
     *
     * @param Rateplantype2Condition|null $value
     */
    public function condition(?Rateplantype2Condition $value): self
    {
        $this->instance->setCondition($value);
        return $this;
    }

    /**
     * Sets action field.
     *
     * @param string|null $value
     */
    public function action(?string $value): self
    {
        $this->instance->setAction($value);
        return $this;
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
     * Sets price Plan Trigger field.
     *
     * @param PricePlanTrigger1|null $value
     */
    public function pricePlanTrigger(?PricePlanTrigger1 $value): self
    {
        $this->instance->setPricePlanTrigger($value);
        return $this;
    }

    /**
     * Add an additional property to this model.
     *
     * @param string $name Name of property.
     * @param mixed $value Value of property.
     */
    public function additionalProperty(string $name, $value): self
    {
        $this->instance->addAdditionalProperty($name, $value);
        return $this;
    }

    /**
     * Initializes a new V2 Triggers Request object.
     */
    public function build(): V2TriggersRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
