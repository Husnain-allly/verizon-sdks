<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\ConnectivityManagementSuccessResult;

/**
 * Builder for model ConnectivityManagementSuccessResult
 *
 * @see ConnectivityManagementSuccessResult
 */
class ConnectivityManagementSuccessResultBuilder
{
    /**
     * @var ConnectivityManagementSuccessResult
     */
    private $instance;

    private function __construct(ConnectivityManagementSuccessResult $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Connectivity Management Success Result Builder object.
     */
    public static function init(): self
    {
        return new self(new ConnectivityManagementSuccessResult());
    }

    /**
     * Sets success field.
     *
     * @param bool|null $value
     */
    public function success(?bool $value): self
    {
        $this->instance->setSuccess($value);
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
     * Initializes a new Connectivity Management Success Result object.
     */
    public function build(): ConnectivityManagementSuccessResult
    {
        return CoreHelper::clone($this->instance);
    }
}
