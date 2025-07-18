/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// AccountGroupShareIndividual1 represents a AccountGroupShareIndividual1 struct.
type AccountGroupShareIndividual1 struct {
    AccountGroupShareIndividual *AccountGroupShareFilterCriteria `json:"accountGroupShareIndividual,omitempty"`
    AdditionalProperties        map[string]interface{}           `json:"_"`
}

// String implements the fmt.Stringer interface for AccountGroupShareIndividual1,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (a AccountGroupShareIndividual1) String() string {
    return fmt.Sprintf(
    	"AccountGroupShareIndividual1[AccountGroupShareIndividual=%v, AdditionalProperties=%v]",
    	a.AccountGroupShareIndividual, a.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for AccountGroupShareIndividual1.
// It customizes the JSON marshaling process for AccountGroupShareIndividual1 objects.
func (a AccountGroupShareIndividual1) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(a.AdditionalProperties,
        "accountGroupShareIndividual"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(a.toMap())
}

// toMap converts the AccountGroupShareIndividual1 object to a map representation for JSON marshaling.
func (a AccountGroupShareIndividual1) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, a.AdditionalProperties)
    if a.AccountGroupShareIndividual != nil {
        structMap["accountGroupShareIndividual"] = a.AccountGroupShareIndividual.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for AccountGroupShareIndividual1.
// It customizes the JSON unmarshaling process for AccountGroupShareIndividual1 objects.
func (a *AccountGroupShareIndividual1) UnmarshalJSON(input []byte) error {
    var temp tempAccountGroupShareIndividual1
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountGroupShareIndividual")
    if err != nil {
    	return err
    }
    a.AdditionalProperties = additionalProperties
    
    a.AccountGroupShareIndividual = temp.AccountGroupShareIndividual
    return nil
}

// tempAccountGroupShareIndividual1 is a temporary struct used for validating the fields of AccountGroupShareIndividual1.
type tempAccountGroupShareIndividual1  struct {
    AccountGroupShareIndividual *AccountGroupShareFilterCriteria `json:"accountGroupShareIndividual,omitempty"`
}
