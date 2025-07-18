<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\QosDeviceInfo;
use VerizonLib\Models\SubscribeRequest;

/**
 * Builder for model SubscribeRequest
 *
 * @see SubscribeRequest
 */
class SubscribeRequestBuilder
{
    /**
     * @var SubscribeRequest
     */
    private $instance;

    private function __construct(SubscribeRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Subscribe Request Builder object.
     *
     * @param string $accountName
     * @param QosDeviceInfo[] $deviceInfo
     */
    public static function init(string $accountName, array $deviceInfo): self
    {
        return new self(new SubscribeRequest($accountName, $deviceInfo));
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
     * Initializes a new Subscribe Request object.
     */
    public function build(): SubscribeRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
