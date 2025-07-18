/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Rateplan represents a Rateplan struct.
type Rateplan struct {
    // An array of rate plan group names
    RatePlanGroup        []RatePlanGroup        `json:"ratePlanGroup,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Rateplan,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (r Rateplan) String() string {
    return fmt.Sprintf(
    	"Rateplan[RatePlanGroup=%v, AdditionalProperties=%v]",
    	r.RatePlanGroup, r.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Rateplan.
// It customizes the JSON marshaling process for Rateplan objects.
func (r Rateplan) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(r.AdditionalProperties,
        "ratePlanGroup"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(r.toMap())
}

// toMap converts the Rateplan object to a map representation for JSON marshaling.
func (r Rateplan) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, r.AdditionalProperties)
    if r.RatePlanGroup != nil {
        structMap["ratePlanGroup"] = r.RatePlanGroup
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Rateplan.
// It customizes the JSON unmarshaling process for Rateplan objects.
func (r *Rateplan) UnmarshalJSON(input []byte) error {
    var temp tempRateplan
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "ratePlanGroup")
    if err != nil {
    	return err
    }
    r.AdditionalProperties = additionalProperties
    
    r.RatePlanGroup = temp.RatePlanGroup
    return nil
}

// tempRateplan is a temporary struct used for validating the fields of Rateplan.
type tempRateplan  struct {
    RatePlanGroup []RatePlanGroup `json:"ratePlanGroup,omitempty"`
}
