<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\BillUsageRequest;

/**
 * Builder for model BillUsageRequest
 *
 * @see BillUsageRequest
 */
class BillUsageRequestBuilder
{
    /**
     * @var BillUsageRequest
     */
    private $instance;

    private function __construct(BillUsageRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Bill Usage Request Builder object.
     *
     * @param string $accountName
     * @param string $startDate
     * @param string $endDate
     */
    public static function init(string $accountName, string $startDate, string $endDate): self
    {
        return new self(new BillUsageRequest($accountName, $startDate, $endDate));
    }

    /**
     * Sets usage For All Accounts field.
     *
     * @param bool|null $value
     */
    public function usageForAllAccounts(?bool $value): self
    {
        $this->instance->setUsageForAllAccounts($value);
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
     * Initializes a new Bill Usage Request object.
     */
    public function build(): BillUsageRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
