<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\UpdateServiceEndpointResult;

/**
 * Builder for model UpdateServiceEndpointResult
 *
 * @see UpdateServiceEndpointResult
 */
class UpdateServiceEndpointResultBuilder
{
    /**
     * @var UpdateServiceEndpointResult
     */
    private $instance;

    private function __construct(UpdateServiceEndpointResult $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Update Service Endpoint Result Builder object.
     */
    public static function init(): self
    {
        return new self(new UpdateServiceEndpointResult());
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
     * Sets message field.
     *
     * @param string|null $value
     */
    public function message(?string $value): self
    {
        $this->instance->setMessage($value);
        return $this;
    }

    /**
     * Initializes a new Update Service Endpoint Result object.
     */
    public function build(): UpdateServiceEndpointResult
    {
        return CoreHelper::clone($this->instance);
    }
}
