<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\TriggerValueResponse;
use VerizonLib\Models\Triggervalues;

/**
 * Builder for model TriggerValueResponse
 *
 * @see TriggerValueResponse
 */
class TriggerValueResponseBuilder
{
    /**
     * @var TriggerValueResponse
     */
    private $instance;

    private function __construct(TriggerValueResponse $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Trigger Value Response Builder object.
     */
    public static function init(): self
    {
        return new self(new TriggerValueResponse());
    }

    /**
     * Sets triggers field.
     *
     * @param Triggervalues[]|null $value
     */
    public function triggers(?array $value): self
    {
        $this->instance->setTriggers($value);
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
     * Initializes a new Trigger Value Response object.
     */
    public function build(): TriggerValueResponse
    {
        return CoreHelper::clone($this->instance);
    }
}
