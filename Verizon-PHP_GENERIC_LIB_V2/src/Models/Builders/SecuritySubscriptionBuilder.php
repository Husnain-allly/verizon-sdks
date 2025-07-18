<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\ExtendedAttributes;
use VerizonLib\Models\SecuritySubscription;

/**
 * Builder for model SecuritySubscription
 *
 * @see SecuritySubscription
 */
class SecuritySubscriptionBuilder
{
    /**
     * @var SecuritySubscription
     */
    private $instance;

    private function __construct(SecuritySubscription $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Security Subscription Builder object.
     */
    public static function init(): self
    {
        return new self(new SecuritySubscription());
    }

    /**
     * Sets extended Attributes field.
     *
     * @param ExtendedAttributes[]|null $value
     */
    public function extendedAttributes(?array $value): self
    {
        $this->instance->setExtendedAttributes($value);
        return $this;
    }

    /**
     * Sets license Assigned field.
     *
     * @param int|null $value
     */
    public function licenseAssigned(?int $value): self
    {
        $this->instance->setLicenseAssigned($value);
        return $this;
    }

    /**
     * Sets license Available field.
     *
     * @param int|null $value
     */
    public function licenseAvailable(?int $value): self
    {
        $this->instance->setLicenseAvailable($value);
        return $this;
    }

    /**
     * Sets license Purchased field.
     *
     * @param int|null $value
     */
    public function licensePurchased(?int $value): self
    {
        $this->instance->setLicensePurchased($value);
        return $this;
    }

    /**
     * Sets license Type field.
     *
     * @param string|null $value
     */
    public function licenseType(?string $value): self
    {
        $this->instance->setLicenseType($value);
        return $this;
    }

    /**
     * Sets sku Number field.
     *
     * @param string|null $value
     */
    public function skuNumber(?string $value): self
    {
        $this->instance->setSkuNumber($value);
        return $this;
    }

    /**
     * Initializes a new Security Subscription object.
     */
    public function build(): SecuritySubscription
    {
        return CoreHelper::clone($this->instance);
    }
}
