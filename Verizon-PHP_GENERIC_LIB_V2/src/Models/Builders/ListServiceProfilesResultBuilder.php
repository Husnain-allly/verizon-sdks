<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\ListServiceProfilesResult;

/**
 * Builder for model ListServiceProfilesResult
 *
 * @see ListServiceProfilesResult
 */
class ListServiceProfilesResultBuilder
{
    /**
     * @var ListServiceProfilesResult
     */
    private $instance;

    private function __construct(ListServiceProfilesResult $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new List Service Profiles Result Builder object.
     */
    public static function init(): self
    {
        return new self(new ListServiceProfilesResult());
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
     * Sets data field.
     *
     * @param string[]|null $value
     */
    public function data(?array $value): self
    {
        $this->instance->setData($value);
        return $this;
    }

    /**
     * Initializes a new List Service Profiles Result object.
     */
    public function build(): ListServiceProfilesResult
    {
        return CoreHelper::clone($this->instance);
    }
}
