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
 * Network type.
 */
class NetworkTypeObject implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $networkType;

    /**
     * Returns Network Type.
     */
    public function getNetworkType(): ?string
    {
        return $this->networkType;
    }

    /**
     * Sets Network Type.
     *
     * @maps networkType
     */
    public function setNetworkType(?string $networkType): void
    {
        $this->networkType = $networkType;
    }

    /**
     * Converts the NetworkTypeObject object to a human-readable string representation.
     *
     * @return string The string representation of the NetworkTypeObject object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify('NetworkTypeObject', ['networkType' => $this->networkType]);
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
        if (isset($this->networkType)) {
            $json['networkType'] = $this->networkType;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
