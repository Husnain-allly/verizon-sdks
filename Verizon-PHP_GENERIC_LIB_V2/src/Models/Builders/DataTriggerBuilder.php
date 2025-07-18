<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountLevelObject;
use VerizonLib\Models\DataTrigger;

/**
 * Builder for model DataTrigger
 *
 * @see DataTrigger
 */
class DataTriggerBuilder
{
    /**
     * @var DataTrigger
     */
    private $instance;

    private function __construct(DataTrigger $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Data Trigger Builder object.
     */
    public static function init(): self
    {
        return new self(new DataTrigger());
    }

    /**
     * Sets account Level field.
     *
     * @param AccountLevelObject|null $value
     */
    public function accountLevel(?AccountLevelObject $value): self
    {
        $this->instance->setAccountLevel($value);
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
     * Initializes a new Data Trigger object.
     */
    public function build(): DataTrigger
    {
        return CoreHelper::clone($this->instance);
    }
}
