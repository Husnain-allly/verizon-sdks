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
 * Registered callback account name and service name.
 */
class FotaV1CallbackRegistrationResult implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $accountName;

    /**
     * @var string|null
     */
    private $serviceName;

    /**
     * Returns Account Name.
     * The name of the billing account for which callback messages will be sent.
     */
    public function getAccountName(): ?string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * The name of the billing account for which callback messages will be sent.
     *
     * @maps accountName
     */
    public function setAccountName(?string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Service Name.
     * The name of the callback service, which identifies the type and format of messages that will be sent
     * to the registered URL. This will be 'Fota' for the Software Management Services callback.
     */
    public function getServiceName(): ?string
    {
        return $this->serviceName;
    }

    /**
     * Sets Service Name.
     * The name of the callback service, which identifies the type and format of messages that will be sent
     * to the registered URL. This will be 'Fota' for the Software Management Services callback.
     *
     * @maps serviceName
     */
    public function setServiceName(?string $serviceName): void
    {
        $this->serviceName = $serviceName;
    }

    /**
     * Converts the FotaV1CallbackRegistrationResult object to a human-readable string representation.
     *
     * @return string The string representation of the FotaV1CallbackRegistrationResult object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'FotaV1CallbackRegistrationResult',
            [
                'accountName' => $this->accountName,
                'serviceName' => $this->serviceName,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['accountName', 'serviceName'];

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
            $json['accountName'] = $this->accountName;
        }
        if (isset($this->serviceName)) {
            $json['serviceName'] = $this->serviceName;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
