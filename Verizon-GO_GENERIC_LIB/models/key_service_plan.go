/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// KeyServicePlan represents a KeyServicePlan struct.
type KeyServicePlan struct {
    Key                  *string                `json:"key,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for KeyServicePlan,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (k KeyServicePlan) String() string {
    return fmt.Sprintf(
    	"KeyServicePlan[Key=%v, AdditionalProperties=%v]",
    	k.Key, k.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for KeyServicePlan.
// It customizes the JSON marshaling process for KeyServicePlan objects.
func (k KeyServicePlan) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(k.AdditionalProperties,
        "key"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(k.toMap())
}

// toMap converts the KeyServicePlan object to a map representation for JSON marshaling.
func (k KeyServicePlan) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, k.AdditionalProperties)
    if k.Key != nil {
        structMap["key"] = k.Key
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for KeyServicePlan.
// It customizes the JSON unmarshaling process for KeyServicePlan objects.
func (k *KeyServicePlan) UnmarshalJSON(input []byte) error {
    var temp tempKeyServicePlan
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "key")
    if err != nil {
    	return err
    }
    k.AdditionalProperties = additionalProperties
    
    k.Key = temp.Key
    return nil
}

// tempKeyServicePlan is a temporary struct used for validating the fields of KeyServicePlan.
type tempKeyServicePlan  struct {
    Key *string `json:"key,omitempty"`
}
