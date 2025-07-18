<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models;

use stdClass;
use VerizonLib\ApiHelper;

class DtoListSmartAlertsRequest implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $accountname;

    /**
     * @var DtoFilter|null
     */
    private $filter;

    /**
     * @var DtoResourceidentifier|null
     */
    private $resourceidentifier;

    /**
     * Returns Accountname.
     * The numeric account name, which must include leading zeros
     */
    public function getAccountname(): ?string
    {
        return $this->accountname;
    }

    /**
     * Sets Accountname.
     * The numeric account name, which must include leading zeros
     *
     * @maps accountname
     */
    public function setAccountname(?string $accountname): void
    {
        $this->accountname = $accountname;
    }

    /**
     * Returns Filter.
     */
    public function getFilter(): ?DtoFilter
    {
        return $this->filter;
    }

    /**
     * Sets Filter.
     *
     * @maps filter
     */
    public function setFilter(?DtoFilter $filter): void
    {
        $this->filter = $filter;
    }

    /**
     * Returns Resourceidentifier.
     */
    public function getResourceidentifier(): ?DtoResourceidentifier
    {
        return $this->resourceidentifier;
    }

    /**
     * Sets Resourceidentifier.
     *
     * @maps resourceidentifier
     */
    public function setResourceidentifier(?DtoResourceidentifier $resourceidentifier): void
    {
        $this->resourceidentifier = $resourceidentifier;
    }

    /**
     * Converts the DtoListSmartAlertsRequest object to a human-readable string representation.
     *
     * @return string The string representation of the DtoListSmartAlertsRequest object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DtoListSmartAlertsRequest',
            [
                'accountname' => $this->accountname,
                'filter' => $this->filter,
                'resourceidentifier' => $this->resourceidentifier
            ]
        );
    }

    /**
     * Encode this object to JSON
     *
     * @param bool $asArrayWhenEmpty Whether to serialize this model as an array whenever no fields
     *        are set. (default: false)
     *
     * @return array|stdClass
     */
    #[\ReturnTypeWillChange] // @phan-suppress-current-line PhanUndeclaredClassAttribute for (php < 8.1)
    public function jsonSerialize(bool $asArrayWhenEmpty = false)
    {
        $json = [];
        if (isset($this->accountname)) {
            $json['accountname']        = $this->accountname;
        }
        if (isset($this->filter)) {
            $json['filter']             = $this->filter;
        }
        if (isset($this->resourceidentifier)) {
            $json['resourceidentifier'] = $this->resourceidentifier;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
