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
 * List of fields affected by the event.
 */
class Fields implements \JsonSerializable
{
    /**
     * @var Configuration|null
     */
    private $configuration;

    /**
     * Returns Configuration.
     * List of the field names and values to set.
     */
    public function getConfiguration(): ?Configuration
    {
        return $this->configuration;
    }

    /**
     * Sets Configuration.
     * List of the field names and values to set.
     *
     * @maps configuration
     */
    public function setConfiguration(?Configuration $configuration): void
    {
        $this->configuration = $configuration;
    }

    /**
     * Converts the Fields object to a human-readable string representation.
     *
     * @return string The string representation of the Fields object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'Fields',
            ['configuration' => $this->configuration, 'additionalProperties' => $this->additionalProperties]
        );
    }

    protected $propertyNames = ['configuration'];

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
        if (isset($this->configuration)) {
            $json['configuration'] = $this->configuration;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
