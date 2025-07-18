<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\M5GBiAddress;

/**
 * Builder for model M5GBiAddress
 *
 * @see M5GBiAddress
 */
class M5GBiAddressBuilder
{
    /**
     * @var M5GBiAddress
     */
    private $instance;

    private function __construct(M5GBiAddress $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new M5 G Bi Address Builder object.
     */
    public static function init(): self
    {
        return new self(new M5GBiAddress());
    }

    /**
     * Sets address Line 1 field.
     *
     * @param string|null $value
     */
    public function addressLine1(?string $value): self
    {
        $this->instance->setAddressLine1($value);
        return $this;
    }

    /**
     * Sets city field.
     *
     * @param string|null $value
     */
    public function city(?string $value): self
    {
        $this->instance->setCity($value);
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
     * Sets zip field.
     *
     * @param string|null $value
     */
    public function zip(?string $value): self
    {
        $this->instance->setZip($value);
        return $this;
    }

    /**
     * Sets zip 4 field.
     *
     * @param string|null $value
     */
    public function zip4(?string $value): self
    {
        $this->instance->setZip4($value);
        return $this;
    }

    /**
     * Sets phone field.
     *
     * @param string|null $value
     */
    public function phone(?string $value): self
    {
        $this->instance->setPhone($value);
        return $this;
    }

    /**
     * Sets phone Type field.
     *
     * @param string|null $value
     */
    public function phoneType(?string $value): self
    {
        $this->instance->setPhoneType($value);
        return $this;
    }

    /**
     * Sets email Address field.
     *
     * @param string|null $value
     */
    public function emailAddress(?string $value): self
    {
        $this->instance->setEmailAddress($value);
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
     * Initializes a new M5 G Bi Address object.
     */
    public function build(): M5GBiAddress
    {
        return CoreHelper::clone($this->instance);
    }
}
