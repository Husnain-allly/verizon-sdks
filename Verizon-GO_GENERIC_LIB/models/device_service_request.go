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

// DeviceServiceRequest represents a DeviceServiceRequest struct.
// Device information.
type DeviceServiceRequest struct {
    // International Mobile Equipment Identifier. The unique ID of a device.
    Imei                 string                 `json:"imei"`
    // Set to Enable (true) or Disable (false).
    BullseyeEnable       bool                   `json:"BullseyeEnable"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DeviceServiceRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DeviceServiceRequest) String() string {
    return fmt.Sprintf(
    	"DeviceServiceRequest[Imei=%v, BullseyeEnable=%v, AdditionalProperties=%v]",
    	d.Imei, d.BullseyeEnable, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DeviceServiceRequest.
// It customizes the JSON marshaling process for DeviceServiceRequest objects.
func (d DeviceServiceRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "imei", "BullseyeEnable"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DeviceServiceRequest object to a map representation for JSON marshaling.
func (d DeviceServiceRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    structMap["imei"] = d.Imei
    structMap["BullseyeEnable"] = d.BullseyeEnable
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DeviceServiceRequest.
// It customizes the JSON unmarshaling process for DeviceServiceRequest objects.
func (d *DeviceServiceRequest) UnmarshalJSON(input []byte) error {
    var temp tempDeviceServiceRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "imei", "BullseyeEnable")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.Imei = *temp.Imei
    d.BullseyeEnable = *temp.BullseyeEnable
    return nil
}

// tempDeviceServiceRequest is a temporary struct used for validating the fields of DeviceServiceRequest.
type tempDeviceServiceRequest  struct {
    Imei           *string `json:"imei"`
    BullseyeEnable *bool   `json:"BullseyeEnable"`
}

func (d *tempDeviceServiceRequest) validate() error {
    var errs []string
    if d.Imei == nil {
        errs = append(errs, "required field `imei` is missing for type `DeviceServiceRequest`")
    }
    if d.BullseyeEnable == nil {
        errs = append(errs, "required field `BullseyeEnable` is missing for type `DeviceServiceRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
