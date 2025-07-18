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
 * The devices that you want to locate. The array cannot contain more than 20 devices.
 */
class DeviceInfo implements \JsonSerializable
{
    /**
     * @var string
     */
    private $id;

    /**
     * @var string
     */
    private $kind;

    /**
     * @var string
     */
    private $mdn;

    /**
     * @param string $id
     * @param string $kind
     * @param string $mdn
     */
    public function __construct(string $id, string $kind, string $mdn)
    {
        $this->id = $id;
        $this->kind = $kind;
        $this->mdn = $mdn;
    }

    /**
     * Returns Id.
     * Device identifier.
     */
    public function getId(): string
    {
        return $this->id;
    }

    /**
     * Sets Id.
     * Device identifier.
     *
     * @required
     * @maps id
     */
    public function setId(string $id): void
    {
        $this->id = $id;
    }

    /**
     * Returns Kind.
     * Device identifier kind.
     */
    public function getKind(): string
    {
        return $this->kind;
    }

    /**
     * Sets Kind.
     * Device identifier kind.
     *
     * @required
     * @maps kind
     */
    public function setKind(string $kind): void
    {
        $this->kind = $kind;
    }

    /**
     * Returns Mdn.
     * Device MDN.
     */
    public function getMdn(): string
    {
        return $this->mdn;
    }

    /**
     * Sets Mdn.
     * Device MDN.
     *
     * @required
     * @maps mdn
     */
    public function setMdn(string $mdn): void
    {
        $this->mdn = $mdn;
    }

    /**
     * Converts the DeviceInfo object to a human-readable string representation.
     *
     * @return string The string representation of the DeviceInfo object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DeviceInfo',
            [
                'id' => $this->id,
                'kind' => $this->kind,
                'mdn' => $this->mdn,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['id', 'kind', 'mdn'];

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
        $json['id']   = $this->id;
        $json['kind'] = $this->kind;
        $json['mdn']  = $this->mdn;
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
