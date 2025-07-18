<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Geolocation;

/**
 * Builder for model Geolocation
 *
 * @see Geolocation
 */
class GeolocationBuilder
{
    /**
     * @var Geolocation
     */
    private $instance;

    private function __construct(Geolocation $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Geolocation Builder object.
     *
     * @param float $latitude
     * @param float $longitude
     */
    public static function init(float $latitude, float $longitude): self
    {
        return new self(new Geolocation($latitude, $longitude));
    }

    /**
     * Initializes a new Geolocation object.
     */
    public function build(): Geolocation
    {
        return CoreHelper::clone($this->instance);
    }
}
