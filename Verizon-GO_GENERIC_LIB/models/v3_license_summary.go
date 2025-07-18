/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "errors"
    "fmt"
    "strings"
)

// V3LicenseSummary represents a V3LicenseSummary struct.
// Information for FOTA licenses assigned to devices.
type V3LicenseSummary struct {
    // Account identifier.
    AccountName          string                 `json:"accountName"`
    // Total FOTA license count.
    TotalLicenses        *int                   `json:"totalLicenses,omitempty"`
    // Assigned FOTA license count.
    AssignedLicenses     int                    `json:"assignedLicenses"`
    // True if there are more devices to retrieve.
    HasMoreData          bool                   `json:"hasMoreData"`
    // Last seen device identifier.
    LastSeenDeviceId     *string                `json:"lastSeenDeviceId,omitempty"`
    // Maximum page size.
    MaxPageSize          int                    `json:"maxPageSize"`
    // Device IMEI list.
    DeviceList           []V3LicenseDevice      `json:"deviceList,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for V3LicenseSummary,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (v V3LicenseSummary) String() string {
    return fmt.Sprintf(
    	"V3LicenseSummary[AccountName=%v, TotalLicenses=%v, AssignedLicenses=%v, HasMoreData=%v, LastSeenDeviceId=%v, MaxPageSize=%v, DeviceList=%v, AdditionalProperties=%v]",
    	v.AccountName, v.TotalLicenses, v.AssignedLicenses, v.HasMoreData, v.LastSeenDeviceId, v.MaxPageSize, v.DeviceList, v.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for V3LicenseSummary.
// It customizes the JSON marshaling process for V3LicenseSummary objects.
func (v V3LicenseSummary) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(v.AdditionalProperties,
        "accountName", "totalLicenses", "assignedLicenses", "hasMoreData", "lastSeenDeviceId", "maxPageSize", "deviceList"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(v.toMap())
}

// toMap converts the V3LicenseSummary object to a map representation for JSON marshaling.
func (v V3LicenseSummary) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, v.AdditionalProperties)
    structMap["accountName"] = v.AccountName
    if v.TotalLicenses != nil {
        structMap["totalLicenses"] = v.TotalLicenses
    }
    structMap["assignedLicenses"] = v.AssignedLicenses
    structMap["hasMoreData"] = v.HasMoreData
    if v.LastSeenDeviceId != nil {
        structMap["lastSeenDeviceId"] = v.LastSeenDeviceId
    }
    structMap["maxPageSize"] = v.MaxPageSize
    if v.DeviceList != nil {
        structMap["deviceList"] = v.DeviceList
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for V3LicenseSummary.
// It customizes the JSON unmarshaling process for V3LicenseSummary objects.
func (v *V3LicenseSummary) UnmarshalJSON(input []byte) error {
    var temp tempV3LicenseSummary
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountName", "totalLicenses", "assignedLicenses", "hasMoreData", "lastSeenDeviceId", "maxPageSize", "deviceList")
    if err != nil {
    	return err
    }
    v.AdditionalProperties = additionalProperties
    
    v.AccountName = *temp.AccountName
    v.TotalLicenses = temp.TotalLicenses
    v.AssignedLicenses = *temp.AssignedLicenses
    v.HasMoreData = *temp.HasMoreData
    v.LastSeenDeviceId = temp.LastSeenDeviceId
    v.MaxPageSize = *temp.MaxPageSize
    v.DeviceList = temp.DeviceList
    return nil
}

// tempV3LicenseSummary is a temporary struct used for validating the fields of V3LicenseSummary.
type tempV3LicenseSummary  struct {
    AccountName      *string           `json:"accountName"`
    TotalLicenses    *int              `json:"totalLicenses,omitempty"`
    AssignedLicenses *int              `json:"assignedLicenses"`
    HasMoreData      *bool             `json:"hasMoreData"`
    LastSeenDeviceId *string           `json:"lastSeenDeviceId,omitempty"`
    MaxPageSize      *int              `json:"maxPageSize"`
    DeviceList       []V3LicenseDevice `json:"deviceList,omitempty"`
}

func (v *tempV3LicenseSummary) validate() error {
    var errs []string
    if v.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `V3LicenseSummary`")
    }
    if v.AssignedLicenses == nil {
        errs = append(errs, "required field `assignedLicenses` is missing for type `V3LicenseSummary`")
    }
    if v.HasMoreData == nil {
        errs = append(errs, "required field `hasMoreData` is missing for type `V3LicenseSummary`")
    }
    if v.MaxPageSize == nil {
        errs = append(errs, "required field `maxPageSize` is missing for type `V3LicenseSummary`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
