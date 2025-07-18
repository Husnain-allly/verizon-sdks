<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AsynchronousRequestResult;

/**
 * Builder for model AsynchronousRequestResult
 *
 * @see AsynchronousRequestResult
 */
class AsynchronousRequestResultBuilder
{
    /**
     * @var AsynchronousRequestResult
     */
    private $instance;

    private function __construct(AsynchronousRequestResult $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Asynchronous Request Result Builder object.
     */
    public static function init(): self
    {
        return new self(new AsynchronousRequestResult());
    }

    /**
     * Sets request Id field.
     *
     * @param string|null $value
     */
    public function requestId(?string $value): self
    {
        $this->instance->setRequestId($value);
        return $this;
    }

    /**
     * Sets status field.
     *
     * @param string|null $value
     */
    public function status(?string $value): self
    {
        $this->instance->setStatus($value);
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
     * Initializes a new Asynchronous Request Result object.
     */
    public function build(): AsynchronousRequestResult
    {
        return CoreHelper::clone($this->instance);
    }
}
