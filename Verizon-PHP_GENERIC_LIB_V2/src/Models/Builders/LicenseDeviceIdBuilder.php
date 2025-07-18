<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\LicenseDeviceId;

/**
 * Builder for model LicenseDeviceId
 *
 * @see LicenseDeviceId
 */
class LicenseDeviceIdBuilder
{
    /**
     * @var LicenseDeviceId
     */
    private $instance;

    private function __construct(LicenseDeviceId $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new License Device Id Builder object.
     */
    public static function init(): self
    {
        return new self(new LicenseDeviceId());
    }

    /**
     * Sets id field.
     *
     * @param string|null $value
     */
    public function id(?string $value): self
    {
        $this->instance->setId($value);
        return $this;
    }

    /**
     * Sets kind field.
     *
     * @param string|null $value
     */
    public function kind(?string $value): self
    {
        $this->instance->setKind($value);
        return $this;
    }

    /**
     * Initializes a new License Device Id object.
     */
    public function build(): LicenseDeviceId
    {
        return CoreHelper::clone($this->instance);
    }
}
