/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DtoConfigurationProfileDelete represents a DtoConfigurationProfileDelete struct.
type DtoConfigurationProfileDelete struct {
    // The numeric account name, which must include leading zeros
    AccountName          *string                `json:"accountName,omitempty"`
    Resourceidentifier   *DtoResourceidentifier `json:"resourceidentifier,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DtoConfigurationProfileDelete,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoConfigurationProfileDelete) String() string {
    return fmt.Sprintf(
    	"DtoConfigurationProfileDelete[AccountName=%v, Resourceidentifier=%v, AdditionalProperties=%v]",
    	d.AccountName, d.Resourceidentifier, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DtoConfigurationProfileDelete.
// It customizes the JSON marshaling process for DtoConfigurationProfileDelete objects.
func (d DtoConfigurationProfileDelete) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "accountName", "resourceidentifier"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DtoConfigurationProfileDelete object to a map representation for JSON marshaling.
func (d DtoConfigurationProfileDelete) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    if d.AccountName != nil {
        structMap["accountName"] = d.AccountName
    }
    if d.Resourceidentifier != nil {
        structMap["resourceidentifier"] = d.Resourceidentifier.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoConfigurationProfileDelete.
// It customizes the JSON unmarshaling process for DtoConfigurationProfileDelete objects.
func (d *DtoConfigurationProfileDelete) UnmarshalJSON(input []byte) error {
    var temp tempDtoConfigurationProfileDelete
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountName", "resourceidentifier")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.AccountName = temp.AccountName
    d.Resourceidentifier = temp.Resourceidentifier
    return nil
}

// tempDtoConfigurationProfileDelete is a temporary struct used for validating the fields of DtoConfigurationProfileDelete.
type tempDtoConfigurationProfileDelete  struct {
    AccountName        *string                `json:"accountName,omitempty"`
    Resourceidentifier *DtoResourceidentifier `json:"resourceidentifier,omitempty"`
}
