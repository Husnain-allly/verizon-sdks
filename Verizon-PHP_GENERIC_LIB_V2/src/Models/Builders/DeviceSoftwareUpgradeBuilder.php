<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DeviceSoftwareUpgrade;

/**
 * Builder for model DeviceSoftwareUpgrade
 *
 * @see DeviceSoftwareUpgrade
 */
class DeviceSoftwareUpgradeBuilder
{
    /**
     * @var DeviceSoftwareUpgrade
     */
    private $instance;

    private function __construct(DeviceSoftwareUpgrade $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Device Software Upgrade Builder object.
     *
     * @param string $deviceId
     * @param string $id
     * @param string $accountName
     * @param \DateTime $startDate
     * @param string $status
     * @param string $reason
     */
    public static function init(
        string $deviceId,
        string $id,
        string $accountName,
        \DateTime $startDate,
        string $status,
        string $reason
    ): self {
        return new self(new DeviceSoftwareUpgrade($deviceId, $id, $accountName, $startDate, $status, $reason));
    }

    /**
     * Sets software Name field.
     *
     * @param string|null $value
     */
    public function softwareName(?string $value): self
    {
        $this->instance->setSoftwareName($value);
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
     * Initializes a new Device Software Upgrade object.
     */
    public function build(): DeviceSoftwareUpgrade
    {
        return CoreHelper::clone($this->instance);
    }
}
