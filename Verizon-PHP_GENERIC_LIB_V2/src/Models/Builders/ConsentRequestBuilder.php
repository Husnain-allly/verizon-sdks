<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\ConsentRequest;

/**
 * Builder for model ConsentRequest
 *
 * @see ConsentRequest
 */
class ConsentRequestBuilder
{
    /**
     * @var ConsentRequest
     */
    private $instance;

    private function __construct(ConsentRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Consent Request Builder object.
     *
     * @param string $accountName
     */
    public static function init(string $accountName): self
    {
        return new self(new ConsentRequest($accountName));
    }

    /**
     * Sets all Device field.
     *
     * @param bool|null $value
     */
    public function allDevice(?bool $value): self
    {
        $this->instance->setAllDevice($value);
        return $this;
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
     * Sets exclusion field.
     *
     * @param string[]|null $value
     */
    public function exclusion(?array $value): self
    {
        $this->instance->setExclusion($value);
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
     * Initializes a new Consent Request object.
     */
    public function build(): ConsentRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
