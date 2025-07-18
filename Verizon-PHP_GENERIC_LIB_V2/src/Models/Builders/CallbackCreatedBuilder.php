<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\CallbackCreated;

/**
 * Builder for model CallbackCreated
 *
 * @see CallbackCreated
 */
class CallbackCreatedBuilder
{
    /**
     * @var CallbackCreated
     */
    private $instance;

    private function __construct(CallbackCreated $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Callback Created Builder object.
     *
     * @param string $aname
     * @param string $name
     */
    public static function init(string $aname, string $name): self
    {
        return new self(new CallbackCreated($aname, $name));
    }

    /**
     * Sets url field.
     *
     * @param string|null $value
     */
    public function url(?string $value): self
    {
        $this->instance->setUrl($value);
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
     * Initializes a new Callback Created object.
     */
    public function build(): CallbackCreated
    {
        return CoreHelper::clone($this->instance);
    }
}
