/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// AccountIdentifier represents a AccountIdentifier struct.
// The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
type AccountIdentifier struct {
    Billingaccountid     *string                `json:"billingaccountid,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for AccountIdentifier,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (a AccountIdentifier) String() string {
    return fmt.Sprintf(
    	"AccountIdentifier[Billingaccountid=%v, AdditionalProperties=%v]",
    	a.Billingaccountid, a.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for AccountIdentifier.
// It customizes the JSON marshaling process for AccountIdentifier objects.
func (a AccountIdentifier) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(a.AdditionalProperties,
        "billingaccountid"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(a.toMap())
}

// toMap converts the AccountIdentifier object to a map representation for JSON marshaling.
func (a AccountIdentifier) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, a.AdditionalProperties)
    if a.Billingaccountid != nil {
        structMap["billingaccountid"] = a.Billingaccountid
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for AccountIdentifier.
// It customizes the JSON unmarshaling process for AccountIdentifier objects.
func (a *AccountIdentifier) UnmarshalJSON(input []byte) error {
    var temp tempAccountIdentifier
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "billingaccountid")
    if err != nil {
    	return err
    }
    a.AdditionalProperties = additionalProperties
    
    a.Billingaccountid = temp.Billingaccountid
    return nil
}

// tempAccountIdentifier is a temporary struct used for validating the fields of AccountIdentifier.
type tempAccountIdentifier  struct {
    Billingaccountid *string `json:"billingaccountid,omitempty"`
}
