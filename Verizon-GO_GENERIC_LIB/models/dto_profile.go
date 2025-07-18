/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DtoProfile represents a DtoProfile struct.
type DtoProfile struct {
    // profile kind
    Kind                 *string                `json:"kind,omitempty"`
    // The resource version
    Version              *string                `json:"version,omitempty"`
    // device model id
    Modelid              *string                `json:"modelid,omitempty"`
    // profile name
    Name                 *string                `json:"name,omitempty"`
    Configuration        *interface{}           `json:"configuration,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DtoProfile,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoProfile) String() string {
    return fmt.Sprintf(
    	"DtoProfile[Kind=%v, Version=%v, Modelid=%v, Name=%v, Configuration=%v, AdditionalProperties=%v]",
    	d.Kind, d.Version, d.Modelid, d.Name, d.Configuration, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DtoProfile.
// It customizes the JSON marshaling process for DtoProfile objects.
func (d DtoProfile) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "kind", "version", "modelid", "name", "configuration"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DtoProfile object to a map representation for JSON marshaling.
func (d DtoProfile) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    if d.Kind != nil {
        structMap["kind"] = d.Kind
    }
    if d.Version != nil {
        structMap["version"] = d.Version
    }
    if d.Modelid != nil {
        structMap["modelid"] = d.Modelid
    }
    if d.Name != nil {
        structMap["name"] = d.Name
    }
    if d.Configuration != nil {
        structMap["configuration"] = d.Configuration
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoProfile.
// It customizes the JSON unmarshaling process for DtoProfile objects.
func (d *DtoProfile) UnmarshalJSON(input []byte) error {
    var temp tempDtoProfile
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "kind", "version", "modelid", "name", "configuration")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.Kind = temp.Kind
    d.Version = temp.Version
    d.Modelid = temp.Modelid
    d.Name = temp.Name
    d.Configuration = temp.Configuration
    return nil
}

// tempDtoProfile is a temporary struct used for validating the fields of DtoProfile.
type tempDtoProfile  struct {
    Kind          *string      `json:"kind,omitempty"`
    Version       *string      `json:"version,omitempty"`
    Modelid       *string      `json:"modelid,omitempty"`
    Name          *string      `json:"name,omitempty"`
    Configuration *interface{} `json:"configuration,omitempty"`
}
