<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\V2ListOfLicensesToRemoveRequest;

/**
 * Builder for model V2ListOfLicensesToRemoveRequest
 *
 * @see V2ListOfLicensesToRemoveRequest
 */
class V2ListOfLicensesToRemoveRequestBuilder
{
    /**
     * @var V2ListOfLicensesToRemoveRequest
     */
    private $instance;

    private function __construct(V2ListOfLicensesToRemoveRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new V2 List Of Licenses To Remove Request Builder object.
     *
     * @param string[] $deviceList
     */
    public static function init(array $deviceList): self
    {
        return new self(new V2ListOfLicensesToRemoveRequest($deviceList));
    }

    /**
     * Sets type field.
     *
     * @param string|null $value
     */
    public function type(?string $value): self
    {
        $this->instance->setType($value);
        return $this;
    }

    /**
     * Sets count field.
     *
     * @param int|null $value
     */
    public function count(?int $value): self
    {
        $this->instance->setCount($value);
        return $this;
    }

    /**
     * Add an additional property to this model.
     *
     * @param string $name Name of property.
     * @param mixed $value Value of property.
     */
    public function additionalProperty(string $name, $value): self
    {
        $this->instance->addAdditionalProperty($name, $value);
        return $this;
    }

    /**
     * Initializes a new V2 List Of Licenses To Remove Request object.
     */
    public function build(): V2ListOfLicensesToRemoveRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
