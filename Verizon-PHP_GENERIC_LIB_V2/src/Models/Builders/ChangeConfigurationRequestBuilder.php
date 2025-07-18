<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountIdentifier;
use VerizonLib\Models\ChangeConfigurationRequest;
use VerizonLib\Models\Configuration;
use VerizonLib\Models\ResourceIdentifier;

/**
 * Builder for model ChangeConfigurationRequest
 *
 * @see ChangeConfigurationRequest
 */
class ChangeConfigurationRequestBuilder
{
    /**
     * @var ChangeConfigurationRequest
     */
    private $instance;

    private function __construct(ChangeConfigurationRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Change Configuration Request Builder object.
     */
    public static function init(): self
    {
        return new self(new ChangeConfigurationRequest());
    }

    /**
     * Sets accountidentifier field.
     *
     * @param AccountIdentifier|null $value
     */
    public function accountidentifier(?AccountIdentifier $value): self
    {
        $this->instance->setAccountidentifier($value);
        return $this;
    }

    /**
     * Sets resourceidentifier field.
     *
     * @param ResourceIdentifier|null $value
     */
    public function resourceidentifier(?ResourceIdentifier $value): self
    {
        $this->instance->setResourceidentifier($value);
        return $this;
    }

    /**
     * Sets configuration field.
     *
     * @param Configuration|null $value
     */
    public function configuration(?Configuration $value): self
    {
        $this->instance->setConfiguration($value);
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
     * Initializes a new Change Configuration Request object.
     */
    public function build(): ChangeConfigurationRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
