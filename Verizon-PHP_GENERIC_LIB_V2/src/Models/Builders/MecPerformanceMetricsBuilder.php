<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\MecPerformanceMetrics;
use VerizonLib\Models\MecPerformanceQueryResult;

/**
 * Builder for model MecPerformanceMetrics
 *
 * @see MecPerformanceMetrics
 */
class MecPerformanceMetricsBuilder
{
    /**
     * @var MecPerformanceMetrics
     */
    private $instance;

    private function __construct(MecPerformanceMetrics $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Mec Performance Metrics Builder object.
     */
    public static function init(): self
    {
        return new self(new MecPerformanceMetrics());
    }

    /**
     * Sets Query Status field.
     *
     * @param string|null $value
     */
    public function queryStatus(?string $value): self
    {
        $this->instance->setQueryStatus($value);
        return $this;
    }

    /**
     * Sets Start field.
     *
     * @param string|null $value
     */
    public function start(?string $value): self
    {
        $this->instance->setStart($value);
        return $this;
    }

    /**
     * Sets End field.
     *
     * @param string|null $value
     */
    public function end(?string $value): self
    {
        $this->instance->setEnd($value);
        return $this;
    }

    /**
     * Sets Query Result field.
     *
     * @param MecPerformanceQueryResult[]|null $value
     */
    public function queryResult(?array $value): self
    {
        $this->instance->setQueryResult($value);
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
     * Initializes a new Mec Performance Metrics object.
     */
    public function build(): MecPerformanceMetrics
    {
        return CoreHelper::clone($this->instance);
    }
}
