<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DtoFilter;
use VerizonLib\Models\DtoListNotificationGroupRequest;

/**
 * Builder for model DtoListNotificationGroupRequest
 *
 * @see DtoListNotificationGroupRequest
 */
class DtoListNotificationGroupRequestBuilder
{
    /**
     * @var DtoListNotificationGroupRequest
     */
    private $instance;

    private function __construct(DtoListNotificationGroupRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Dto List Notification Group Request Builder object.
     */
    public static function init(): self
    {
        return new self(new DtoListNotificationGroupRequest());
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
     * Sets filter field.
     *
     * @param DtoFilter|null $value
     */
    public function filter(?DtoFilter $value): self
    {
        $this->instance->setFilter($value);
        return $this;
    }

    /**
     * Initializes a new Dto List Notification Group Request object.
     */
    public function build(): DtoListNotificationGroupRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
