<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AttributeSetting;
use VerizonLib\Models\Device;
use VerizonLib\Models\DiagnosticObservationSetting;

/**
 * Builder for model DiagnosticObservationSetting
 *
 * @see DiagnosticObservationSetting
 */
class DiagnosticObservationSettingBuilder
{
    /**
     * @var DiagnosticObservationSetting
     */
    private $instance;

    private function __construct(DiagnosticObservationSetting $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Diagnostic Observation Setting Builder object.
     */
    public static function init(): self
    {
        return new self(new DiagnosticObservationSetting());
    }

    /**
     * Sets account Name field.
     *
     * @param string|null $value
     */
    public function accountName(?string $value): self
    {
        $this->instance->setAccountName($value);
        return $this;
    }

    /**
     * Sets device field.
     *
     * @param Device|null $value
     */
    public function device(?Device $value): self
    {
        $this->instance->setDevice($value);
        return $this;
    }

    /**
     * Sets attributes field.
     *
     * @param AttributeSetting[]|null $value
     */
    public function attributes(?array $value): self
    {
        $this->instance->setAttributes($value);
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
     * Initializes a new Diagnostic Observation Setting object.
     */
    public function build(): DiagnosticObservationSetting
    {
        return CoreHelper::clone($this->instance);
    }
}
