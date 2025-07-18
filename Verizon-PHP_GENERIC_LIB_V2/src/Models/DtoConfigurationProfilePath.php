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

class DtoConfigurationProfilePath implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $accountName;

    /**
     * @var DtoResourceidentifier|null
     */
    private $resourceidentifier;

    /**
     * @var DtoProfile|null
     */
    private $profile;

    /**
     * Returns Account Name.
     * The numeric account name, which must include leading zeros
     */
    public function getAccountName(): ?string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * The numeric account name, which must include leading zeros
     *
     * @maps accountName
     */
    public function setAccountName(?string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Resourceidentifier.
     */
    public function getResourceidentifier(): ?DtoResourceidentifier
    {
        return $this->resourceidentifier;
    }

    /**
     * Sets Resourceidentifier.
     *
     * @maps resourceidentifier
     */
    public function setResourceidentifier(?DtoResourceidentifier $resourceidentifier): void
    {
        $this->resourceidentifier = $resourceidentifier;
    }

    /**
     * Returns Profile.
     */
    public function getProfile(): ?DtoProfile
    {
        return $this->profile;
    }

    /**
     * Sets Profile.
     *
     * @maps profile
     */
    public function setProfile(?DtoProfile $profile): void
    {
        $this->profile = $profile;
    }

    /**
     * Converts the DtoConfigurationProfilePath object to a human-readable string representation.
     *
     * @return string The string representation of the DtoConfigurationProfilePath object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DtoConfigurationProfilePath',
            [
                'accountName' => $this->accountName,
                'resourceidentifier' => $this->resourceidentifier,
                'profile' => $this->profile,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['accountName', 'resourceidentifier', 'profile'];

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
        if (isset($this->accountName)) {
            $json['accountName']        = $this->accountName;
        }
        if (isset($this->resourceidentifier)) {
            $json['resourceidentifier'] = $this->resourceidentifier;
        }
        if (isset($this->profile)) {
            $json['profile']            = $this->profile;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
