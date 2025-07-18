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

/**
 * Upgrade information.
 */
class UpgradeListQueryResult implements \JsonSerializable
{
    /**
     * @var bool|null
     */
    private $hasMoreFlag;

    /**
     * @var int|null
     */
    private $lastSeenUpgradeId;

    /**
     * @var array
     */
    private $reportList = [];

    /**
     * Returns Has More Flag.
     * True if there are more devices to retrieve.
     */
    public function getHasMoreFlag(): ?bool
    {
        return $this->hasMoreFlag;
    }

    /**
     * Sets Has More Flag.
     * True if there are more devices to retrieve.
     *
     * @maps hasMoreFlag
     */
    public function setHasMoreFlag(?bool $hasMoreFlag): void
    {
        $this->hasMoreFlag = $hasMoreFlag;
    }

    /**
     * Returns Last Seen Upgrade Id.
     * If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
     */
    public function getLastSeenUpgradeId(): ?int
    {
        return $this->lastSeenUpgradeId;
    }

    /**
     * Sets Last Seen Upgrade Id.
     * If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
     *
     * @maps lastSeenUpgradeId
     */
    public function setLastSeenUpgradeId(?int $lastSeenUpgradeId): void
    {
        $this->lastSeenUpgradeId = $lastSeenUpgradeId;
    }

    /**
     * Returns Report List.
     * Array of upgrade objects with the specified status.
     *
     * @return FirmwareUpgrade[]|null
     */
    public function getReportList(): ?array
    {
        if (count($this->reportList) == 0) {
            return null;
        }
        return $this->reportList['value'];
    }

    /**
     * Sets Report List.
     * Array of upgrade objects with the specified status.
     *
     * @maps reportList
     *
     * @param FirmwareUpgrade[]|null $reportList
     */
    public function setReportList(?array $reportList): void
    {
        $this->reportList['value'] = $reportList;
    }

    /**
     * Unsets Report List.
     * Array of upgrade objects with the specified status.
     */
    public function unsetReportList(): void
    {
        $this->reportList = [];
    }

    /**
     * Converts the UpgradeListQueryResult object to a human-readable string representation.
     *
     * @return string The string representation of the UpgradeListQueryResult object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'UpgradeListQueryResult',
            [
                'hasMoreFlag' => $this->hasMoreFlag,
                'lastSeenUpgradeId' => $this->lastSeenUpgradeId,
                'reportList' => $this->getReportList(),
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = ['hasMoreFlag', 'lastSeenUpgradeId', 'reportList'];

    private $additionalProperties = [];

    /**
     * Add an additional property to this model.
     *
     * @param string $name Name of property.
     * @param mixed $value Value of property.
     */
    public function addAdditionalProperty(string $name, $value)
    {
        if (in_array($name, $this->propertyNames, true)) {
            throw new \InvalidArgumentException(
                "The additional property key, '$name' conflicts with one of the model's properties"
            );
        }

        $this->additionalProperties[$name] = $value;
    }

    /**
     * Find an additional property by name in this model or false if property does not exist.
     *
     * @param string $name Name of property.
     *
     * @return mixed|false Value of the property.
     */
    public function findAdditionalProperty(string $name)
    {
        if (isset($this->additionalProperties[$name])) {
            return $this->additionalProperties[$name];
        }
        return false;
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
        if (isset($this->hasMoreFlag)) {
            $json['hasMoreFlag']       = $this->hasMoreFlag;
        }
        if (isset($this->lastSeenUpgradeId)) {
            $json['lastSeenUpgradeId'] = $this->lastSeenUpgradeId;
        }
        if (!empty($this->reportList)) {
            $json['reportList']        = $this->reportList['value'];
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
