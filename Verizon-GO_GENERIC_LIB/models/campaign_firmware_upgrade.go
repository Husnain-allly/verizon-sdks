/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "errors"
    "fmt"
    "log"
    "strings"
    "time"
)

// CampaignFirmwareUpgrade represents a CampaignFirmwareUpgrade struct.
// Firmware upgrade for devices.
type CampaignFirmwareUpgrade struct {
    // Campaign name.
    CampaignName           *string                `json:"campaignName,omitempty"`
    // Firmware name to upgrade to.
    FirmwareName           string                 `json:"firmwareName"`
    // Old firmware version.
    FirmwareFrom           string                 `json:"firmwareFrom"`
    // New firmware version.
    FirmwareTo             string                 `json:"firmwareTo"`
    // Valid values include: LWM2M, OMA and HTTP.
    Protocol               string                 `json:"protocol"`
    // Campaign start date.
    StartDate              time.Time              `json:"startDate"`
    // Campaign end date.
    EndDate                time.Time              `json:"endDate"`
    // List of allowed campaign time windows.
    CampaignTimeWindowList []V3TimeWindow         `json:"campaignTimeWindowList,omitempty"`
    // Device IMEI list.
    DeviceList             []string               `json:"deviceList"`
    // This flag, when set to true, will assign a FOTA license automatically if the device does not have one already.
    AutoAssignLicenseFlag  bool                   `json:"autoAssignLicenseFlag"`
    // this flag, when set to true, will automatically add a device of the same make and model to a campaign.
    AutoAddDevicesFlag     bool                   `json:"autoAddDevicesFlag"`
    AdditionalProperties   map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for CampaignFirmwareUpgrade,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c CampaignFirmwareUpgrade) String() string {
    return fmt.Sprintf(
    	"CampaignFirmwareUpgrade[CampaignName=%v, FirmwareName=%v, FirmwareFrom=%v, FirmwareTo=%v, Protocol=%v, StartDate=%v, EndDate=%v, CampaignTimeWindowList=%v, DeviceList=%v, AutoAssignLicenseFlag=%v, AutoAddDevicesFlag=%v, AdditionalProperties=%v]",
    	c.CampaignName, c.FirmwareName, c.FirmwareFrom, c.FirmwareTo, c.Protocol, c.StartDate, c.EndDate, c.CampaignTimeWindowList, c.DeviceList, c.AutoAssignLicenseFlag, c.AutoAddDevicesFlag, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for CampaignFirmwareUpgrade.
// It customizes the JSON marshaling process for CampaignFirmwareUpgrade objects.
func (c CampaignFirmwareUpgrade) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "campaignName", "firmwareName", "firmwareFrom", "firmwareTo", "protocol", "startDate", "endDate", "campaignTimeWindowList", "deviceList", "autoAssignLicenseFlag", "autoAddDevicesFlag"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the CampaignFirmwareUpgrade object to a map representation for JSON marshaling.
func (c CampaignFirmwareUpgrade) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    if c.CampaignName != nil {
        structMap["campaignName"] = c.CampaignName
    }
    structMap["firmwareName"] = c.FirmwareName
    structMap["firmwareFrom"] = c.FirmwareFrom
    structMap["firmwareTo"] = c.FirmwareTo
    structMap["protocol"] = c.Protocol
    structMap["startDate"] = c.StartDate.Format(DEFAULT_DATE)
    structMap["endDate"] = c.EndDate.Format(DEFAULT_DATE)
    if c.CampaignTimeWindowList != nil {
        structMap["campaignTimeWindowList"] = c.CampaignTimeWindowList
    }
    structMap["deviceList"] = c.DeviceList
    structMap["autoAssignLicenseFlag"] = c.AutoAssignLicenseFlag
    structMap["autoAddDevicesFlag"] = c.AutoAddDevicesFlag
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for CampaignFirmwareUpgrade.
// It customizes the JSON unmarshaling process for CampaignFirmwareUpgrade objects.
func (c *CampaignFirmwareUpgrade) UnmarshalJSON(input []byte) error {
    var temp tempCampaignFirmwareUpgrade
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "campaignName", "firmwareName", "firmwareFrom", "firmwareTo", "protocol", "startDate", "endDate", "campaignTimeWindowList", "deviceList", "autoAssignLicenseFlag", "autoAddDevicesFlag")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.CampaignName = temp.CampaignName
    c.FirmwareName = *temp.FirmwareName
    c.FirmwareFrom = *temp.FirmwareFrom
    c.FirmwareTo = *temp.FirmwareTo
    c.Protocol = *temp.Protocol
    StartDateVal, err := time.Parse(DEFAULT_DATE, *temp.StartDate)
    if err != nil {
        log.Fatalf("Cannot Parse startDate as % s format.", DEFAULT_DATE)
    }
    c.StartDate = StartDateVal
    EndDateVal, err := time.Parse(DEFAULT_DATE, *temp.EndDate)
    if err != nil {
        log.Fatalf("Cannot Parse endDate as % s format.", DEFAULT_DATE)
    }
    c.EndDate = EndDateVal
    c.CampaignTimeWindowList = temp.CampaignTimeWindowList
    c.DeviceList = *temp.DeviceList
    c.AutoAssignLicenseFlag = *temp.AutoAssignLicenseFlag
    c.AutoAddDevicesFlag = *temp.AutoAddDevicesFlag
    return nil
}

// tempCampaignFirmwareUpgrade is a temporary struct used for validating the fields of CampaignFirmwareUpgrade.
type tempCampaignFirmwareUpgrade  struct {
    CampaignName           *string        `json:"campaignName,omitempty"`
    FirmwareName           *string        `json:"firmwareName"`
    FirmwareFrom           *string        `json:"firmwareFrom"`
    FirmwareTo             *string        `json:"firmwareTo"`
    Protocol               *string        `json:"protocol"`
    StartDate              *string        `json:"startDate"`
    EndDate                *string        `json:"endDate"`
    CampaignTimeWindowList []V3TimeWindow `json:"campaignTimeWindowList,omitempty"`
    DeviceList             *[]string      `json:"deviceList"`
    AutoAssignLicenseFlag  *bool          `json:"autoAssignLicenseFlag"`
    AutoAddDevicesFlag     *bool          `json:"autoAddDevicesFlag"`
}

func (c *tempCampaignFirmwareUpgrade) validate() error {
    var errs []string
    if c.FirmwareName == nil {
        errs = append(errs, "required field `firmwareName` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.FirmwareFrom == nil {
        errs = append(errs, "required field `firmwareFrom` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.FirmwareTo == nil {
        errs = append(errs, "required field `firmwareTo` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.Protocol == nil {
        errs = append(errs, "required field `protocol` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.StartDate == nil {
        errs = append(errs, "required field `startDate` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.EndDate == nil {
        errs = append(errs, "required field `endDate` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.DeviceList == nil {
        errs = append(errs, "required field `deviceList` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.AutoAssignLicenseFlag == nil {
        errs = append(errs, "required field `autoAssignLicenseFlag` is missing for type `CampaignFirmwareUpgrade`")
    }
    if c.AutoAddDevicesFlag == nil {
        errs = append(errs, "required field `autoAddDevicesFlag` is missing for type `CampaignFirmwareUpgrade`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
