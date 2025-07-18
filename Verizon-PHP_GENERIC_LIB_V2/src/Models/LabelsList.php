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

class LabelsList implements \JsonSerializable
{
    /**
     * @var DeviceLabels[]|null
     */
    private $deviceIds;

    /**
     * Returns Device Ids.
     *
     * @return DeviceLabels[]|null
     */
    public function getDeviceIds(): ?array
    {
        return $this->deviceIds;
    }

    /**
     * Sets Device Ids.
     *
     * @maps deviceIds
     *
     * @param DeviceLabels[]|null $deviceIds
     */
    public function setDeviceIds(?array $deviceIds): void
    {
        $this->deviceIds = $deviceIds;
    }

    /**
     * Converts the LabelsList object to a human-readable string representation.
     *
     * @return string The string representation of the LabelsList object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify('LabelsList', ['deviceIds' => $this->deviceIds]);
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
        if (isset($this->deviceIds)) {
            $json['deviceIds'] = $this->deviceIds;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
