<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\V3AccountDevice;
use VerizonLib\Models\V3AccountDeviceList;

/**
 * Builder for model V3AccountDeviceList
 *
 * @see V3AccountDeviceList
 */
class V3AccountDeviceListBuilder
{
    /**
     * @var V3AccountDeviceList
     */
    private $instance;

    private function __construct(V3AccountDeviceList $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new V3 Account Device List Builder object.
     *
     * @param string $accountName
     * @param bool $hasMoreData
     * @param int $maxPageSize
     * @param V3AccountDevice[] $deviceList
     */
    public static function init(string $accountName, bool $hasMoreData, int $maxPageSize, array $deviceList): self
    {
        return new self(new V3AccountDeviceList($accountName, $hasMoreData, $maxPageSize, $deviceList));
    }

    /**
     * Sets last Seen Device Id field.
     *
     * @param string|null $value
     */
    public function lastSeenDeviceId(?string $value): self
    {
        $this->instance->setLastSeenDeviceId($value);
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
     * Initializes a new V3 Account Device List object.
     */
    public function build(): V3AccountDeviceList
    {
        return CoreHelper::clone($this->instance);
    }
}
