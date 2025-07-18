<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\MecPlatformsAdditionalSupportInfo;
use VerizonLib\Models\MecPlatformsAdditionalSupportInfoData;

/**
 * Builder for model MecPlatformsAdditionalSupportInfo
 *
 * @see MecPlatformsAdditionalSupportInfo
 */
class MecPlatformsAdditionalSupportInfoBuilder
{
    /**
     * @var MecPlatformsAdditionalSupportInfo
     */
    private $instance;

    private function __construct(MecPlatformsAdditionalSupportInfo $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Mec Platforms Additional Support Info Builder object.
     */
    public static function init(): self
    {
        return new self(new MecPlatformsAdditionalSupportInfo());
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
     * Sets data field.
     *
     * @param MecPlatformsAdditionalSupportInfoData|null $value
     */
    public function data(?MecPlatformsAdditionalSupportInfoData $value): self
    {
        $this->instance->setData($value);
        return $this;
    }

    /**
     * Initializes a new Mec Platforms Additional Support Info object.
     */
    public function build(): MecPlatformsAdditionalSupportInfo
    {
        return CoreHelper::clone($this->instance);
    }
}
