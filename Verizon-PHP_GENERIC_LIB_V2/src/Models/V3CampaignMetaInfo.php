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
use VerizonLib\Utils\DateTimeHelper;

/**
 * Campaign and campaign details.
 */
class V3CampaignMetaInfo implements \JsonSerializable
{
    /**
     * @var string
     */
    private $accountName;

    /**
     * @var string
     */
    private $id;

    /**
     * @var string|null
     */
    private $campaignName;

    /**
     * @var string|null
     */
    private $firmwareName;

    /**
     * @var string|null
     */
    private $firmwareFrom;

    /**
     * @var string|null
     */
    private $firmwareTo;

    /**
     * @var string|null
     */
    private $protocol = CampaignMetaInfoProtocol::LW_M2M;

    /**
     * @var string
     */
    private $make;

    /**
     * @var string
     */
    private $model;

    /**
     * @var \DateTime
     */
    private $startDate;

    /**
     * @var \DateTime
     */
    private $endDate;

    /**
     * @var V3TimeWindow[]|null
     */
    private $campaignTimeWindowList;

    /**
     * @var string
     */
    private $status;

    /**
     * @param string $accountName
     * @param string $id
     * @param string $make
     * @param string $model
     * @param \DateTime $startDate
     * @param \DateTime $endDate
     * @param string $status
     */
    public function __construct(
        string $accountName,
        string $id,
        string $make,
        string $model,
        \DateTime $startDate,
        \DateTime $endDate,
        string $status
    ) {
        $this->accountName = $accountName;
        $this->id = $id;
        $this->make = $make;
        $this->model = $model;
        $this->startDate = $startDate;
        $this->endDate = $endDate;
        $this->status = $status;
    }

    /**
     * Returns Account Name.
     * Account identifier.
     */
    public function getAccountName(): string
    {
        return $this->accountName;
    }

    /**
     * Sets Account Name.
     * Account identifier.
     *
     * @required
     * @maps accountName
     */
    public function setAccountName(string $accountName): void
    {
        $this->accountName = $accountName;
    }

    /**
     * Returns Id.
     * Campaign identifier.
     */
    public function getId(): string
    {
        return $this->id;
    }

    /**
     * Sets Id.
     * Campaign identifier.
     *
     * @required
     * @maps id
     */
    public function setId(string $id): void
    {
        $this->id = $id;
    }

    /**
     * Returns Campaign Name.
     * Campaign name.
     */
    public function getCampaignName(): ?string
    {
        return $this->campaignName;
    }

    /**
     * Sets Campaign Name.
     * Campaign name.
     *
     * @maps campaignName
     */
    public function setCampaignName(?string $campaignName): void
    {
        $this->campaignName = $campaignName;
    }

    /**
     * Returns Firmware Name.
     * Firmware name.
     */
    public function getFirmwareName(): ?string
    {
        return $this->firmwareName;
    }

    /**
     * Sets Firmware Name.
     * Firmware name.
     *
     * @maps firmwareName
     */
    public function setFirmwareName(?string $firmwareName): void
    {
        $this->firmwareName = $firmwareName;
    }

    /**
     * Returns Firmware From.
     * Old firmware version.
     */
    public function getFirmwareFrom(): ?string
    {
        return $this->firmwareFrom;
    }

    /**
     * Sets Firmware From.
     * Old firmware version.
     *
     * @maps firmwareFrom
     */
    public function setFirmwareFrom(?string $firmwareFrom): void
    {
        $this->firmwareFrom = $firmwareFrom;
    }

    /**
     * Returns Firmware To.
     * New software version.
     */
    public function getFirmwareTo(): ?string
    {
        return $this->firmwareTo;
    }

    /**
     * Sets Firmware To.
     * New software version.
     *
     * @maps firmwareTo
     */
    public function setFirmwareTo(?string $firmwareTo): void
    {
        $this->firmwareTo = $firmwareTo;
    }

    /**
     * Returns Protocol.
     * Firmware protocol. Valid values include: LWM2M, OMD-DM.
     */
    public function getProtocol(): ?string
    {
        return $this->protocol;
    }

    /**
     * Sets Protocol.
     * Firmware protocol. Valid values include: LWM2M, OMD-DM.
     *
     * @maps protocol
     * @factory \VerizonLib\Models\CampaignMetaInfoProtocol::checkValue
     */
    public function setProtocol(?string $protocol): void
    {
        $this->protocol = $protocol;
    }

    /**
     * Returns Make.
     * Device make.
     */
    public function getMake(): string
    {
        return $this->make;
    }

    /**
     * Sets Make.
     * Device make.
     *
     * @required
     * @maps make
     */
    public function setMake(string $make): void
    {
        $this->make = $make;
    }

    /**
     * Returns Model.
     * Device model.
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * Sets Model.
     * Device model.
     *
     * @required
     * @maps model
     */
    public function setModel(string $model): void
    {
        $this->model = $model;
    }

    /**
     * Returns Start Date.
     * Campaign start date.
     */
    public function getStartDate(): \DateTime
    {
        return $this->startDate;
    }

    /**
     * Sets Start Date.
     * Campaign start date.
     *
     * @required
     * @maps startDate
     * @factory \VerizonLib\Utils\DateTimeHelper::fromSimpleDate
     */
    public function setStartDate(\DateTime $startDate): void
    {
        $this->startDate = $startDate;
    }

    /**
     * Returns End Date.
     * Campaign end date.
     */
    public function getEndDate(): \DateTime
    {
        return $this->endDate;
    }

    /**
     * Sets End Date.
     * Campaign end date.
     *
     * @required
     * @maps endDate
     * @factory \VerizonLib\Utils\DateTimeHelper::fromSimpleDate
     */
    public function setEndDate(\DateTime $endDate): void
    {
        $this->endDate = $endDate;
    }

    /**
     * Returns Campaign Time Window List.
     * List of allowed campaign time windows.
     *
     * @return V3TimeWindow[]|null
     */
    public function getCampaignTimeWindowList(): ?array
    {
        return $this->campaignTimeWindowList;
    }

    /**
     * Sets Campaign Time Window List.
     * List of allowed campaign time windows.
     *
     * @maps campaignTimeWindowList
     *
     * @param V3TimeWindow[]|null $campaignTimeWindowList
     */
    public function setCampaignTimeWindowList(?array $campaignTimeWindowList): void
    {
        $this->campaignTimeWindowList = $campaignTimeWindowList;
    }

    /**
     * Returns Status.
     * Firmware upgrade status.
     */
    public function getStatus(): string
    {
        return $this->status;
    }

    /**
     * Sets Status.
     * Firmware upgrade status.
     *
     * @required
     * @maps status
     */
    public function setStatus(string $status): void
    {
        $this->status = $status;
    }

    /**
     * Converts the V3CampaignMetaInfo object to a human-readable string representation.
     *
     * @return string The string representation of the V3CampaignMetaInfo object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'V3CampaignMetaInfo',
            [
                'accountName' => $this->accountName,
                'id' => $this->id,
                'campaignName' => $this->campaignName,
                'firmwareName' => $this->firmwareName,
                'firmwareFrom' => $this->firmwareFrom,
                'firmwareTo' => $this->firmwareTo,
                'protocol' => $this->protocol,
                'make' => $this->make,
                'model' => $this->model,
                'startDate' => $this->startDate,
                'endDate' => $this->endDate,
                'campaignTimeWindowList' => $this->campaignTimeWindowList,
                'status' => $this->status,
                'additionalProperties' => $this->additionalProperties
            ]
        );
    }

    protected $propertyNames = [
        'accountName',
        'id',
        'campaignName',
        'firmwareName',
        'firmwareFrom',
        'firmwareTo',
        'protocol',
        'make',
        'model',
        'startDate',
        'endDate',
        'campaignTimeWindowList',
        'status'
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
        $json['accountName']                = $this->accountName;
        $json['id']                         = $this->id;
        if (isset($this->campaignName)) {
            $json['campaignName']           = $this->campaignName;
        }
        if (isset($this->firmwareName)) {
            $json['firmwareName']           = $this->firmwareName;
        }
        if (isset($this->firmwareFrom)) {
            $json['firmwareFrom']           = $this->firmwareFrom;
        }
        if (isset($this->firmwareTo)) {
            $json['firmwareTo']             = $this->firmwareTo;
        }
        if (isset($this->protocol)) {
            $json['protocol']               = CampaignMetaInfoProtocol::checkValue($this->protocol);
        }
        $json['make']                       = $this->make;
        $json['model']                      = $this->model;
        $json['startDate']                  = DateTimeHelper::toSimpleDate($this->startDate);
        $json['endDate']                    = DateTimeHelper::toSimpleDate($this->endDate);
        if (isset($this->campaignTimeWindowList)) {
            $json['campaignTimeWindowList'] = $this->campaignTimeWindowList;
        }
        $json['status']                     = $this->status;
        $json = array_merge($json, $this->additionalProperties);

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
