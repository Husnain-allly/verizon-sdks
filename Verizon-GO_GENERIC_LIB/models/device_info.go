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

// DeviceInfo represents a DeviceInfo struct.
// The devices that you want to locate. The array cannot contain more than 20 devices.
type DeviceInfo struct {
    // Device identifier.
    Id                   string                 `json:"id"`
    // Device identifier kind.
    Kind                 string                 `json:"kind"`
    // Device MDN.
    Mdn                  string                 `json:"mdn"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DeviceInfo,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DeviceInfo) String() string {
    return fmt.Sprintf(
    	"DeviceInfo[Id=%v, Kind=%v, Mdn=%v, AdditionalProperties=%v]",
    	d.Id, d.Kind, d.Mdn, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DeviceInfo.
// It customizes the JSON marshaling process for DeviceInfo objects.
func (d DeviceInfo) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "id", "kind", "mdn"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DeviceInfo object to a map representation for JSON marshaling.
func (d DeviceInfo) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    structMap["id"] = d.Id
    structMap["kind"] = d.Kind
    structMap["mdn"] = d.Mdn
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DeviceInfo.
// It customizes the JSON unmarshaling process for DeviceInfo objects.
func (d *DeviceInfo) UnmarshalJSON(input []byte) error {
    var temp tempDeviceInfo
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "id", "kind", "mdn")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.Id = *temp.Id
    d.Kind = *temp.Kind
    d.Mdn = *temp.Mdn
    return nil
}

// tempDeviceInfo is a temporary struct used for validating the fields of DeviceInfo.
type tempDeviceInfo  struct {
    Id   *string `json:"id"`
    Kind *string `json:"kind"`
    Mdn  *string `json:"mdn"`
}

func (d *tempDeviceInfo) validate() error {
    var errs []string
    if d.Id == nil {
        errs = append(errs, "required field `id` is missing for type `DeviceInfo`")
    }
    if d.Kind == nil {
        errs = append(errs, "required field `kind` is missing for type `DeviceInfo`")
    }
    if d.Mdn == nil {
        errs = append(errs, "required field `mdn` is missing for type `DeviceInfo`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
