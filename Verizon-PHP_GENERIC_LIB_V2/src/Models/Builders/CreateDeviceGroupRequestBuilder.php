<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\CreateDeviceGroupRequest;
use VerizonLib\Models\DeviceId;

/**
 * Builder for model CreateDeviceGroupRequest
 *
 * @see CreateDeviceGroupRequest
 */
class CreateDeviceGroupRequestBuilder
{
    /**
     * @var CreateDeviceGroupRequest
     */
    private $instance;

    private function __construct(CreateDeviceGroupRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Create Device Group Request Builder object.
     *
     * @param string $accountName
     * @param string $groupDescription
     * @param string $groupName
     */
    public static function init(string $accountName, string $groupDescription, string $groupName): self
    {
        return new self(new CreateDeviceGroupRequest($accountName, $groupDescription, $groupName));
    }

    /**
     * Sets devices To Add field.
     *
     * @param DeviceId[]|null $value
     */
    public function devicesToAdd(?array $value): self
    {
        $this->instance->setDevicesToAdd($value);
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
     * Initializes a new Create Device Group Request object.
     */
    public function build(): CreateDeviceGroupRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
