/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// BillingCycle represents a BillingCycle struct.
type BillingCycle struct {
    Year                 *string                `json:"year,omitempty"`
    Month                *string                `json:"month,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for BillingCycle,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (b BillingCycle) String() string {
    return fmt.Sprintf(
    	"BillingCycle[Year=%v, Month=%v, AdditionalProperties=%v]",
    	b.Year, b.Month, b.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for BillingCycle.
// It customizes the JSON marshaling process for BillingCycle objects.
func (b BillingCycle) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(b.AdditionalProperties,
        "year", "month"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(b.toMap())
}

// toMap converts the BillingCycle object to a map representation for JSON marshaling.
func (b BillingCycle) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, b.AdditionalProperties)
    if b.Year != nil {
        structMap["year"] = b.Year
    }
    if b.Month != nil {
        structMap["month"] = b.Month
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for BillingCycle.
// It customizes the JSON unmarshaling process for BillingCycle objects.
func (b *BillingCycle) UnmarshalJSON(input []byte) error {
    var temp tempBillingCycle
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "year", "month")
    if err != nil {
    	return err
    }
    b.AdditionalProperties = additionalProperties
    
    b.Year = temp.Year
    b.Month = temp.Month
    return nil
}

// tempBillingCycle is a temporary struct used for validating the fields of BillingCycle.
type tempBillingCycle  struct {
    Year  *string `json:"year,omitempty"`
    Month *string `json:"month,omitempty"`
}
