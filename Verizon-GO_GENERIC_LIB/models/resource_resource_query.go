/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// ResourceResourceQuery represents a ResourceResourceQuery struct.
type ResourceResourceQuery struct {
    Filter *Devicepropertyfilter `json:"filter,omitempty"`
}

// String implements the fmt.Stringer interface for ResourceResourceQuery,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (r ResourceResourceQuery) String() string {
    return fmt.Sprintf(
    	"ResourceResourceQuery[Filter=%v]",
    	r.Filter)
}

// MarshalJSON implements the json.Marshaler interface for ResourceResourceQuery.
// It customizes the JSON marshaling process for ResourceResourceQuery objects.
func (r ResourceResourceQuery) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(r.toMap())
}

// toMap converts the ResourceResourceQuery object to a map representation for JSON marshaling.
func (r ResourceResourceQuery) toMap() map[string]any {
    structMap := make(map[string]any)
    if r.Filter != nil {
        structMap["filter"] = r.Filter.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ResourceResourceQuery.
// It customizes the JSON unmarshaling process for ResourceResourceQuery objects.
func (r *ResourceResourceQuery) UnmarshalJSON(input []byte) error {
    var temp tempResourceResourceQuery
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    r.Filter = temp.Filter
    return nil
}

// tempResourceResourceQuery is a temporary struct used for validating the fields of ResourceResourceQuery.
type tempResourceResourceQuery  struct {
    Filter *Devicepropertyfilter `json:"filter,omitempty"`
}
