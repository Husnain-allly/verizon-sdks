<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Activate;

/**
 * Builder for model Activate
 *
 * @see Activate
 */
class ActivateBuilder
{
    /**
     * @var Activate
     */
    private $instance;

    private function __construct(Activate $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Activate Builder object.
     *
     * @param string $profile
     */
    public static function init(string $profile): self
    {
        return new self(new Activate($profile));
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
     * Initializes a new Activate object.
     */
    public function build(): Activate
    {
        return CoreHelper::clone($this->instance);
    }
}
