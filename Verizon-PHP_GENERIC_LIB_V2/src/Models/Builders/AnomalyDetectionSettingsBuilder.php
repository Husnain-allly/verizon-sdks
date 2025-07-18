<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AnomalyDetectionSettings;
use VerizonLib\Models\SensitivityParameters;

/**
 * Builder for model AnomalyDetectionSettings
 *
 * @see AnomalyDetectionSettings
 */
class AnomalyDetectionSettingsBuilder
{
    /**
     * @var AnomalyDetectionSettings
     */
    private $instance;

    private function __construct(AnomalyDetectionSettings $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Anomaly Detection Settings Builder object.
     */
    public static function init(): self
    {
        return new self(new AnomalyDetectionSettings());
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
     * Sets sensitivity Parameter field.
     *
     * @param SensitivityParameters|null $value
     */
    public function sensitivityParameter(?SensitivityParameters $value): self
    {
        $this->instance->setSensitivityParameter($value);
        return $this;
    }

    /**
     * Sets status field.
     *
     * @param string|null $value
     */
    public function status(?string $value): self
    {
        $this->instance->setStatus($value);
        return $this;
    }

    /**
     * Initializes a new Anomaly Detection Settings object.
     */
    public function build(): AnomalyDetectionSettings
    {
        return CoreHelper::clone($this->instance);
    }
}
