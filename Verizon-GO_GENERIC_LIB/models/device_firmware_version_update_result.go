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

// DeviceFirmwareVersionUpdateResult represents a DeviceFirmwareVersionUpdateResult struct.
// Device firmware version update response.
type DeviceFirmwareVersionUpdateResult struct {
    // Account identifier.
    AccountName          string                 `json:"accountName"`
    // Request identifier.
    RequestId            string                 `json:"requestId"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DeviceFirmwareVersionUpdateResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DeviceFirmwareVersionUpdateResult) String() string {
    return fmt.Sprintf(
    	"DeviceFirmwareVersionUpdateResult[AccountName=%v, RequestId=%v, AdditionalProperties=%v]",
    	d.AccountName, d.RequestId, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DeviceFirmwareVersionUpdateResult.
// It customizes the JSON marshaling process for DeviceFirmwareVersionUpdateResult objects.
func (d DeviceFirmwareVersionUpdateResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "accountName", "requestId"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DeviceFirmwareVersionUpdateResult object to a map representation for JSON marshaling.
func (d DeviceFirmwareVersionUpdateResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    structMap["accountName"] = d.AccountName
    structMap["requestId"] = d.RequestId
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DeviceFirmwareVersionUpdateResult.
// It customizes the JSON unmarshaling process for DeviceFirmwareVersionUpdateResult objects.
func (d *DeviceFirmwareVersionUpdateResult) UnmarshalJSON(input []byte) error {
    var temp tempDeviceFirmwareVersionUpdateResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountName", "requestId")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.AccountName = *temp.AccountName
    d.RequestId = *temp.RequestId
    return nil
}

// tempDeviceFirmwareVersionUpdateResult is a temporary struct used for validating the fields of DeviceFirmwareVersionUpdateResult.
type tempDeviceFirmwareVersionUpdateResult  struct {
    AccountName *string `json:"accountName"`
    RequestId   *string `json:"requestId"`
}

func (d *tempDeviceFirmwareVersionUpdateResult) validate() error {
    var errs []string
    if d.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `DeviceFirmwareVersionUpdateResult`")
    }
    if d.RequestId == nil {
        errs = append(errs, "required field `requestId` is missing for type `DeviceFirmwareVersionUpdateResult`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
