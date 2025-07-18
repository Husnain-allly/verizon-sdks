/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// ManagedAccAddedList represents a ManagedAccAddedList struct.
type ManagedAccAddedList struct {
    // Account name
    Id                   *string                `json:"id,omitempty"`
    // Transaction identifier
    Txid                 *string                `json:"txid,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for ManagedAccAddedList,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (m ManagedAccAddedList) String() string {
    return fmt.Sprintf(
    	"ManagedAccAddedList[Id=%v, Txid=%v, AdditionalProperties=%v]",
    	m.Id, m.Txid, m.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for ManagedAccAddedList.
// It customizes the JSON marshaling process for ManagedAccAddedList objects.
func (m ManagedAccAddedList) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(m.AdditionalProperties,
        "id", "txid"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(m.toMap())
}

// toMap converts the ManagedAccAddedList object to a map representation for JSON marshaling.
func (m ManagedAccAddedList) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, m.AdditionalProperties)
    if m.Id != nil {
        structMap["id"] = m.Id
    }
    if m.Txid != nil {
        structMap["txid"] = m.Txid
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ManagedAccAddedList.
// It customizes the JSON unmarshaling process for ManagedAccAddedList objects.
func (m *ManagedAccAddedList) UnmarshalJSON(input []byte) error {
    var temp tempManagedAccAddedList
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "id", "txid")
    if err != nil {
    	return err
    }
    m.AdditionalProperties = additionalProperties
    
    m.Id = temp.Id
    m.Txid = temp.Txid
    return nil
}

// tempManagedAccAddedList is a temporary struct used for validating the fields of ManagedAccAddedList.
type tempManagedAccAddedList  struct {
    Id   *string `json:"id,omitempty"`
    Txid *string `json:"txid,omitempty"`
}
