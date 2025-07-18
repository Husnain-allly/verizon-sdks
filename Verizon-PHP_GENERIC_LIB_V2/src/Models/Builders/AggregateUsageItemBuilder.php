<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AggregateUsageItem;

/**
 * Builder for model AggregateUsageItem
 *
 * @see AggregateUsageItem
 */
class AggregateUsageItemBuilder
{
    /**
     * @var AggregateUsageItem
     */
    private $instance;

    private function __construct(AggregateUsageItem $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Aggregate Usage Item Builder object.
     */
    public static function init(): self
    {
        return new self(new AggregateUsageItem());
    }

    /**
     * Sets imei field.
     *
     * @param string|null $value
     */
    public function imei(?string $value): self
    {
        $this->instance->setImei($value);
        return $this;
    }

    /**
     * Sets number Of Sessions field.
     *
     * @param int|null $value
     */
    public function numberOfSessions(?int $value): self
    {
        $this->instance->setNumberOfSessions($value);
        return $this;
    }

    /**
     * Sets bytes Transferred field.
     *
     * @param int|null $value
     */
    public function bytesTransferred(?int $value): self
    {
        $this->instance->setBytesTransferred($value);
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
     * Initializes a new Aggregate Usage Item object.
     */
    public function build(): AggregateUsageItem
    {
        return CoreHelper::clone($this->instance);
    }
}
