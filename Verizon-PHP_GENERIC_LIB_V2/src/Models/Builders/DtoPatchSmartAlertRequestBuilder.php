<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DtoPatchSmartAlertRequest;
use VerizonLib\Models\DtoResourceidentifier;
use VerizonLib\Models\UserSmartAlert;

/**
 * Builder for model DtoPatchSmartAlertRequest
 *
 * @see DtoPatchSmartAlertRequest
 */
class DtoPatchSmartAlertRequestBuilder
{
    /**
     * @var DtoPatchSmartAlertRequest
     */
    private $instance;

    private function __construct(DtoPatchSmartAlertRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Dto Patch Smart Alert Request Builder object.
     */
    public static function init(): self
    {
        return new self(new DtoPatchSmartAlertRequest());
    }

    /**
     * Sets accountname field.
     *
     * @param string|null $value
     */
    public function accountname(?string $value): self
    {
        $this->instance->setAccountname($value);
        return $this;
    }

    /**
     * Sets resourceidentifier field.
     *
     * @param DtoResourceidentifier|null $value
     */
    public function resourceidentifier(?DtoResourceidentifier $value): self
    {
        $this->instance->setResourceidentifier($value);
        return $this;
    }

    /**
     * Sets smartalert field.
     *
     * @param UserSmartAlert|null $value
     */
    public function smartalert(?UserSmartAlert $value): self
    {
        $this->instance->setSmartalert($value);
        return $this;
    }

    /**
     * Initializes a new Dto Patch Smart Alert Request object.
     */
    public function build(): DtoPatchSmartAlertRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
