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

class Locations1 implements \JsonSerializable
{
    /**
     * @var Coordinates[]|null
     */
    private $coordinatesList;

    /**
     * @var AddressItem[]|null
     */
    private $addressList;

    /**
     * Returns Coordinates List.
     *
     * @return Coordinates[]|null
     */
    public function getCoordinatesList(): ?array
    {
        return $this->coordinatesList;
    }

    /**
     * Sets Coordinates List.
     *
     * @maps coordinatesList
     *
     * @param Coordinates[]|null $coordinatesList
     */
    public function setCoordinatesList(?array $coordinatesList): void
    {
        $this->coordinatesList = $coordinatesList;
    }

    /**
     * Returns Address List.
     *
     * @return AddressItem[]|null
     */
    public function getAddressList(): ?array
    {
        return $this->addressList;
    }

    /**
     * Sets Address List.
     *
     * @maps addressList
     *
     * @param AddressItem[]|null $addressList
     */
    public function setAddressList(?array $addressList): void
    {
        $this->addressList = $addressList;
    }

    /**
     * Converts the Locations1 object to a human-readable string representation.
     *
     * @return string The string representation of the Locations1 object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'Locations1',
            [
                'coordinatesList' => $this->coordinatesList,
                'addressList' => $this->addressList,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['coordinatesList', 'addressList'];

    private $additionalProperties = [];

    /**
     * Add an additional property to this model.
     *
     * @param string $name Name of property.
     * @param mixed $value Value of property.
     */
    public function addAdditionalProperty(string $name, $value)
    {
        if (in_array($name, $this->propertyNames, true)) {
            throw new \InvalidArgumentException(
                "The additional property key, '$name' conflicts with one of the model's properties"
            );
        }

        $this->additionalProperties[$name] = $value;
    }

    /**
     * Find an additional property by name in this model or false if property does not exist.
     *
     * @param string $name Name of property.
     *
     * @return mixed|false Value of the property.
     */
    public function findAdditionalProperty(string $name)
    {
        if (isset($this->additionalProperties[$name])) {
            return $this->additionalProperties[$name];
        }
        return false;
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
        if (isset($this->coordinatesList)) {
            $json['coordinatesList'] = $this->coordinatesList;
        }
        if (isset($this->addressList)) {
            $json['addressList']     = $this->addressList;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
