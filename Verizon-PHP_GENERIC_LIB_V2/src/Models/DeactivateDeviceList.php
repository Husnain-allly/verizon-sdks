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

class DeactivateDeviceList implements \JsonSerializable
{
    /**
     * @var Id[]|null
     */
    private $ids;

    /**
     * Returns Ids.
     *
     * @return Id[]|null
     */
    public function getIds(): ?array
    {
        return $this->ids;
    }

    /**
     * Sets Ids.
     *
     * @maps ids
     *
     * @param Id[]|null $ids
     */
    public function setIds(?array $ids): void
    {
        $this->ids = $ids;
    }

    /**
     * Converts the DeactivateDeviceList object to a human-readable string representation.
     *
     * @return string The string representation of the DeactivateDeviceList object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify('DeactivateDeviceList', ['ids' => $this->ids]);
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
        if (isset($this->ids)) {
            $json['ids'] = $this->ids;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
