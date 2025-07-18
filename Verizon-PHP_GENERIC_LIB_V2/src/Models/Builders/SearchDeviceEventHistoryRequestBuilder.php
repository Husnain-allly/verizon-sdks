<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountIdentifier;
use VerizonLib\Models\ResourceIdentifier;
use VerizonLib\Models\SearchDeviceEventHistoryRequest;

/**
 * Builder for model SearchDeviceEventHistoryRequest
 *
 * @see SearchDeviceEventHistoryRequest
 */
class SearchDeviceEventHistoryRequestBuilder
{
    /**
     * @var SearchDeviceEventHistoryRequest
     */
    private $instance;

    private function __construct(SearchDeviceEventHistoryRequest $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Search Device Event History Request Builder object.
     *
     * @param AccountIdentifier $accountidentifier
     * @param ResourceIdentifier $resourceidentifier
     */
    public static function init(AccountIdentifier $accountidentifier, ResourceIdentifier $resourceidentifier): self
    {
        return new self(new SearchDeviceEventHistoryRequest($accountidentifier, $resourceidentifier));
    }

    /**
     * Sets selection field.
     *
     * @param array<string,string>|null $value
     */
    public function mSelection(?array $value): self
    {
        $this->instance->setMSelection($value);
        return $this;
    }

    /**
     * Sets limitnumber field.
     *
     * @param int|null $value
     */
    public function mLimitnumber(?int $value): self
    {
        $this->instance->setMLimitnumber($value);
        return $this;
    }

    /**
     * Sets page field.
     *
     * @param string|null $value
     */
    public function mPage(?string $value): self
    {
        $this->instance->setMPage($value);
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
     * Initializes a new Search Device Event History Request object.
     */
    public function build(): SearchDeviceEventHistoryRequest
    {
        return CoreHelper::clone($this->instance);
    }
}
