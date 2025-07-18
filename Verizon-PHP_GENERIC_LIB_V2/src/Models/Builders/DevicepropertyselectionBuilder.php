<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Devicepropertyselection;

/**
 * Builder for model Devicepropertyselection
 *
 * @see Devicepropertyselection
 */
class DevicepropertyselectionBuilder
{
    /**
     * @var Devicepropertyselection
     */
    private $instance;

    private function __construct(Devicepropertyselection $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Devicepropertyselection Builder object.
     */
    public static function init(): self
    {
        return new self(new Devicepropertyselection());
    }

    /**
     * Sets modelid field.
     *
     * @param string|null $value
     */
    public function modelid(?string $value): self
    {
        $this->instance->setModelid($value);
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
     * Initializes a new Devicepropertyselection object.
     */
    public function build(): Devicepropertyselection
    {
        return CoreHelper::clone($this->instance);
    }
}
