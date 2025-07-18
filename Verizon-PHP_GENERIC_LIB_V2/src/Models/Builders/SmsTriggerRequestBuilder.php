<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\SmsTriggerRequest;

/**
 * Builder for model SmsTriggerRequest
 *
 * @see SmsTriggerRequest
 */
class SmsTriggerRequestBuilder
{
    /**
     * @var SmsTriggerRequest
     */
    private $instance;

    private function __construct(SmsTriggerRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Sms Trigger Request Builder object.
     */
    public static function init(): self
    {
        return new self(new SmsTriggerRequest());
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
     * @param int|null $value
     */
    public function threshold(?int $value): self
    {
        $this->instance->setThreshold($value);
        return $this;
    }

    /**
     * Initializes a new Sms Trigger Request object.
     */
    public function build(): SmsTriggerRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
