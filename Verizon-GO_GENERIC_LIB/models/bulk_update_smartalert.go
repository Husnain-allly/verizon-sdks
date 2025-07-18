/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// BulkUpdateSmartalert represents a BulkUpdateSmartalert struct.
type BulkUpdateSmartalert struct {
    // User defined name of the record
    Name *string `json:"name,omitempty"`
}

// String implements the fmt.Stringer interface for BulkUpdateSmartalert,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (b BulkUpdateSmartalert) String() string {
    return fmt.Sprintf(
    	"BulkUpdateSmartalert[Name=%v]",
    	b.Name)
}

// MarshalJSON implements the json.Marshaler interface for BulkUpdateSmartalert.
// It customizes the JSON marshaling process for BulkUpdateSmartalert objects.
func (b BulkUpdateSmartalert) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(b.toMap())
}

// toMap converts the BulkUpdateSmartalert object to a map representation for JSON marshaling.
func (b BulkUpdateSmartalert) toMap() map[string]any {
    structMap := make(map[string]any)
    if b.Name != nil {
        structMap["name"] = b.Name
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for BulkUpdateSmartalert.
// It customizes the JSON unmarshaling process for BulkUpdateSmartalert objects.
func (b *BulkUpdateSmartalert) UnmarshalJSON(input []byte) error {
    var temp tempBulkUpdateSmartalert
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    b.Name = temp.Name
    return nil
}

// tempBulkUpdateSmartalert is a temporary struct used for validating the fields of BulkUpdateSmartalert.
type tempBulkUpdateSmartalert  struct {
    Name *string `json:"name,omitempty"`
}
