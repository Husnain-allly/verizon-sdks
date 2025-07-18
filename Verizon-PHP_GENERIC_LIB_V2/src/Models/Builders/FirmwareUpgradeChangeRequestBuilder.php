<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\FirmwareUpgradeChangeRequest;

/**
 * Builder for model FirmwareUpgradeChangeRequest
 *
 * @see FirmwareUpgradeChangeRequest
 */
class FirmwareUpgradeChangeRequestBuilder
{
    /**
     * @var FirmwareUpgradeChangeRequest
     */
    private $instance;

    private function __construct(FirmwareUpgradeChangeRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Firmware Upgrade Change Request Builder object.
     *
     * @param string $type
     * @param string[] $deviceList
     */
    public static function init(string $type, array $deviceList): self
    {
        return new self(new FirmwareUpgradeChangeRequest($type, $deviceList));
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
     * Initializes a new Firmware Upgrade Change Request object.
     */
    public function build(): FirmwareUpgradeChangeRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
