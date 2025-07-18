<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Notificationarray;
use VerizonLib\Models\PricePlanTrigger;
use VerizonLib\Models\Updatetriggerchunk;

/**
 * Builder for model Updatetriggerchunk
 *
 * @see Updatetriggerchunk
 */
class UpdatetriggerchunkBuilder
{
    /**
     * @var Updatetriggerchunk
     */
    private $instance;

    private function __construct(Updatetriggerchunk $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Updatetriggerchunk Builder object.
     */
    public static function init(): self
    {
        return new self(new Updatetriggerchunk());
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
     * Sets price Plan Trigger field.
     *
     * @param PricePlanTrigger|null $value
     */
    public function pricePlanTrigger(?PricePlanTrigger $value): self
    {
        $this->instance->setPricePlanTrigger($value);
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
     * Initializes a new Updatetriggerchunk object.
     */
    public function build(): Updatetriggerchunk
    {
        return CoreHelper::clone($this->instance);
    }
}
