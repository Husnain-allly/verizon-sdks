/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Payload represents a Payload struct.
type Payload struct {
    Addsensor            *ResourceOnBoardSensor `json:"addsensor,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Payload,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (p Payload) String() string {
    return fmt.Sprintf(
    	"Payload[Addsensor=%v, AdditionalProperties=%v]",
    	p.Addsensor, p.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Payload.
// It customizes the JSON marshaling process for Payload objects.
func (p Payload) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(p.AdditionalProperties,
        "addsensor"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(p.toMap())
}

// toMap converts the Payload object to a map representation for JSON marshaling.
func (p Payload) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, p.AdditionalProperties)
    if p.Addsensor != nil {
        structMap["addsensor"] = p.Addsensor.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Payload.
// It customizes the JSON unmarshaling process for Payload objects.
func (p *Payload) UnmarshalJSON(input []byte) error {
    var temp tempPayload
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "addsensor")
    if err != nil {
    	return err
    }
    p.AdditionalProperties = additionalProperties
    
    p.Addsensor = temp.Addsensor
    return nil
}

// tempPayload is a temporary struct used for validating the fields of Payload.
type tempPayload  struct {
    Addsensor *ResourceOnBoardSensor `json:"addsensor,omitempty"`
}
