<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AnomalyTriggerRequest;

/**
 * Builder for model AnomalyTriggerRequest
 *
 * @see AnomalyTriggerRequest
 */
class AnomalyTriggerRequestBuilder
{
    /**
     * @var AnomalyTriggerRequest
     */
    private $instance;

    private function __construct(AnomalyTriggerRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Anomaly Trigger Request Builder object.
     */
    public static function init(): self
    {
        return new self(new AnomalyTriggerRequest());
    }

    /**
     * Sets account Names field.
     *
     * @param string|null $value
     */
    public function accountNames(?string $value): self
    {
        $this->instance->setAccountNames($value);
        return $this;
    }

    /**
     * Sets include Abnormal field.
     *
     * @param bool|null $value
     */
    public function includeAbnormal(?bool $value): self
    {
        $this->instance->setIncludeAbnormal($value);
        return $this;
    }

    /**
     * Sets include Very Abnormal field.
     *
     * @param bool|null $value
     */
    public function includeVeryAbnormal(?bool $value): self
    {
        $this->instance->setIncludeVeryAbnormal($value);
        return $this;
    }

    /**
     * Sets include Under Expected Usage field.
     *
     * @param bool|null $value
     */
    public function includeUnderExpectedUsage(?bool $value): self
    {
        $this->instance->setIncludeUnderExpectedUsage($value);
        return $this;
    }

    /**
     * Sets include Over Expected Usage field.
     *
     * @param bool|null $value
     */
    public function includeOverExpectedUsage(?bool $value): self
    {
        $this->instance->setIncludeOverExpectedUsage($value);
        return $this;
    }

    /**
     * Initializes a new Anomaly Trigger Request object.
     */
    public function build(): AnomalyTriggerRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
