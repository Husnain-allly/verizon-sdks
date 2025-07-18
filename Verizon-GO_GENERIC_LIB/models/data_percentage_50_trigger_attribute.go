/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DataPercentage50TriggerAttribute represents a DataPercentage50TriggerAttribute struct.
// Trigger attribute for when data percentage is over 50% used.
type DataPercentage50TriggerAttribute struct {
    // Key data percentage 50.
    Key   *string `json:"key,omitempty"`
    // DataPercentage50<br />True - Trigger on Data percentage is over 50% used<br />False - Do not trigger when over 50% used.
    Value *bool   `json:"value,omitempty"`
}

// String implements the fmt.Stringer interface for DataPercentage50TriggerAttribute,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DataPercentage50TriggerAttribute) String() string {
    return fmt.Sprintf(
    	"DataPercentage50TriggerAttribute[Key=%v, Value=%v]",
    	d.Key, d.Value)
}

// MarshalJSON implements the json.Marshaler interface for DataPercentage50TriggerAttribute.
// It customizes the JSON marshaling process for DataPercentage50TriggerAttribute objects.
func (d DataPercentage50TriggerAttribute) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(d.toMap())
}

// toMap converts the DataPercentage50TriggerAttribute object to a map representation for JSON marshaling.
func (d DataPercentage50TriggerAttribute) toMap() map[string]any {
    structMap := make(map[string]any)
    if d.Key != nil {
        structMap["key"] = d.Key
    }
    if d.Value != nil {
        structMap["value"] = d.Value
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DataPercentage50TriggerAttribute.
// It customizes the JSON unmarshaling process for DataPercentage50TriggerAttribute objects.
func (d *DataPercentage50TriggerAttribute) UnmarshalJSON(input []byte) error {
    var temp tempDataPercentage50TriggerAttribute
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    d.Key = temp.Key
    d.Value = temp.Value
    return nil
}

// tempDataPercentage50TriggerAttribute is a temporary struct used for validating the fields of DataPercentage50TriggerAttribute.
type tempDataPercentage50TriggerAttribute  struct {
    Key   *string `json:"key,omitempty"`
    Value *bool   `json:"value,omitempty"`
}
