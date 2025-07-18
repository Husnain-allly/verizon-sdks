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

class Accountnames implements \JsonSerializable
{
    /**
     * @var string[]|null
     */
    private $accountNameList;

    /**
     * Returns Account Name List.
     *
     * @return string[]|null
     */
    public function getAccountNameList(): ?array
    {
        return $this->accountNameList;
    }

    /**
     * Sets Account Name List.
     *
     * @maps accountNameList
     *
     * @param string[]|null $accountNameList
     */
    public function setAccountNameList(?array $accountNameList): void
    {
        $this->accountNameList = $accountNameList;
    }

    /**
     * Converts the Accountnames object to a human-readable string representation.
     *
     * @return string The string representation of the Accountnames object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'Accountnames',
            ['accountNameList' => $this->accountNameList, 'additionalProperties' => $this->additionalProperties]
        );
    }

    protected $propertyNames = ['accountNameList'];

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
        if (isset($this->accountNameList)) {
            $json['accountNameList'] = $this->accountNameList;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
