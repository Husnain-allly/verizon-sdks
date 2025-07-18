<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\FotaV3SuccessResult;

/**
 * Builder for model FotaV3SuccessResult
 *
 * @see FotaV3SuccessResult
 */
class FotaV3SuccessResultBuilder
{
    /**
     * @var FotaV3SuccessResult
     */
    private $instance;

    private function __construct(FotaV3SuccessResult $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Fota V3 Success Result Builder object.
     *
     * @param bool $success
     */
    public static function init(bool $success): self
    {
        return new self(new FotaV3SuccessResult($success));
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
     * Initializes a new Fota V3 Success Result object.
     */
    public function build(): FotaV3SuccessResult
    {
        return CoreHelper::clone($this->instance);
    }
}
