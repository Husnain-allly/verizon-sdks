<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\M5GBideviceId1;

/**
 * Builder for model M5GBideviceId1
 *
 * @see M5GBideviceId1
 */
class M5GBideviceId1Builder
{
    /**
     * @var M5GBideviceId1
     */
    private $instance;

    private function __construct(M5GBideviceId1 $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new M5 G Bidevice Id 1 Builder object.
     */
    public static function init(): self
    {
        return new self(new M5GBideviceId1());
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
     * Initializes a new M5 G Bidevice Id 1 object.
     */
    public function build(): M5GBideviceId1
    {
        return CoreHelper::clone($this->instance);
    }
}
