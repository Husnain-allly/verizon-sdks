<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\ConnectionRequest;
use VerizonLib\Models\Geolocation;

/**
 * Builder for model ConnectionRequest
 *
 * @see ConnectionRequest
 */
class ConnectionRequestBuilder
{
    /**
     * @var ConnectionRequest
     */
    private $instance;

    private function __construct(ConnectionRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Connection Request Builder object.
     *
     * @param string $deviceId
     * @param Geolocation $geolocation
     * @param string $networkType
     */
    public static function init(string $deviceId, Geolocation $geolocation, string $networkType): self
    {
        return new self(new ConnectionRequest($deviceId, $geolocation, $networkType));
    }

    /**
     * Initializes a new Connection Request object.
     */
    public function build(): ConnectionRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
