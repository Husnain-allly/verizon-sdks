<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\GroupName;

/**
 * Builder for model GroupName
 *
 * @see GroupName
 */
class GroupNameBuilder
{
    /**
     * @var GroupName
     */
    private $instance;

    private function __construct(GroupName $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Group Name Builder object.
     */
    public static function init(): self
    {
        return new self(new GroupName());
    }

    /**
     * Sets Default field.
     *
     * @param string|null $value
     */
    public function default(?string $value): self
    {
        $this->instance->setDefault($value);
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
     * Initializes a new Group Name object.
     */
    public function build(): GroupName
    {
        return CoreHelper::clone($this->instance);
    }
}
