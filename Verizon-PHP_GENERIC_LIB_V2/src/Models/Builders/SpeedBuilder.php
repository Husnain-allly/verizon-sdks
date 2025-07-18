<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Speed;

/**
 * Builder for model Speed
 *
 * @see Speed
 */
class SpeedBuilder
{
    /**
     * @var Speed
     */
    private $instance;

    private function __construct(Speed $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Speed Builder object.
     *
     * @param float $min
     * @param float $max
     */
    public static function init(float $min, float $max): self
    {
        return new self(new Speed($min, $max));
    }

    /**
     * Initializes a new Speed object.
     */
    public function build(): Speed
    {
        return CoreHelper::clone($this->instance);
    }
}
