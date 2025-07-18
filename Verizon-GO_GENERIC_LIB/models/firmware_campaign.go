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

// FirmwareCampaign represents a FirmwareCampaign struct.
// Firmware upgrade information.
type FirmwareCampaign struct {
    // Upgrade identifier.
    Id                     string                 `json:"id"`
    // Account identifier.
    AccountName            string                 `json:"accountName"`
    // Campaign name.
    CampaignName           *string                `json:"campaignName,omitempty"`
    // Firmware name (for firmware upgrade only).
    FirmwareName           *string                `json:"firmwareName,omitempty"`
    // Old firmware version (for firmware upgrade only).
    FirmwareFrom           string                 `json:"firmwareFrom"`
    // New firmware version (for firmware upgrade only).
    FirmwareTo             string                 `json:"firmwareTo"`
    // Available values: LWM2M.
    Protocol               string                 `json:"protocol"`
    Make                   string                 `json:"make"`
    Model                  string                 `json:"model"`
    // Campaign start date.
    StartDate              time.Time              `json:"startDate"`
    // Campaign end date.
    EndDate                time.Time              `json:"endDate"`
    // List of allowed campaign time windows.
    CampaignTimeWindowList []V3TimeWindow         `json:"campaignTimeWindowList,omitempty"`
    // Campaign status.
    Status                 string                 `json:"status"`
    AdditionalProperties   map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for FirmwareCampaign,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (f FirmwareCampaign) String() string {
    return fmt.Sprintf(
    	"FirmwareCampaign[Id=%v, AccountName=%v, CampaignName=%v, FirmwareName=%v, FirmwareFrom=%v, FirmwareTo=%v, Protocol=%v, Make=%v, Model=%v, StartDate=%v, EndDate=%v, CampaignTimeWindowList=%v, Status=%v, AdditionalProperties=%v]",
    	f.Id, f.AccountName, f.CampaignName, f.FirmwareName, f.FirmwareFrom, f.FirmwareTo, f.Protocol, f.Make, f.Model, f.StartDate, f.EndDate, f.CampaignTimeWindowList, f.Status, f.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for FirmwareCampaign.
// It customizes the JSON marshaling process for FirmwareCampaign objects.
func (f FirmwareCampaign) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(f.AdditionalProperties,
        "id", "accountName", "campaignName", "firmwareName", "firmwareFrom", "firmwareTo", "protocol", "make", "model", "startDate", "endDate", "campaignTimeWindowList", "status"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(f.toMap())
}

// toMap converts the FirmwareCampaign object to a map representation for JSON marshaling.
func (f FirmwareCampaign) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, f.AdditionalProperties)
    structMap["id"] = f.Id
    structMap["accountName"] = f.AccountName
    if f.CampaignName != nil {
        structMap["campaignName"] = f.CampaignName
    }
    if f.FirmwareName != nil {
        structMap["firmwareName"] = f.FirmwareName
    }
    structMap["firmwareFrom"] = f.FirmwareFrom
    structMap["firmwareTo"] = f.FirmwareTo
    structMap["protocol"] = f.Protocol
    structMap["make"] = f.Make
    structMap["model"] = f.Model
    structMap["startDate"] = f.StartDate.Format(DEFAULT_DATE)
    structMap["endDate"] = f.EndDate.Format(DEFAULT_DATE)
    if f.CampaignTimeWindowList != nil {
        structMap["campaignTimeWindowList"] = f.CampaignTimeWindowList
    }
    structMap["status"] = f.Status
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for FirmwareCampaign.
// It customizes the JSON unmarshaling process for FirmwareCampaign objects.
func (f *FirmwareCampaign) UnmarshalJSON(input []byte) error {
    var temp tempFirmwareCampaign
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "id", "accountName", "campaignName", "firmwareName", "firmwareFrom", "firmwareTo", "protocol", "make", "model", "startDate", "endDate", "campaignTimeWindowList", "status")
    if err != nil {
    	return err
    }
    f.AdditionalProperties = additionalProperties
    
    f.Id = *temp.Id
    f.AccountName = *temp.AccountName
    f.CampaignName = temp.CampaignName
    f.FirmwareName = temp.FirmwareName
    f.FirmwareFrom = *temp.FirmwareFrom
    f.FirmwareTo = *temp.FirmwareTo
    f.Protocol = *temp.Protocol
    f.Make = *temp.Make
    f.Model = *temp.Model
    StartDateVal, err := time.Parse(DEFAULT_DATE, *temp.StartDate)
    if err != nil {
        log.Fatalf("Cannot Parse startDate as % s format.", DEFAULT_DATE)
    }
    f.StartDate = StartDateVal
    EndDateVal, err := time.Parse(DEFAULT_DATE, *temp.EndDate)
    if err != nil {
        log.Fatalf("Cannot Parse endDate as % s format.", DEFAULT_DATE)
    }
    f.EndDate = EndDateVal
    f.CampaignTimeWindowList = temp.CampaignTimeWindowList
    f.Status = *temp.Status
    return nil
}

// tempFirmwareCampaign is a temporary struct used for validating the fields of FirmwareCampaign.
type tempFirmwareCampaign  struct {
    Id                     *string        `json:"id"`
    AccountName            *string        `json:"accountName"`
    CampaignName           *string        `json:"campaignName,omitempty"`
    FirmwareName           *string        `json:"firmwareName,omitempty"`
    FirmwareFrom           *string        `json:"firmwareFrom"`
    FirmwareTo             *string        `json:"firmwareTo"`
    Protocol               *string        `json:"protocol"`
    Make                   *string        `json:"make"`
    Model                  *string        `json:"model"`
    StartDate              *string        `json:"startDate"`
    EndDate                *string        `json:"endDate"`
    CampaignTimeWindowList []V3TimeWindow `json:"campaignTimeWindowList,omitempty"`
    Status                 *string        `json:"status"`
}

func (f *tempFirmwareCampaign) validate() error {
    var errs []string
    if f.Id == nil {
        errs = append(errs, "required field `id` is missing for type `FirmwareCampaign`")
    }
    if f.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `FirmwareCampaign`")
    }
    if f.FirmwareFrom == nil {
        errs = append(errs, "required field `firmwareFrom` is missing for type `FirmwareCampaign`")
    }
    if f.FirmwareTo == nil {
        errs = append(errs, "required field `firmwareTo` is missing for type `FirmwareCampaign`")
    }
    if f.Protocol == nil {
        errs = append(errs, "required field `protocol` is missing for type `FirmwareCampaign`")
    }
    if f.Make == nil {
        errs = append(errs, "required field `make` is missing for type `FirmwareCampaign`")
    }
    if f.Model == nil {
        errs = append(errs, "required field `model` is missing for type `FirmwareCampaign`")
    }
    if f.StartDate == nil {
        errs = append(errs, "required field `startDate` is missing for type `FirmwareCampaign`")
    }
    if f.EndDate == nil {
        errs = append(errs, "required field `endDate` is missing for type `FirmwareCampaign`")
    }
    if f.Status == nil {
        errs = append(errs, "required field `status` is missing for type `FirmwareCampaign`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
