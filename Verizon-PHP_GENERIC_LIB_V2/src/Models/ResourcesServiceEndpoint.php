<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models;

use stdClass;
use VerizonLib\ApiHelper;

/**
 * Service Endpoint path, address, and port.
 */
class ResourcesServiceEndpoint implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $uri;

    /**
     * @var string|null
     */
    private $fqdn;

    /**
     * @var string|null
     */
    private $iPv4Address;

    /**
     * @var string|null
     */
    private $iPv6Address;

    /**
     * @var int|null
     */
    private $port;

    /**
     * Returns Uri.
     * URI of Service Endpoint if available.
     */
    public function getUri(): ?string
    {
        return $this->uri;
    }

    /**
     * Sets Uri.
     * URI of Service Endpoint if available.
     *
     * @maps URI
     */
    public function setUri(?string $uri): void
    {
        $this->uri = $uri;
    }

    /**
     * Returns Fqdn.
     * FQDN of Service Endpoint if available.
     */
    public function getFqdn(): ?string
    {
        return $this->fqdn;
    }

    /**
     * Sets Fqdn.
     * FQDN of Service Endpoint if available.
     *
     * @maps FQDN
     */
    public function setFqdn(?string $fqdn): void
    {
        $this->fqdn = $fqdn;
    }

    /**
     * Returns I Pv 4 Address.
     * IPv4 Address of Service Endpoint if available.
     */
    public function getIPv4Address(): ?string
    {
        return $this->iPv4Address;
    }

    /**
     * Sets I Pv 4 Address.
     * IPv4 Address of Service Endpoint if available.
     *
     * @maps IPv4Address
     */
    public function setIPv4Address(?string $iPv4Address): void
    {
        $this->iPv4Address = $iPv4Address;
    }

    /**
     * Returns I Pv 6 Address.
     * IPv6 Address of Service Endpoint if available.
     */
    public function getIPv6Address(): ?string
    {
        return $this->iPv6Address;
    }

    /**
     * Sets I Pv 6 Address.
     * IPv6 Address of Service Endpoint if available.
     *
     * @maps IPv6Address
     */
    public function setIPv6Address(?string $iPv6Address): void
    {
        $this->iPv6Address = $iPv6Address;
    }

    /**
     * Returns Port.
     * Port information of Service Endpoint if IPv4 or IPv6 is mentioned.
     */
    public function getPort(): ?int
    {
        return $this->port;
    }

    /**
     * Sets Port.
     * Port information of Service Endpoint if IPv4 or IPv6 is mentioned.
     *
     * @maps port
     */
    public function setPort(?int $port): void
    {
        $this->port = $port;
    }

    /**
     * Converts the ResourcesServiceEndpoint object to a human-readable string representation.
     *
     * @return string The string representation of the ResourcesServiceEndpoint object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'ResourcesServiceEndpoint',
            [
                'uri' => $this->uri,
                'fqdn' => $this->fqdn,
                'iPv4Address' => $this->iPv4Address,
                'iPv6Address' => $this->iPv6Address,
                'port' => $this->port
            ]
        );
    }

    /**
     * Encode this object to JSON
     *
     * @param bool $asArrayWhenEmpty Whether to serialize this model as an array whenever no fields
     *        are set. (default: false)
     *
     * @return array|stdClass
     */
    #[\ReturnTypeWillChange] // @phan-suppress-current-line PhanUndeclaredClassAttribute for (php < 8.1)
    public function jsonSerialize(bool $asArrayWhenEmpty = false)
    {
        $json = [];
        if (isset($this->uri)) {
            $json['URI']         = $this->uri;
        }
        if (isset($this->fqdn)) {
            $json['FQDN']        = $this->fqdn;
        }
        if (isset($this->iPv4Address)) {
            $json['IPv4Address'] = $this->iPv4Address;
        }
        if (isset($this->iPv6Address)) {
            $json['IPv6Address'] = $this->iPv6Address;
        }
        if (isset($this->port)) {
            $json['port']        = $this->port;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
