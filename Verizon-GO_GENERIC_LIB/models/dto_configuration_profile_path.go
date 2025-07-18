/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DtoConfigurationProfilePath represents a DtoConfigurationProfilePath struct.
type DtoConfigurationProfilePath struct {
    // The numeric account name, which must include leading zeros
    AccountName          *string                `json:"accountName,omitempty"`
    Resourceidentifier   *DtoResourceidentifier `json:"resourceidentifier,omitempty"`
    Profile              *DtoProfile            `json:"profile,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DtoConfigurationProfilePath,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoConfigurationProfilePath) String() string {
    return fmt.Sprintf(
    	"DtoConfigurationProfilePath[AccountName=%v, Resourceidentifier=%v, Profile=%v, AdditionalProperties=%v]",
    	d.AccountName, d.Resourceidentifier, d.Profile, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DtoConfigurationProfilePath.
// It customizes the JSON marshaling process for DtoConfigurationProfilePath objects.
func (d DtoConfigurationProfilePath) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "accountName", "resourceidentifier", "profile"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DtoConfigurationProfilePath object to a map representation for JSON marshaling.
func (d DtoConfigurationProfilePath) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    if d.AccountName != nil {
        structMap["accountName"] = d.AccountName
    }
    if d.Resourceidentifier != nil {
        structMap["resourceidentifier"] = d.Resourceidentifier.toMap()
    }
    if d.Profile != nil {
        structMap["profile"] = d.Profile.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoConfigurationProfilePath.
// It customizes the JSON unmarshaling process for DtoConfigurationProfilePath objects.
func (d *DtoConfigurationProfilePath) UnmarshalJSON(input []byte) error {
    var temp tempDtoConfigurationProfilePath
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountName", "resourceidentifier", "profile")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.AccountName = temp.AccountName
    d.Resourceidentifier = temp.Resourceidentifier
    d.Profile = temp.Profile
    return nil
}

// tempDtoConfigurationProfilePath is a temporary struct used for validating the fields of DtoConfigurationProfilePath.
type tempDtoConfigurationProfilePath  struct {
    AccountName        *string                `json:"accountName,omitempty"`
    Resourceidentifier *DtoResourceidentifier `json:"resourceidentifier,omitempty"`
    Profile            *DtoProfile            `json:"profile,omitempty"`
}
