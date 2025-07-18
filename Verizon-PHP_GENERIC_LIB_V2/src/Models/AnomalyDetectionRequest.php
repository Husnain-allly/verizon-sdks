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
 * Anomaly detection request.
 */
class AnomalyDetectionRequest implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $accountName;

    /**
     * @var string|null
     */
    private $requestType;

    /**
     * @var SensitivityParameters|null
     */
    private $sensitivityParameter;

    /**
     * Returns Account Name.
     * The name of a billing account. An account name is usually numeric, and must include any leading
     * zeros.
     */
    public function getAccountName(): ?string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * The name of a billing account. An account name is usually numeric, and must include any leading
     * zeros.
     *
     * @maps accountName
     */
    public function setAccountName(?string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Request Type.
     * The type of request being made. anomaly is the request to activate anomaly detection.
     */
    public function getRequestType(): ?string
    {
        return $this->requestType;
    }

    /**
     * Sets Request Type.
     * The type of request being made. anomaly is the request to activate anomaly detection.
     *
     * @maps requestType
     */
    public function setRequestType(?string $requestType): void
    {
        $this->requestType = $requestType;
    }

    /**
     * Returns Sensitivity Parameter.
     * Details for sensitivity parameters.
     */
    public function getSensitivityParameter(): ?SensitivityParameters
    {
        return $this->sensitivityParameter;
    }

    /**
     * Sets Sensitivity Parameter.
     * Details for sensitivity parameters.
     *
     * @maps sensitivityParameter
     */
    public function setSensitivityParameter(?SensitivityParameters $sensitivityParameter): void
    {
        $this->sensitivityParameter = $sensitivityParameter;
    }

    /**
     * Converts the AnomalyDetectionRequest object to a human-readable string representation.
     *
     * @return string The string representation of the AnomalyDetectionRequest object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'AnomalyDetectionRequest',
            [
                'accountName' => $this->accountName,
                'requestType' => $this->requestType,
                'sensitivityParameter' => $this->sensitivityParameter
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
        if (isset($this->accountName)) {
            $json['accountName']          = $this->accountName;
        }
        if (isset($this->requestType)) {
            $json['requestType']          = $this->requestType;
        }
        if (isset($this->sensitivityParameter)) {
            $json['sensitivityParameter'] = $this->sensitivityParameter;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
