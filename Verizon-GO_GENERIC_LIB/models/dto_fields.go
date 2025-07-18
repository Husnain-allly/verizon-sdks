/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DtoFields represents a DtoFields struct.
// Fields to return needed by search
type DtoFields struct {
    AdditionalProp1 *string `json:"additionalProp1,omitempty"`
    AdditionalProp2 *string `json:"additionalProp2,omitempty"`
    AdditionalProp3 *string `json:"additionalProp3,omitempty"`
}

// String implements the fmt.Stringer interface for DtoFields,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoFields) String() string {
    return fmt.Sprintf(
    	"DtoFields[AdditionalProp1=%v, AdditionalProp2=%v, AdditionalProp3=%v]",
    	d.AdditionalProp1, d.AdditionalProp2, d.AdditionalProp3)
}

// MarshalJSON implements the json.Marshaler interface for DtoFields.
// It customizes the JSON marshaling process for DtoFields objects.
func (d DtoFields) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(d.toMap())
}

// toMap converts the DtoFields object to a map representation for JSON marshaling.
func (d DtoFields) toMap() map[string]any {
    structMap := make(map[string]any)
    if d.AdditionalProp1 != nil {
        structMap["additionalProp1"] = d.AdditionalProp1
    }
    if d.AdditionalProp2 != nil {
        structMap["additionalProp2"] = d.AdditionalProp2
    }
    if d.AdditionalProp3 != nil {
        structMap["additionalProp3"] = d.AdditionalProp3
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoFields.
// It customizes the JSON unmarshaling process for DtoFields objects.
func (d *DtoFields) UnmarshalJSON(input []byte) error {
    var temp tempDtoFields
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    d.AdditionalProp1 = temp.AdditionalProp1
    d.AdditionalProp2 = temp.AdditionalProp2
    d.AdditionalProp3 = temp.AdditionalProp3
    return nil
}

// tempDtoFields is a temporary struct used for validating the fields of DtoFields.
type tempDtoFields  struct {
    AdditionalProp1 *string `json:"additionalProp1,omitempty"`
    AdditionalProp2 *string `json:"additionalProp2,omitempty"`
    AdditionalProp3 *string `json:"additionalProp3,omitempty"`
}
