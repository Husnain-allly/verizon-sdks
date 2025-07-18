<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\FotaV3CallbackSummary;

/**
 * Builder for model FotaV3CallbackSummary
 *
 * @see FotaV3CallbackSummary
 */
class FotaV3CallbackSummaryBuilder
{
    /**
     * @var FotaV3CallbackSummary
     */
    private $instance;

    private function __construct(FotaV3CallbackSummary $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Fota V3 Callback Summary Builder object.
     */
    public static function init(): self
    {
        return new self(new FotaV3CallbackSummary());
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
     * Initializes a new Fota V3 Callback Summary object.
     */
    public function build(): FotaV3CallbackSummary
    {
        return CoreHelper::clone($this->instance);
    }
}
