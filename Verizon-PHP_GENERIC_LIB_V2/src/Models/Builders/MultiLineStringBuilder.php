<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\MultiLineString;

/**
 * Builder for model MultiLineString
 *
 * @see MultiLineString
 */
class MultiLineStringBuilder
{
    /**
     * @var MultiLineString
     */
    private $instance;

    private function __construct(MultiLineString $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Multi Line String Builder object.
     *
     * @param string $type
     * @param float[][][] $coordinates
     */
    public static function init(string $type, array $coordinates): self
    {
        return new self(new MultiLineString($type, $coordinates));
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
     * Initializes a new Multi Line String object.
     */
    public function build(): MultiLineString
    {
        return CoreHelper::clone($this->instance);
    }
}
