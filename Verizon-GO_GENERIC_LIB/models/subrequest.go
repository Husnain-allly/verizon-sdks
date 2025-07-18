/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Subrequest represents a Subrequest struct.
type Subrequest struct {
    Ids    *GioDeviceId `json:"ids,omitempty"`
    Status *string      `json:"status,omitempty"`
}

// String implements the fmt.Stringer interface for Subrequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (s Subrequest) String() string {
    return fmt.Sprintf(
    	"Subrequest[Ids=%v, Status=%v]",
    	s.Ids, s.Status)
}

// MarshalJSON implements the json.Marshaler interface for Subrequest.
// It customizes the JSON marshaling process for Subrequest objects.
func (s Subrequest) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(s.toMap())
}

// toMap converts the Subrequest object to a map representation for JSON marshaling.
func (s Subrequest) toMap() map[string]any {
    structMap := make(map[string]any)
    if s.Ids != nil {
        structMap["ids"] = s.Ids.toMap()
    }
    if s.Status != nil {
        structMap["status"] = s.Status
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Subrequest.
// It customizes the JSON unmarshaling process for Subrequest objects.
func (s *Subrequest) UnmarshalJSON(input []byte) error {
    var temp tempSubrequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    s.Ids = temp.Ids
    s.Status = temp.Status
    return nil
}

// tempSubrequest is a temporary struct used for validating the fields of Subrequest.
type tempSubrequest  struct {
    Ids    *GioDeviceId `json:"ids,omitempty"`
    Status *string      `json:"status,omitempty"`
}
