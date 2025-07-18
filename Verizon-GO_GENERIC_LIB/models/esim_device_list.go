/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// EsimDeviceList represents a EsimDeviceList struct.
type EsimDeviceList struct {
    DeviceIds []DeviceId2 `json:"deviceIds,omitempty"`
}

// String implements the fmt.Stringer interface for EsimDeviceList,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (e EsimDeviceList) String() string {
    return fmt.Sprintf(
    	"EsimDeviceList[DeviceIds=%v]",
    	e.DeviceIds)
}

// MarshalJSON implements the json.Marshaler interface for EsimDeviceList.
// It customizes the JSON marshaling process for EsimDeviceList objects.
func (e EsimDeviceList) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(e.toMap())
}

// toMap converts the EsimDeviceList object to a map representation for JSON marshaling.
func (e EsimDeviceList) toMap() map[string]any {
    structMap := make(map[string]any)
    if e.DeviceIds != nil {
        structMap["deviceIds"] = e.DeviceIds
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for EsimDeviceList.
// It customizes the JSON unmarshaling process for EsimDeviceList objects.
func (e *EsimDeviceList) UnmarshalJSON(input []byte) error {
    var temp tempEsimDeviceList
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    e.DeviceIds = temp.DeviceIds
    return nil
}

// tempEsimDeviceList is a temporary struct used for validating the fields of EsimDeviceList.
type tempEsimDeviceList  struct {
    DeviceIds []DeviceId2 `json:"deviceIds,omitempty"`
}
