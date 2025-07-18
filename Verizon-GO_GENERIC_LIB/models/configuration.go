/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Configuration represents a Configuration struct.
// List of the field names and values to set.
type Configuration struct {
    Frequency            *string                `json:"frequency,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Configuration,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c Configuration) String() string {
    return fmt.Sprintf(
    	"Configuration[Frequency=%v, AdditionalProperties=%v]",
    	c.Frequency, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Configuration.
// It customizes the JSON marshaling process for Configuration objects.
func (c Configuration) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "frequency"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the Configuration object to a map representation for JSON marshaling.
func (c Configuration) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    if c.Frequency != nil {
        structMap["frequency"] = c.Frequency
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Configuration.
// It customizes the JSON unmarshaling process for Configuration objects.
func (c *Configuration) UnmarshalJSON(input []byte) error {
    var temp tempConfiguration
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "frequency")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.Frequency = temp.Frequency
    return nil
}

// tempConfiguration is a temporary struct used for validating the fields of Configuration.
type tempConfiguration  struct {
    Frequency *string `json:"frequency,omitempty"`
}
