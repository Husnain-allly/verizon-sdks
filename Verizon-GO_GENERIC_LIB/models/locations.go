/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Locations represents a Locations struct.
// Location details.
type Locations struct {
    AddressList []AddressItem `json:"addressList,omitempty"`
}

// String implements the fmt.Stringer interface for Locations,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (l Locations) String() string {
    return fmt.Sprintf(
    	"Locations[AddressList=%v]",
    	l.AddressList)
}

// MarshalJSON implements the json.Marshaler interface for Locations.
// It customizes the JSON marshaling process for Locations objects.
func (l Locations) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(l.toMap())
}

// toMap converts the Locations object to a map representation for JSON marshaling.
func (l Locations) toMap() map[string]any {
    structMap := make(map[string]any)
    if l.AddressList != nil {
        structMap["addressList"] = l.AddressList
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Locations.
// It customizes the JSON unmarshaling process for Locations objects.
func (l *Locations) UnmarshalJSON(input []byte) error {
    var temp tempLocations
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    l.AddressList = temp.AddressList
    return nil
}

// tempLocations is a temporary struct used for validating the fields of Locations.
type tempLocations  struct {
    AddressList []AddressItem `json:"addressList,omitempty"`
}
