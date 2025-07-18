<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountLicenseDeviceListItem;

/**
 * Builder for model AccountLicenseDeviceListItem
 *
 * @see AccountLicenseDeviceListItem
 */
class AccountLicenseDeviceListItemBuilder
{
    /**
     * @var AccountLicenseDeviceListItem
     */
    private $instance;

    private function __construct(AccountLicenseDeviceListItem $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Account License Device List Item Builder object.
     */
    public static function init(): self
    {
        return new self(new AccountLicenseDeviceListItem());
    }

    /**
     * Sets device Id field.
     *
     * @param string|null $value
     */
    public function deviceId(?string $value): self
    {
        $this->instance->setDeviceId($value);
        return $this;
    }

    /**
     * Sets assignment Time field.
     *
     * @param \DateTime|null $value
     */
    public function assignmentTime(?\DateTime $value): self
    {
        $this->instance->setAssignmentTime($value);
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
     * Initializes a new Account License Device List Item object.
     */
    public function build(): AccountLicenseDeviceListItem
    {
        return CoreHelper::clone($this->instance);
    }
}
