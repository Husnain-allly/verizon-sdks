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

class CallbackRegistrationResult implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $account;

    /**
     * @var string|null
     */
    private $name;

    /**
     * Returns Account.
     * The name of the account that registered the callback URL.
     */
    public function getAccount(): ?string
    {
        return $this->account;
    }

    /**
     * Sets Account.
     * The name of the account that registered the callback URL.
     *
     * @maps account
     */
    public function setAccount(?string $account): void
    {
        $this->account = $account;
    }

    /**
     * Returns Name.
     * The name of the callback service.
     */
    public function getName(): ?string
    {
        return $this->name;
    }

    /**
     * Sets Name.
     * The name of the callback service.
     *
     * @maps name
     * @factory \VerizonLib\Models\CallbackServiceName::checkValue
     */
    public function setName(?string $name): void
    {
        $this->name = $name;
    }

    /**
     * Converts the CallbackRegistrationResult object to a human-readable string representation.
     *
     * @return string The string representation of the CallbackRegistrationResult object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'CallbackRegistrationResult',
            [
                'account' => $this->account,
                'name' => $this->name,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['account', 'name'];

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
        if (isset($this->account)) {
            $json['account'] = $this->account;
        }
        if (isset($this->name)) {
            $json['name']    = CallbackServiceName::checkValue($this->name);
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
