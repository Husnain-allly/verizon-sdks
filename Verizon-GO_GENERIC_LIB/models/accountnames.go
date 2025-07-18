/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Accountnames represents a Accountnames struct.
type Accountnames struct {
    AccountNameList      []string               `json:"accountNameList,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Accountnames,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (a Accountnames) String() string {
    return fmt.Sprintf(
    	"Accountnames[AccountNameList=%v, AdditionalProperties=%v]",
    	a.AccountNameList, a.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Accountnames.
// It customizes the JSON marshaling process for Accountnames objects.
func (a Accountnames) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(a.AdditionalProperties,
        "accountNameList"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(a.toMap())
}

// toMap converts the Accountnames object to a map representation for JSON marshaling.
func (a Accountnames) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, a.AdditionalProperties)
    if a.AccountNameList != nil {
        structMap["accountNameList"] = a.AccountNameList
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Accountnames.
// It customizes the JSON unmarshaling process for Accountnames objects.
func (a *Accountnames) UnmarshalJSON(input []byte) error {
    var temp tempAccountnames
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountNameList")
    if err != nil {
    	return err
    }
    a.AdditionalProperties = additionalProperties
    
    a.AccountNameList = temp.AccountNameList
    return nil
}

// tempAccountnames is a temporary struct used for validating the fields of Accountnames.
type tempAccountnames  struct {
    AccountNameList []string `json:"accountNameList,omitempty"`
}
