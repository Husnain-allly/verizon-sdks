<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Heading;
use VerizonLib\Models\HeadingItem;

/**
 * Builder for model HeadingItem
 *
 * @see HeadingItem
 */
class HeadingItemBuilder
{
    /**
     * @var HeadingItem
     */
    private $instance;

    private function __construct(HeadingItem $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Heading Item Builder object.
     */
    public static function init(): self
    {
        return new self(new HeadingItem());
    }

    /**
     * Sets heading field.
     *
     * @param Heading|null $value
     */
    public function heading(?Heading $value): self
    {
        $this->instance->setHeading($value);
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
     * Initializes a new Heading Item object.
     */
    public function build(): HeadingItem
    {
        return CoreHelper::clone($this->instance);
    }
}
