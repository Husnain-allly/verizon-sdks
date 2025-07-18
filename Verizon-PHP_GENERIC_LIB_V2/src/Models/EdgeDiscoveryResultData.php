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
 * For cases where user input exceeds the boundary values an additional 'data' key will be returned
 * with a relevant description.
 */
class EdgeDiscoveryResultData implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $additionalMessage;

    /**
     * Returns Additional Message.
     */
    public function getAdditionalMessage(): ?string
    {
        return $this->additionalMessage;
    }

    /**
     * Sets Additional Message.
     *
     * @maps additionalMessage
     */
    public function setAdditionalMessage(?string $additionalMessage): void
    {
        $this->additionalMessage = $additionalMessage;
    }

    /**
     * Converts the EdgeDiscoveryResultData object to a human-readable string representation.
     *
     * @return string The string representation of the EdgeDiscoveryResultData object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'EdgeDiscoveryResultData',
            [
                'additionalMessage' => $this->additionalMessage,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['additionalMessage'];

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
        if (isset($this->additionalMessage)) {
            $json['additionalMessage'] = $this->additionalMessage;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
