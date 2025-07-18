/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DtoListNotificationGroupRequest represents a DtoListNotificationGroupRequest struct.
type DtoListNotificationGroupRequest struct {
    // The numeric account name, which must include leading zeros
    Accountname *string    `json:"accountname,omitempty"`
    Filter      *DtoFilter `json:"filter,omitempty"`
}

// String implements the fmt.Stringer interface for DtoListNotificationGroupRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoListNotificationGroupRequest) String() string {
    return fmt.Sprintf(
    	"DtoListNotificationGroupRequest[Accountname=%v, Filter=%v]",
    	d.Accountname, d.Filter)
}

// MarshalJSON implements the json.Marshaler interface for DtoListNotificationGroupRequest.
// It customizes the JSON marshaling process for DtoListNotificationGroupRequest objects.
func (d DtoListNotificationGroupRequest) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(d.toMap())
}

// toMap converts the DtoListNotificationGroupRequest object to a map representation for JSON marshaling.
func (d DtoListNotificationGroupRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    if d.Accountname != nil {
        structMap["accountname"] = d.Accountname
    }
    if d.Filter != nil {
        structMap["filter"] = d.Filter.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoListNotificationGroupRequest.
// It customizes the JSON unmarshaling process for DtoListNotificationGroupRequest objects.
func (d *DtoListNotificationGroupRequest) UnmarshalJSON(input []byte) error {
    var temp tempDtoListNotificationGroupRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    d.Accountname = temp.Accountname
    d.Filter = temp.Filter
    return nil
}

// tempDtoListNotificationGroupRequest is a temporary struct used for validating the fields of DtoListNotificationGroupRequest.
type tempDtoListNotificationGroupRequest  struct {
    Accountname *string    `json:"accountname,omitempty"`
    Filter      *DtoFilter `json:"filter,omitempty"`
}
