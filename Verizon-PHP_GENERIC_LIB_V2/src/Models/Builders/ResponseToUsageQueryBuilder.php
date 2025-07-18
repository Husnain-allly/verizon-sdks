<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\ReadySimDeviceId;
use VerizonLib\Models\ResponseToUsageQuery;
use VerizonLib\Models\UsageHistory;

/**
 * Builder for model ResponseToUsageQuery
 *
 * @see ResponseToUsageQuery
 */
class ResponseToUsageQueryBuilder
{
    /**
     * @var ResponseToUsageQuery
     */
    private $instance;

    private function __construct(ResponseToUsageQuery $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Response To Usage Query Builder object.
     */
    public static function init(): self
    {
        return new self(new ResponseToUsageQuery());
    }

    /**
     * Sets hasmoredata field.
     *
     * @param bool|null $value
     */
    public function hasmoredata(?bool $value): self
    {
        $this->instance->setHasmoredata($value);
        return $this;
    }

    /**
     * Sets device Id field.
     *
     * @param ReadySimDeviceId|null $value
     */
    public function deviceId(?ReadySimDeviceId $value): self
    {
        $this->instance->setDeviceId($value);
        return $this;
    }

    /**
     * Sets usage History field.
     *
     * @param UsageHistory[]|null $value
     */
    public function usageHistory(?array $value): self
    {
        $this->instance->setUsageHistory($value);
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
     * Initializes a new Response To Usage Query object.
     */
    public function build(): ResponseToUsageQuery
    {
        return CoreHelper::clone($this->instance);
    }
}
