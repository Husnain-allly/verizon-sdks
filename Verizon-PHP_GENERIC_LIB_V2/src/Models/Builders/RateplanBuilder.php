<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Rateplan;
use VerizonLib\Models\RatePlanGroup;

/**
 * Builder for model Rateplan
 *
 * @see Rateplan
 */
class RateplanBuilder
{
    /**
     * @var Rateplan
     */
    private $instance;

    private function __construct(Rateplan $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Rateplan Builder object.
     */
    public static function init(): self
    {
        return new self(new Rateplan());
    }

    /**
     * Sets rate Plan Group field.
     *
     * @param RatePlanGroup[]|null $value
     */
    public function ratePlanGroup(?array $value): self
    {
        $this->instance->setRatePlanGroup($value);
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
     * Initializes a new Rateplan object.
     */
    public function build(): Rateplan
    {
        return CoreHelper::clone($this->instance);
    }
}
