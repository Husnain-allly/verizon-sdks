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

class EsimProfileRequest2 implements \JsonSerializable
{
    /**
     * @var EsimDeviceList[]|null
     */
    private $devices;

    /**
     * @var string|null
     */
    private $accountName;

    /**
     * @var string|null
     */
    private $servicePlan;

    /**
     * @var string|null
     */
    private $mdnZipCode;

    /**
     * Returns Devices.
     *
     * @return EsimDeviceList[]|null
     */
    public function getDevices(): ?array
    {
        return $this->devices;
    }

    /**
     * Sets Devices.
     *
     * @maps devices
     *
     * @param EsimDeviceList[]|null $devices
     */
    public function setDevices(?array $devices): void
    {
        $this->devices = $devices;
    }

    /**
     * Returns Account Name.
     */
    public function getAccountName(): ?string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     *
     * @maps accountName
     */
    public function setAccountName(?string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Service Plan.
     */
    public function getServicePlan(): ?string
    {
        return $this->servicePlan;
    }

    /**
     * Sets Service Plan.
     *
     * @maps servicePlan
     */
    public function setServicePlan(?string $servicePlan): void
    {
        $this->servicePlan = $servicePlan;
    }

    /**
     * Returns Mdn Zip Code.
     */
    public function getMdnZipCode(): ?string
    {
        return $this->mdnZipCode;
    }

    /**
     * Sets Mdn Zip Code.
     *
     * @maps mdnZipCode
     */
    public function setMdnZipCode(?string $mdnZipCode): void
    {
        $this->mdnZipCode = $mdnZipCode;
    }

    /**
     * Converts the EsimProfileRequest2 object to a human-readable string representation.
     *
     * @return string The string representation of the EsimProfileRequest2 object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'EsimProfileRequest2',
            [
                'devices' => $this->devices,
                'accountName' => $this->accountName,
                'servicePlan' => $this->servicePlan,
                'mdnZipCode' => $this->mdnZipCode
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
        if (isset($this->devices)) {
            $json['devices']     = $this->devices;
        }
        if (isset($this->accountName)) {
            $json['accountName'] = $this->accountName;
        }
        if (isset($this->servicePlan)) {
            $json['servicePlan'] = $this->servicePlan;
        }
        if (isset($this->mdnZipCode)) {
            $json['mdnZipCode']  = $this->mdnZipCode;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
