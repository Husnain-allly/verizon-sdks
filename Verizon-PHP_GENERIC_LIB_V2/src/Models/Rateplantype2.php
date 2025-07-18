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

class Rateplantype2 implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $description;

    /**
     * @var string|null
     */
    private $sizeKb;

    /**
     * @var string|null
     */
    private $carrierRatePlanCode;

    /**
     * @var bool|null
     */
    private $zeroDollarBilling;

    /**
     * @var bool|null
     */
    private $promotionOffered;

    /**
     * @var int|null
     */
    private $promotionDays;

    /**
     * @var string|null
     */
    private $ratePlanType;

    /**
     * @var Accountid[]|null
     */
    private $account;

    /**
     * Returns Description.
     */
    public function getDescription(): ?string
    {
        return $this->description;
    }

    /**
     * Sets Description.
     *
     * @maps description
     */
    public function setDescription(?string $description): void
    {
        $this->description = $description;
    }

    /**
     * Returns Size Kb.
     */
    public function getSizeKb(): ?string
    {
        return $this->sizeKb;
    }

    /**
     * Sets Size Kb.
     *
     * @maps sizeKb
     */
    public function setSizeKb(?string $sizeKb): void
    {
        $this->sizeKb = $sizeKb;
    }

    /**
     * Returns Carrier Rate Plan Code.
     */
    public function getCarrierRatePlanCode(): ?string
    {
        return $this->carrierRatePlanCode;
    }

    /**
     * Sets Carrier Rate Plan Code.
     *
     * @maps carrierRatePlanCode
     */
    public function setCarrierRatePlanCode(?string $carrierRatePlanCode): void
    {
        $this->carrierRatePlanCode = $carrierRatePlanCode;
    }

    /**
     * Returns Zero Dollar Billing.
     */
    public function getZeroDollarBilling(): ?bool
    {
        return $this->zeroDollarBilling;
    }

    /**
     * Sets Zero Dollar Billing.
     *
     * @maps zeroDollarBilling
     */
    public function setZeroDollarBilling(?bool $zeroDollarBilling): void
    {
        $this->zeroDollarBilling = $zeroDollarBilling;
    }

    /**
     * Returns Promotion Offered.
     */
    public function getPromotionOffered(): ?bool
    {
        return $this->promotionOffered;
    }

    /**
     * Sets Promotion Offered.
     *
     * @maps promotionOffered
     */
    public function setPromotionOffered(?bool $promotionOffered): void
    {
        $this->promotionOffered = $promotionOffered;
    }

    /**
     * Returns Promotion Days.
     */
    public function getPromotionDays(): ?int
    {
        return $this->promotionDays;
    }

    /**
     * Sets Promotion Days.
     *
     * @maps promotionDays
     */
    public function setPromotionDays(?int $promotionDays): void
    {
        $this->promotionDays = $promotionDays;
    }

    /**
     * Returns Rate Plan Type.
     */
    public function getRatePlanType(): ?string
    {
        return $this->ratePlanType;
    }

    /**
     * Sets Rate Plan Type.
     *
     * @maps ratePlanType
     */
    public function setRatePlanType(?string $ratePlanType): void
    {
        $this->ratePlanType = $ratePlanType;
    }

    /**
     * Returns Account.
     * Account information
     *
     * @return Accountid[]|null
     */
    public function getAccount(): ?array
    {
        return $this->account;
    }

    /**
     * Sets Account.
     * Account information
     *
     * @maps account
     *
     * @param Accountid[]|null $account
     */
    public function setAccount(?array $account): void
    {
        $this->account = $account;
    }

    /**
     * Converts the Rateplantype2 object to a human-readable string representation.
     *
     * @return string The string representation of the Rateplantype2 object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'Rateplantype2',
            [
                'description' => $this->description,
                'sizeKb' => $this->sizeKb,
                'carrierRatePlanCode' => $this->carrierRatePlanCode,
                'zeroDollarBilling' => $this->zeroDollarBilling,
                'promotionOffered' => $this->promotionOffered,
                'promotionDays' => $this->promotionDays,
                'ratePlanType' => $this->ratePlanType,
                'account' => $this->account,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = [
        'description',
        'sizeKb',
        'carrierRatePlanCode',
        'zeroDollarBilling',
        'promotionOffered',
        'promotionDays',
        'ratePlanType',
        'account'
    ];

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
        if (isset($this->description)) {
            $json['description']         = $this->description;
        }
        if (isset($this->sizeKb)) {
            $json['sizeKb']              = $this->sizeKb;
        }
        if (isset($this->carrierRatePlanCode)) {
            $json['carrierRatePlanCode'] = $this->carrierRatePlanCode;
        }
        if (isset($this->zeroDollarBilling)) {
            $json['zeroDollarBilling']   = $this->zeroDollarBilling;
        }
        if (isset($this->promotionOffered)) {
            $json['promotionOffered']    = $this->promotionOffered;
        }
        if (isset($this->promotionDays)) {
            $json['promotionDays']       = $this->promotionDays;
        }
        if (isset($this->ratePlanType)) {
            $json['ratePlanType']        = $this->ratePlanType;
        }
        if (isset($this->account)) {
            $json['account']             = $this->account;
        }
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
