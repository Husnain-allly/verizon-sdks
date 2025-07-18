/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DeviceUpgradeHistory represents a DeviceUpgradeHistory struct.
// Firmware upgrade information.
type DeviceUpgradeHistory struct {
    // Device IMEI.
    DeviceId             *string                `json:"deviceId,omitempty"`
    // The unique identifier for the upgrade.
    Id                   *string                `json:"id,omitempty"`
    // The name (number) of the billing account that the device belongs to.
    AccountName          *string                `json:"accountName,omitempty"`
    // The firmware version that was on the device before the upgrade.
    FirmwareFrom         *string                `json:"firmwareFrom,omitempty"`
    // The name of the firmware version that was on the device after the upgrade.
    FirmwareTo           *string                `json:"firmwareTo,omitempty"`
    // The date of the upgrade.
    StartDate            *string                `json:"startDate,omitempty"`
    // The date and time that the upgrade actually started for this device.
    UpgradeStartTime     *string                `json:"upgradeStartTime,omitempty"`
    // The status of the upgrade for this device.
    Status               *string                `json:"status,omitempty"`
    // More information about the status.
    Reason               *string                `json:"reason,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DeviceUpgradeHistory,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DeviceUpgradeHistory) String() string {
    return fmt.Sprintf(
    	"DeviceUpgradeHistory[DeviceId=%v, Id=%v, AccountName=%v, FirmwareFrom=%v, FirmwareTo=%v, StartDate=%v, UpgradeStartTime=%v, Status=%v, Reason=%v, AdditionalProperties=%v]",
    	d.DeviceId, d.Id, d.AccountName, d.FirmwareFrom, d.FirmwareTo, d.StartDate, d.UpgradeStartTime, d.Status, d.Reason, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DeviceUpgradeHistory.
// It customizes the JSON marshaling process for DeviceUpgradeHistory objects.
func (d DeviceUpgradeHistory) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "deviceId", "id", "accountName", "firmwareFrom", "firmwareTo", "startDate", "upgradeStartTime", "status", "reason"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DeviceUpgradeHistory object to a map representation for JSON marshaling.
func (d DeviceUpgradeHistory) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    if d.DeviceId != nil {
        structMap["deviceId"] = d.DeviceId
    }
    if d.Id != nil {
        structMap["id"] = d.Id
    }
    if d.AccountName != nil {
        structMap["accountName"] = d.AccountName
    }
    if d.FirmwareFrom != nil {
        structMap["firmwareFrom"] = d.FirmwareFrom
    }
    if d.FirmwareTo != nil {
        structMap["firmwareTo"] = d.FirmwareTo
    }
    if d.StartDate != nil {
        structMap["startDate"] = d.StartDate
    }
    if d.UpgradeStartTime != nil {
        structMap["upgradeStartTime"] = d.UpgradeStartTime
    }
    if d.Status != nil {
        structMap["status"] = d.Status
    }
    if d.Reason != nil {
        structMap["reason"] = d.Reason
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DeviceUpgradeHistory.
// It customizes the JSON unmarshaling process for DeviceUpgradeHistory objects.
func (d *DeviceUpgradeHistory) UnmarshalJSON(input []byte) error {
    var temp tempDeviceUpgradeHistory
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "deviceId", "id", "accountName", "firmwareFrom", "firmwareTo", "startDate", "upgradeStartTime", "status", "reason")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.DeviceId = temp.DeviceId
    d.Id = temp.Id
    d.AccountName = temp.AccountName
    d.FirmwareFrom = temp.FirmwareFrom
    d.FirmwareTo = temp.FirmwareTo
    d.StartDate = temp.StartDate
    d.UpgradeStartTime = temp.UpgradeStartTime
    d.Status = temp.Status
    d.Reason = temp.Reason
    return nil
}

// tempDeviceUpgradeHistory is a temporary struct used for validating the fields of DeviceUpgradeHistory.
type tempDeviceUpgradeHistory  struct {
    DeviceId         *string `json:"deviceId,omitempty"`
    Id               *string `json:"id,omitempty"`
    AccountName      *string `json:"accountName,omitempty"`
    FirmwareFrom     *string `json:"firmwareFrom,omitempty"`
    FirmwareTo       *string `json:"firmwareTo,omitempty"`
    StartDate        *string `json:"startDate,omitempty"`
    UpgradeStartTime *string `json:"upgradeStartTime,omitempty"`
    Status           *string `json:"status,omitempty"`
    Reason           *string `json:"reason,omitempty"`
}
