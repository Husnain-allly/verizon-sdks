/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DevicePrlListRequest represents a DevicePrlListRequest struct.
// Requests the current PRL (Preferred Roaming List) version for 2G or 3G devices, which can help determine which devices need a PRL update. (4G and GSM devices do not have a PRL.).
type DevicePrlListRequest struct {
    // The devices for which you want the PRL version, specified by device identifier. You only need to provide one identifier per device. Do not use any of the other parameters if you specify device IDs.
    DeviceIds            []DeviceId             `json:"deviceIds,omitempty"`
    // The name of a billing account. This parameter is only required if you are passing groupName and the UWS account used for the current API session has access to multiple billing accounts, because the same device group name can exist in multiple accounts.An account name is usually numeric, and must include any leading zeros.
    AccountName          *string                `json:"accountName,omitempty"`
    // The names and values of custom fields, if you want to only include devices that have matching custom fields.
    CustomFields         []CustomFields         `json:"customFields,omitempty"`
    // The name of a device group, if you want to only include devices in that group.
    GroupName            *string                `json:"groupName,omitempty"`
    // The name of a service plan, if you want to only include devices that have that service plan.
    ServicePlan          *string                `json:"servicePlan,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DevicePrlListRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DevicePrlListRequest) String() string {
    return fmt.Sprintf(
    	"DevicePrlListRequest[DeviceIds=%v, AccountName=%v, CustomFields=%v, GroupName=%v, ServicePlan=%v, AdditionalProperties=%v]",
    	d.DeviceIds, d.AccountName, d.CustomFields, d.GroupName, d.ServicePlan, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DevicePrlListRequest.
// It customizes the JSON marshaling process for DevicePrlListRequest objects.
func (d DevicePrlListRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "deviceIds", "accountName", "customFields", "groupName", "servicePlan"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DevicePrlListRequest object to a map representation for JSON marshaling.
func (d DevicePrlListRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    if d.DeviceIds != nil {
        structMap["deviceIds"] = d.DeviceIds
    }
    if d.AccountName != nil {
        structMap["accountName"] = d.AccountName
    }
    if d.CustomFields != nil {
        structMap["customFields"] = d.CustomFields
    }
    if d.GroupName != nil {
        structMap["groupName"] = d.GroupName
    }
    if d.ServicePlan != nil {
        structMap["servicePlan"] = d.ServicePlan
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DevicePrlListRequest.
// It customizes the JSON unmarshaling process for DevicePrlListRequest objects.
func (d *DevicePrlListRequest) UnmarshalJSON(input []byte) error {
    var temp tempDevicePrlListRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "deviceIds", "accountName", "customFields", "groupName", "servicePlan")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.DeviceIds = temp.DeviceIds
    d.AccountName = temp.AccountName
    d.CustomFields = temp.CustomFields
    d.GroupName = temp.GroupName
    d.ServicePlan = temp.ServicePlan
    return nil
}

// tempDevicePrlListRequest is a temporary struct used for validating the fields of DevicePrlListRequest.
type tempDevicePrlListRequest  struct {
    DeviceIds    []DeviceId     `json:"deviceIds,omitempty"`
    AccountName  *string        `json:"accountName,omitempty"`
    CustomFields []CustomFields `json:"customFields,omitempty"`
    GroupName    *string        `json:"groupName,omitempty"`
    ServicePlan  *string        `json:"servicePlan,omitempty"`
}
