<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DmV1DevicesActionsSetRequest;
use VerizonLib\Models\DtoDeviceActionSetConfiguration1;
use VerizonLib\Models\DtoDeviceResourceIdentifier1;

/**
 * Builder for model DmV1DevicesActionsSetRequest
 *
 * @see DmV1DevicesActionsSetRequest
 */
class DmV1DevicesActionsSetRequestBuilder
{
    /**
     * @var DmV1DevicesActionsSetRequest
     */
    private $instance;

    private function __construct(DmV1DevicesActionsSetRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Dm V1 Devices Actions Set Request Builder object.
     */
    public static function init(): self
    {
        return new self(new DmV1DevicesActionsSetRequest());
    }

    /**
     * Sets accountname field.
     *
     * @param string|null $value
     */
    public function accountname(?string $value): self
    {
        $this->instance->setAccountname($value);
        return $this;
    }

    /**
     * Sets configuration field.
     *
     * @param DtoDeviceActionSetConfiguration1|null $value
     */
    public function configuration(?DtoDeviceActionSetConfiguration1 $value): self
    {
        $this->instance->setConfiguration($value);
        return $this;
    }

    /**
     * Sets resourceidentifier field.
     *
     * @param DtoDeviceResourceIdentifier1|null $value
     */
    public function resourceidentifier(?DtoDeviceResourceIdentifier1 $value): self
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
     * Initializes a new Dm V1 Devices Actions Set Request object.
     */
    public function build(): DmV1DevicesActionsSetRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
