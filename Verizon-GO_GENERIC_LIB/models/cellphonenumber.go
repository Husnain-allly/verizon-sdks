/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Cellphonenumber represents a Cellphonenumber struct.
type Cellphonenumber struct {
    Number               *string                `json:"number,omitempty"`
    Carrier              *string                `json:"carrier,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Cellphonenumber,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c Cellphonenumber) String() string {
    return fmt.Sprintf(
    	"Cellphonenumber[Number=%v, Carrier=%v, AdditionalProperties=%v]",
    	c.Number, c.Carrier, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Cellphonenumber.
// It customizes the JSON marshaling process for Cellphonenumber objects.
func (c Cellphonenumber) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "number", "carrier"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the Cellphonenumber object to a map representation for JSON marshaling.
func (c Cellphonenumber) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    if c.Number != nil {
        structMap["number"] = c.Number
    }
    if c.Carrier != nil {
        structMap["carrier"] = c.Carrier
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Cellphonenumber.
// It customizes the JSON unmarshaling process for Cellphonenumber objects.
func (c *Cellphonenumber) UnmarshalJSON(input []byte) error {
    var temp tempCellphonenumber
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "number", "carrier")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.Number = temp.Number
    c.Carrier = temp.Carrier
    return nil
}

// tempCellphonenumber is a temporary struct used for validating the fields of Cellphonenumber.
type tempCellphonenumber  struct {
    Number  *string `json:"number,omitempty"`
    Carrier *string `json:"carrier,omitempty"`
}
