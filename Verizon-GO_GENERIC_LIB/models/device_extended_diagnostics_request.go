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

// DeviceExtendedDiagnosticsRequest represents a DeviceExtendedDiagnosticsRequest struct.
// Request for obtaining device extended diagnostics.
type DeviceExtendedDiagnosticsRequest struct {
    // The Verizon billing account that the device belongs to. An account name is usually numeric, and must include any leading zeros.
    AccountName          string                 `json:"accountName"`
    // The device for which you want diagnostic information, specified by the device's MDN.
    DeviceList           []DeviceId             `json:"deviceList"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DeviceExtendedDiagnosticsRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DeviceExtendedDiagnosticsRequest) String() string {
    return fmt.Sprintf(
    	"DeviceExtendedDiagnosticsRequest[AccountName=%v, DeviceList=%v, AdditionalProperties=%v]",
    	d.AccountName, d.DeviceList, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DeviceExtendedDiagnosticsRequest.
// It customizes the JSON marshaling process for DeviceExtendedDiagnosticsRequest objects.
func (d DeviceExtendedDiagnosticsRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "accountName", "deviceList"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DeviceExtendedDiagnosticsRequest object to a map representation for JSON marshaling.
func (d DeviceExtendedDiagnosticsRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    structMap["accountName"] = d.AccountName
    structMap["deviceList"] = d.DeviceList
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DeviceExtendedDiagnosticsRequest.
// It customizes the JSON unmarshaling process for DeviceExtendedDiagnosticsRequest objects.
func (d *DeviceExtendedDiagnosticsRequest) UnmarshalJSON(input []byte) error {
    var temp tempDeviceExtendedDiagnosticsRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountName", "deviceList")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.AccountName = *temp.AccountName
    d.DeviceList = *temp.DeviceList
    return nil
}

// tempDeviceExtendedDiagnosticsRequest is a temporary struct used for validating the fields of DeviceExtendedDiagnosticsRequest.
type tempDeviceExtendedDiagnosticsRequest  struct {
    AccountName *string     `json:"accountName"`
    DeviceList  *[]DeviceId `json:"deviceList"`
}

func (d *tempDeviceExtendedDiagnosticsRequest) validate() error {
    var errs []string
    if d.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `DeviceExtendedDiagnosticsRequest`")
    }
    if d.DeviceList == nil {
        errs = append(errs, "required field `deviceList` is missing for type `DeviceExtendedDiagnosticsRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
