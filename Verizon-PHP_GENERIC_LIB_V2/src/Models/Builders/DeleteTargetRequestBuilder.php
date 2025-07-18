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
use VerizonLib\Models\DeleteTargetRequest;
use VerizonLib\Models\ResourceIdentifier;

/**
 * Builder for model DeleteTargetRequest
 *
 * @see DeleteTargetRequest
 */
class DeleteTargetRequestBuilder
{
    /**
     * @var DeleteTargetRequest
     */
    private $instance;

    private function __construct(DeleteTargetRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Delete Target Request Builder object.
     */
    public static function init(): self
    {
        return new self(new DeleteTargetRequest());
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
     * Initializes a new Delete Target Request object.
     */
    public function build(): DeleteTargetRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
