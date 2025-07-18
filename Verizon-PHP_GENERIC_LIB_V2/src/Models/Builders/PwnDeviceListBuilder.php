<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\PwnDeviceId;
use VerizonLib\Models\PwnDeviceList;

/**
 * Builder for model PwnDeviceList
 *
 * @see PwnDeviceList
 */
class PwnDeviceListBuilder
{
    /**
     * @var PwnDeviceList
     */
    private $instance;

    private function __construct(PwnDeviceList $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Pwn Device List Builder object.
     *
     * @param PwnDeviceId[] $deviceIds
     */
    public static function init(array $deviceIds): self
    {
        return new self(new PwnDeviceList($deviceIds));
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
     * Initializes a new Pwn Device List object.
     */
    public function build(): PwnDeviceList
    {
        return CoreHelper::clone($this->instance);
    }
}
