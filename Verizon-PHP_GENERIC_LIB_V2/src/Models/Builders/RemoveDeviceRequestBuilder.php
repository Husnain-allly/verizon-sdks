<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountIdentifier;
use VerizonLib\Models\RemoveDeviceRequest;
use VerizonLib\Models\ResourceIdentifier;

/**
 * Builder for model RemoveDeviceRequest
 *
 * @see RemoveDeviceRequest
 */
class RemoveDeviceRequestBuilder
{
    /**
     * @var RemoveDeviceRequest
     */
    private $instance;

    private function __construct(RemoveDeviceRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Remove Device Request Builder object.
     *
     * @param AccountIdentifier $accountidentifier
     * @param ResourceIdentifier $resourceidentifier
     */
    public static function init(AccountIdentifier $accountidentifier, ResourceIdentifier $resourceidentifier): self
    {
        return new self(new RemoveDeviceRequest($accountidentifier, $resourceidentifier));
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
     * Initializes a new Remove Device Request object.
     */
    public function build(): RemoveDeviceRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
