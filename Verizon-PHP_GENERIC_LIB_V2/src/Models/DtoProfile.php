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

class DtoProfile implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $kind;

    /**
     * @var string|null
     */
    private $version;

    /**
     * @var string|null
     */
    private $modelid;

    /**
     * @var string|null
     */
    private $name;

    /**
     * @var array|null
     */
    private $configuration;

    /**
     * Returns Kind.
     * profile kind
     */
    public function getKind(): ?string
    {
        return $this->kind;
    }

    /**
     * Sets Kind.
     * profile kind
     *
     * @maps kind
     */
    public function setKind(?string $kind): void
    {
        $this->kind = $kind;
    }

    /**
     * Returns Version.
     * The resource version
     */
    public function getVersion(): ?string
    {
        return $this->version;
    }

    /**
     * Sets Version.
     * The resource version
     *
     * @maps version
     */
    public function setVersion(?string $version): void
    {
        $this->version = $version;
    }

    /**
     * Returns Modelid.
     * device model id
     */
    public function getModelid(): ?string
    {
        return $this->modelid;
    }

    /**
     * Sets Modelid.
     * device model id
     *
     * @maps modelid
     */
    public function setModelid(?string $modelid): void
    {
        $this->modelid = $modelid;
    }

    /**
     * Returns Name.
     * profile name
     */
    public function getName(): ?string
    {
        return $this->name;
    }

    /**
     * Sets Name.
     * profile name
     *
     * @maps name
     */
    public function setName(?string $name): void
    {
        $this->name = $name;
    }

    /**
     * Returns Configuration.
     */
    public function getConfiguration(): ?array
    {
        return $this->configuration;
    }

    /**
     * Sets Configuration.
     *
     * @maps configuration
     */
    public function setConfiguration(?array $configuration): void
    {
        $this->configuration = $configuration;
    }

    /**
     * Converts the DtoProfile object to a human-readable string representation.
     *
     * @return string The string representation of the DtoProfile object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DtoProfile',
            [
                'kind' => $this->kind,
                'version' => $this->version,
                'modelid' => $this->modelid,
                'name' => $this->name,
                'configuration' => $this->configuration,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['kind', 'version', 'modelid', 'name', 'configuration'];

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
        if (isset($this->kind)) {
            $json['kind']          = $this->kind;
        }
        if (isset($this->version)) {
            $json['version']       = $this->version;
        }
        if (isset($this->modelid)) {
            $json['modelid']       = $this->modelid;
        }
        if (isset($this->name)) {
            $json['name']          = $this->name;
        }
        if (isset($this->configuration)) {
            $json['configuration'] = $this->configuration;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
