<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\SearchDeviceEventHistoryResponseList;
use VerizonLib\Models\SearchDeviceResponse;

/**
 * Builder for model SearchDeviceEventHistoryResponseList
 *
 * @see SearchDeviceEventHistoryResponseList
 */
class SearchDeviceEventHistoryResponseListBuilder
{
    /**
     * @var SearchDeviceEventHistoryResponseList
     */
    private $instance;

    private function __construct(SearchDeviceEventHistoryResponseList $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Search Device Event History Response List Builder object.
     */
    public static function init(): self
    {
        return new self(new SearchDeviceEventHistoryResponseList());
    }

    /**
     * Sets Search Device Event History field.
     *
     * @param SearchDeviceResponse[]|null $value
     */
    public function searchDeviceEventHistory(?array $value): self
    {
        $this->instance->setSearchDeviceEventHistory($value);
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
     * Initializes a new Search Device Event History Response List object.
     */
    public function build(): SearchDeviceEventHistoryResponseList
    {
        return CoreHelper::clone($this->instance);
    }
}
