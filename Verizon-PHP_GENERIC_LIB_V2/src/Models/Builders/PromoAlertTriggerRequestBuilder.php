<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\PromoAlertTriggerRequest;

/**
 * Builder for model PromoAlertTriggerRequest
 *
 * @see PromoAlertTriggerRequest
 */
class PromoAlertTriggerRequestBuilder
{
    /**
     * @var PromoAlertTriggerRequest
     */
    private $instance;

    private function __construct(PromoAlertTriggerRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Promo Alert Trigger Request Builder object.
     */
    public static function init(): self
    {
        return new self(new PromoAlertTriggerRequest());
    }

    /**
     * Sets data Percentage 50 field.
     *
     * @param bool|null $value
     */
    public function dataPercentage50(?bool $value): self
    {
        $this->instance->setDataPercentage50($value);
        return $this;
    }

    /**
     * Sets data Percentage 75 field.
     *
     * @param bool|null $value
     */
    public function dataPercentage75(?bool $value): self
    {
        $this->instance->setDataPercentage75($value);
        return $this;
    }

    /**
     * Sets data Percentage 90 field.
     *
     * @param bool|null $value
     */
    public function dataPercentage90(?bool $value): self
    {
        $this->instance->setDataPercentage90($value);
        return $this;
    }

    /**
     * Sets no Of Days B4 Promo Exp field.
     *
     * @param int|null $value
     */
    public function noOfDaysB4PromoExp(?int $value): self
    {
        $this->instance->setNoOfDaysB4PromoExp($value);
        return $this;
    }

    /**
     * Sets sms Percentage 50 field.
     *
     * @param bool|null $value
     */
    public function smsPercentage50(?bool $value): self
    {
        $this->instance->setSmsPercentage50($value);
        return $this;
    }

    /**
     * Sets sms Percentage 75 field.
     *
     * @param bool|null $value
     */
    public function smsPercentage75(?bool $value): self
    {
        $this->instance->setSmsPercentage75($value);
        return $this;
    }

    /**
     * Sets sms Percentage 90 field.
     *
     * @param bool|null $value
     */
    public function smsPercentage90(?bool $value): self
    {
        $this->instance->setSmsPercentage90($value);
        return $this;
    }

    /**
     * Initializes a new Promo Alert Trigger Request object.
     */
    public function build(): PromoAlertTriggerRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
