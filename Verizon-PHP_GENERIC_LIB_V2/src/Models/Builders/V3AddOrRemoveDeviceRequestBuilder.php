<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\V3AddOrRemoveDeviceRequest;

/**
 * Builder for model V3AddOrRemoveDeviceRequest
 *
 * @see V3AddOrRemoveDeviceRequest
 */
class V3AddOrRemoveDeviceRequestBuilder
{
    /**
     * @var V3AddOrRemoveDeviceRequest
     */
    private $instance;

    private function __construct(V3AddOrRemoveDeviceRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new V3 Add Or Remove Device Request Builder object.
     *
     * @param string $type
     * @param string[] $deviceList
     */
    public static function init(string $type, array $deviceList): self
    {
        return new self(new V3AddOrRemoveDeviceRequest($type, $deviceList));
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
     * Initializes a new V3 Add Or Remove Device Request object.
     */
    public function build(): V3AddOrRemoveDeviceRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
