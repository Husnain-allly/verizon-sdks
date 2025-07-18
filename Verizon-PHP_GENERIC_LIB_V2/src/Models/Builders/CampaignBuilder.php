<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\Campaign;
use VerizonLib\Models\V3TimeWindow;

/**
 * Builder for model Campaign
 *
 * @see Campaign
 */
class CampaignBuilder
{
    /**
     * @var Campaign
     */
    private $instance;

    private function __construct(Campaign $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Campaign Builder object.
     *
     * @param string $id
     * @param string $accountName
     * @param string $protocol
     * @param string $make
     * @param string $model
     * @param \DateTime $startDate
     * @param \DateTime $endDate
     * @param string $status
     * @param bool $autoAssignLicenseFlag
     * @param bool $autoAddDevicesFlag
     */
    public static function init(
        string $id,
        string $accountName,
        string $protocol,
        string $make,
        string $model,
        \DateTime $startDate,
        \DateTime $endDate,
        string $status,
        bool $autoAssignLicenseFlag,
        bool $autoAddDevicesFlag
    ): self {
        return new self(new Campaign(
            $id,
            $accountName,
            $protocol,
            $make,
            $model,
            $startDate,
            $endDate,
            $status,
            $autoAssignLicenseFlag,
            $autoAddDevicesFlag
        ));
    }

    /**
     * Sets campaign Name field.
     *
     * @param string|null $value
     */
    public function campaignName(?string $value): self
    {
        $this->instance->setCampaignName($value);
        return $this;
    }

    /**
     * Sets firmware Name field.
     *
     * @param string|null $value
     */
    public function firmwareName(?string $value): self
    {
        $this->instance->setFirmwareName($value);
        return $this;
    }

    /**
     * Sets firmware From field.
     *
     * @param string|null $value
     */
    public function firmwareFrom(?string $value): self
    {
        $this->instance->setFirmwareFrom($value);
        return $this;
    }

    /**
     * Sets firmware To field.
     *
     * @param string|null $value
     */
    public function firmwareTo(?string $value): self
    {
        $this->instance->setFirmwareTo($value);
        return $this;
    }

    /**
     * Sets campaign Time Window List field.
     *
     * @param V3TimeWindow[]|null $value
     */
    public function campaignTimeWindowList(?array $value): self
    {
        $this->instance->setCampaignTimeWindowList($value);
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
     * Initializes a new Campaign object.
     */
    public function build(): Campaign
    {
        return CoreHelper::clone($this->instance);
    }
}
