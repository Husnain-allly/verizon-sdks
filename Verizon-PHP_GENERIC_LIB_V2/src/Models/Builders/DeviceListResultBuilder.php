<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DeviceListResult;
use VerizonLib\Models\V3Device;

/**
 * Builder for model DeviceListResult
 *
 * @see DeviceListResult
 */
class DeviceListResultBuilder
{
    /**
     * @var DeviceListResult
     */
    private $instance;

    private function __construct(DeviceListResult $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Device List Result Builder object.
     *
     * @param string $accountName
     * @param int $deviceCount
     * @param V3Device[] $deviceList
     */
    public static function init(string $accountName, int $deviceCount, array $deviceList): self
    {
        return new self(new DeviceListResult($accountName, $deviceCount, $deviceList));
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
     * Initializes a new Device List Result object.
     */
    public function build(): DeviceListResult
    {
        return CoreHelper::clone($this->instance);
    }
}
