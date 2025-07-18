<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountDeviceList;
use VerizonLib\Models\CustomFields;
use VerizonLib\Models\DeviceCostCenterRequest;

/**
 * Builder for model DeviceCostCenterRequest
 *
 * @see DeviceCostCenterRequest
 */
class DeviceCostCenterRequestBuilder
{
    /**
     * @var DeviceCostCenterRequest
     */
    private $instance;

    private function __construct(DeviceCostCenterRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Device Cost Center Request Builder object.
     */
    public static function init(): self
    {
        return new self(new DeviceCostCenterRequest());
    }

    /**
     * Sets account Name field.
     *
     * @param string|null $value
     */
    public function accountName(?string $value): self
    {
        $this->instance->setAccountName($value);
        return $this;
    }

    /**
     * Sets cost Center field.
     *
     * @param string|null $value
     */
    public function costCenter(?string $value): self
    {
        $this->instance->setCostCenter($value);
        return $this;
    }

    /**
     * Sets custom Fields field.
     *
     * @param CustomFields[]|null $value
     */
    public function customFields(?array $value): self
    {
        $this->instance->setCustomFields($value);
        return $this;
    }

    /**
     * Sets devices field.
     *
     * @param AccountDeviceList[]|null $value
     */
    public function devices(?array $value): self
    {
        $this->instance->setDevices($value);
        return $this;
    }

    /**
     * Sets group Name field.
     *
     * @param string|null $value
     */
    public function groupName(?string $value): self
    {
        $this->instance->setGroupName($value);
        return $this;
    }

    /**
     * Sets primary Place Of Use field.
     *
     * @param array|null $value
     */
    public function primaryPlaceOfUse(?array $value): self
    {
        $this->instance->setPrimaryPlaceOfUse($value);
        return $this;
    }

    /**
     * Sets remove Cost Center field.
     *
     * @param bool|null $value
     */
    public function removeCostCenter(?bool $value): self
    {
        $this->instance->setRemoveCostCenter($value);
        return $this;
    }

    /**
     * Sets service Plan field.
     *
     * @param string|null $value
     */
    public function servicePlan(?string $value): self
    {
        $this->instance->setServicePlan($value);
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
     * Initializes a new Device Cost Center Request object.
     */
    public function build(): DeviceCostCenterRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
