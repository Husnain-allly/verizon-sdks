/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// SearchDeviceByPropertyResponseList represents a SearchDeviceByPropertyResponseList struct.
// A success response includes an array of all matching devices.
type SearchDeviceByPropertyResponseList struct {
    DeviceProperty       []SearchDeviceByPropertyResponse `json:"DeviceProperty,omitempty"`
    AdditionalProperties map[string]interface{}           `json:"_"`
}

// String implements the fmt.Stringer interface for SearchDeviceByPropertyResponseList,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (s SearchDeviceByPropertyResponseList) String() string {
    return fmt.Sprintf(
    	"SearchDeviceByPropertyResponseList[DeviceProperty=%v, AdditionalProperties=%v]",
    	s.DeviceProperty, s.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for SearchDeviceByPropertyResponseList.
// It customizes the JSON marshaling process for SearchDeviceByPropertyResponseList objects.
func (s SearchDeviceByPropertyResponseList) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(s.AdditionalProperties,
        "DeviceProperty"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(s.toMap())
}

// toMap converts the SearchDeviceByPropertyResponseList object to a map representation for JSON marshaling.
func (s SearchDeviceByPropertyResponseList) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, s.AdditionalProperties)
    if s.DeviceProperty != nil {
        structMap["DeviceProperty"] = s.DeviceProperty
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for SearchDeviceByPropertyResponseList.
// It customizes the JSON unmarshaling process for SearchDeviceByPropertyResponseList objects.
func (s *SearchDeviceByPropertyResponseList) UnmarshalJSON(input []byte) error {
    var temp tempSearchDeviceByPropertyResponseList
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "DeviceProperty")
    if err != nil {
    	return err
    }
    s.AdditionalProperties = additionalProperties
    
    s.DeviceProperty = temp.DeviceProperty
    return nil
}

// tempSearchDeviceByPropertyResponseList is a temporary struct used for validating the fields of SearchDeviceByPropertyResponseList.
type tempSearchDeviceByPropertyResponseList  struct {
    DeviceProperty []SearchDeviceByPropertyResponse `json:"DeviceProperty,omitempty"`
}
