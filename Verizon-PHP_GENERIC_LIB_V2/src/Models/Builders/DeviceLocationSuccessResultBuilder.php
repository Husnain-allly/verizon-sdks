<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DeviceLocationSuccessResult;

/**
 * Builder for model DeviceLocationSuccessResult
 *
 * @see DeviceLocationSuccessResult
 */
class DeviceLocationSuccessResultBuilder
{
    /**
     * @var DeviceLocationSuccessResult
     */
    private $instance;

    private function __construct(DeviceLocationSuccessResult $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Device Location Success Result Builder object.
     */
    public static function init(): self
    {
        return new self(new DeviceLocationSuccessResult());
    }

    /**
     * Sets success field.
     *
     * @param bool|null $value
     */
    public function success(?bool $value): self
    {
        $this->instance->setSuccess($value);
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
     * Initializes a new Device Location Success Result object.
     */
    public function build(): DeviceLocationSuccessResult
    {
        return CoreHelper::clone($this->instance);
    }
}
