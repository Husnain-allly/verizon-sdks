<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\FindDeviceByPropertyResponse;

/**
 * Builder for model FindDeviceByPropertyResponse
 *
 * @see FindDeviceByPropertyResponse
 */
class FindDeviceByPropertyResponseBuilder
{
    /**
     * @var FindDeviceByPropertyResponse
     */
    private $instance;

    private function __construct(FindDeviceByPropertyResponse $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Find Device By Property Response Builder object.
     */
    public static function init(): self
    {
        return new self(new FindDeviceByPropertyResponse());
    }

    /**
     * Sets billingaccountid field.
     *
     * @param string|null $value
     */
    public function billingaccountid(?string $value): self
    {
        $this->instance->setBillingaccountid($value);
        return $this;
    }

    /**
     * Sets createdon field.
     *
     * @param string|null $value
     */
    public function createdon(?string $value): self
    {
        $this->instance->setCreatedon($value);
        return $this;
    }

    /**
     * Sets eventretention field.
     *
     * @param string|null $value
     */
    public function eventretention(?string $value): self
    {
        $this->instance->setEventretention($value);
        return $this;
    }

    /**
     * Sets iccid field.
     *
     * @param string|null $value
     */
    public function iccid(?string $value): self
    {
        $this->instance->setIccid($value);
        return $this;
    }

    /**
     * Sets id field.
     *
     * @param string|null $value
     */
    public function id(?string $value): self
    {
        $this->instance->setId($value);
        return $this;
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
     * Sets kind field.
     *
     * @param string|null $value
     */
    public function kind(?string $value): self
    {
        $this->instance->setKind($value);
        return $this;
    }

    /**
     * Sets lastupdated field.
     *
     * @param string|null $value
     */
    public function lastupdated(?string $value): self
    {
        $this->instance->setLastupdated($value);
        return $this;
    }

    /**
     * Sets providerid field.
     *
     * @param string|null $value
     */
    public function providerid(?string $value): self
    {
        $this->instance->setProviderid($value);
        return $this;
    }

    /**
     * Sets refid field.
     *
     * @param string|null $value
     */
    public function refid(?string $value): self
    {
        $this->instance->setRefid($value);
        return $this;
    }

    /**
     * Sets refidtype field.
     *
     * @param string|null $value
     */
    public function refidtype(?string $value): self
    {
        $this->instance->setRefidtype($value);
        return $this;
    }

    /**
     * Sets state field.
     *
     * @param string|null $value
     */
    public function state(?string $value): self
    {
        $this->instance->setState($value);
        return $this;
    }

    /**
     * Sets version field.
     *
     * @param string|null $value
     */
    public function version(?string $value): self
    {
        $this->instance->setVersion($value);
        return $this;
    }

    /**
     * Sets versionid field.
     *
     * @param string|null $value
     */
    public function versionid(?string $value): self
    {
        $this->instance->setVersionid($value);
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
     * Initializes a new Find Device By Property Response object.
     */
    public function build(): FindDeviceByPropertyResponse
    {
        return CoreHelper::clone($this->instance);
    }
}
