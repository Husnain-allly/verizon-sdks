<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Activeindicator;

/**
 * Builder for model Activeindicator
 *
 * @see Activeindicator
 */
class ActiveindicatorBuilder
{
    /**
     * @var Activeindicator
     */
    private $instance;

    private function __construct(Activeindicator $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Activeindicator Builder object.
     */
    public static function init(): self
    {
        return new self(new Activeindicator());
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
     * Initializes a new Activeindicator object.
     */
    public function build(): Activeindicator
    {
        return CoreHelper::clone($this->instance);
    }
}
