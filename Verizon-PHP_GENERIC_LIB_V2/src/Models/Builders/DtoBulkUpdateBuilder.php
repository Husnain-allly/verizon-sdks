<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\BulkUpdateSmartalert;
use VerizonLib\Models\DtoBulkUpdate;
use VerizonLib\Models\TheIDresourceandDeviceId;

/**
 * Builder for model DtoBulkUpdate
 *
 * @see DtoBulkUpdate
 */
class DtoBulkUpdateBuilder
{
    /**
     * @var DtoBulkUpdate
     */
    private $instance;

    private function __construct(DtoBulkUpdate $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Dto Bulk Update Builder object.
     */
    public static function init(): self
    {
        return new self(new DtoBulkUpdate());
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
     * Sets resourceidentifiers field.
     *
     * @param TheIDresourceandDeviceId[]|null $value
     */
    public function resourceidentifiers(?array $value): self
    {
        $this->instance->setResourceidentifiers($value);
        return $this;
    }

    /**
     * Sets smartalert field.
     *
     * @param BulkUpdateSmartalert|null $value
     */
    public function smartalert(?BulkUpdateSmartalert $value): self
    {
        $this->instance->setSmartalert($value);
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
     * Initializes a new Dto Bulk Update object.
     */
    public function build(): DtoBulkUpdate
    {
        return CoreHelper::clone($this->instance);
    }
}
