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
 * The ConfigurationList's item that contains the configuration identifier, name, description and the
 * active flag.
 */
class ConfigurationListItem implements \JsonSerializable
{
    /**
     * @var string
     */
    private $id;

    /**
     * @var string|null
     */
    private $name;

    /**
     * @var string|null
     */
    private $description;

    /**
     * @var bool
     */
    private $isActive;

    /**
     * @param string $id
     * @param bool $isActive
     */
    public function __construct(string $id, bool $isActive)
    {
        $this->id = $id;
        $this->isActive = $isActive;
    }

    /**
     * Returns Id.
     * The generated ID (UUID v4) for the configuration. It has to be used when asking for changing any of
     * the configuration parameters.
     */
    public function getId(): string
    {
        return $this->id;
    }

    /**
     * Sets Id.
     * The generated ID (UUID v4) for the configuration. It has to be used when asking for changing any of
     * the configuration parameters.
     *
     * @required
     * @maps id
     */
    public function setId(string $id): void
    {
        $this->id = $id;
    }

    /**
     * Returns Name.
     * Name of the configuration.
     */
    public function getName(): ?string
    {
        return $this->name;
    }

    /**
     * Sets Name.
     * Name of the configuration.
     *
     * @maps name
     */
    public function setName(?string $name): void
    {
        $this->name = $name;
    }

    /**
     * Returns Description.
     * Description of the configuration.
     */
    public function getDescription(): ?string
    {
        return $this->description;
    }

    /**
     * Sets Description.
     * Description of the configuration.
     *
     * @maps description
     */
    public function setDescription(?string $description): void
    {
        $this->description = $description;
    }

    /**
     * Returns Is Active.
     */
    public function getIsActive(): bool
    {
        return $this->isActive;
    }

    /**
     * Sets Is Active.
     *
     * @required
     * @maps isActive
     */
    public function setIsActive(bool $isActive): void
    {
        $this->isActive = $isActive;
    }

    /**
     * Converts the ConfigurationListItem object to a human-readable string representation.
     *
     * @return string The string representation of the ConfigurationListItem object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'ConfigurationListItem',
            [
                'id' => $this->id,
                'name' => $this->name,
                'description' => $this->description,
                'isActive' => $this->isActive
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
        $json['id']              = $this->id;
        if (isset($this->name)) {
            $json['name']        = $this->name;
        }
        if (isset($this->description)) {
            $json['description'] = $this->description;
        }
        $json['isActive']        = $this->isActive;

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
