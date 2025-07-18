<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\DtoCreateNotificationGroupRequest;
use VerizonLib\Models\DtoNotificationGroupRequestEntity;

/**
 * Builder for model DtoCreateNotificationGroupRequest
 *
 * @see DtoCreateNotificationGroupRequest
 */
class DtoCreateNotificationGroupRequestBuilder
{
    /**
     * @var DtoCreateNotificationGroupRequest
     */
    private $instance;

    private function __construct(DtoCreateNotificationGroupRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Dto Create Notification Group Request Builder object.
     *
     * @param DtoNotificationGroupRequestEntity $group
     */
    public static function init(DtoNotificationGroupRequestEntity $group): self
    {
        return new self(new DtoCreateNotificationGroupRequest($group));
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
     * Sets userids field.
     *
     * @param string[]|null $value
     */
    public function userids(?array $value): self
    {
        $this->instance->setUserids($value);
        return $this;
    }

    /**
     * Initializes a new Dto Create Notification Group Request object.
     */
    public function build(): DtoCreateNotificationGroupRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
