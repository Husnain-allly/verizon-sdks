<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\UsageHistory;

/**
 * Builder for model UsageHistory
 *
 * @see UsageHistory
 */
class UsageHistoryBuilder
{
    /**
     * @var UsageHistory
     */
    private $instance;

    private function __construct(UsageHistory $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Usage History Builder object.
     */
    public static function init(): self
    {
        return new self(new UsageHistory());
    }

    /**
     * Sets bytes Used field.
     *
     * @param int|null $value
     */
    public function bytesUsed(?int $value): self
    {
        $this->instance->setBytesUsed($value);
        return $this;
    }

    /**
     * Sets serviceplan field.
     *
     * @param string|null $value
     */
    public function serviceplan(?string $value): self
    {
        $this->instance->setServiceplan($value);
        return $this;
    }

    /**
     * Sets sms Used field.
     *
     * @param int|null $value
     */
    public function smsUsed(?int $value): self
    {
        $this->instance->setSmsUsed($value);
        return $this;
    }

    /**
     * Sets mo SMS field.
     *
     * @param int|null $value
     */
    public function moSms(?int $value): self
    {
        $this->instance->setMoSms($value);
        return $this;
    }

    /**
     * Sets mt SMS field.
     *
     * @param int|null $value
     */
    public function mtSms(?int $value): self
    {
        $this->instance->setMtSms($value);
        return $this;
    }

    /**
     * Sets source field.
     *
     * @param string|null $value
     */
    public function source(?string $value): self
    {
        $this->instance->setSource($value);
        return $this;
    }

    /**
     * Sets event Date Time field.
     *
     * @param \DateTime|null $value
     */
    public function eventDateTime(?\DateTime $value): self
    {
        $this->instance->setEventDateTime($value);
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
     * Initializes a new Usage History object.
     */
    public function build(): UsageHistory
    {
        return CoreHelper::clone($this->instance);
    }
}
