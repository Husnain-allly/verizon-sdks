<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DtoDeviceCommand;
use VerizonLib\Models\DtoResourceidentifier;
use VerizonLib\Models\Rbstiltconfig;

/**
 * Builder for model DtoDeviceCommand
 *
 * @see DtoDeviceCommand
 */
class DtoDeviceCommandBuilder
{
    /**
     * @var DtoDeviceCommand
     */
    private $instance;

    private function __construct(DtoDeviceCommand $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Dto Device Command Builder object.
     */
    public static function init(): self
    {
        return new self(new DtoDeviceCommand());
    }

    /**
     * Sets account Name field.
     *
     * @param string|null $value
     */
    public function accountName(?string $value): self
    {
        $this->instance->setAccountName($value);
        return $this;
    }

    /**
     * Sets configuration field.
     *
     * @param Rbstiltconfig|null $value
     */
    public function configuration(?Rbstiltconfig $value): self
    {
        $this->instance->setConfiguration($value);
        return $this;
    }

    /**
     * Sets resourceidentifier field.
     *
     * @param DtoResourceidentifier|null $value
     */
    public function resourceidentifier(?DtoResourceidentifier $value): self
    {
        $this->instance->setResourceidentifier($value);
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
     * Initializes a new Dto Device Command object.
     */
    public function build(): DtoDeviceCommand
    {
        return CoreHelper::clone($this->instance);
    }
}
