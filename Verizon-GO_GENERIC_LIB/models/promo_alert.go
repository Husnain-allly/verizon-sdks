/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// PromoAlert represents a PromoAlert struct.
type PromoAlert struct {
    FilterCriteria       []ReadySimServicePlan  `json:"filterCriteria,omitempty"`
    Condition            []Keyschunk2           `json:"condition,omitempty"`
    EnablePromoExp       *bool                  `json:"enablePromoExp,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for PromoAlert,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (p PromoAlert) String() string {
    return fmt.Sprintf(
    	"PromoAlert[FilterCriteria=%v, Condition=%v, EnablePromoExp=%v, AdditionalProperties=%v]",
    	p.FilterCriteria, p.Condition, p.EnablePromoExp, p.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for PromoAlert.
// It customizes the JSON marshaling process for PromoAlert objects.
func (p PromoAlert) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(p.AdditionalProperties,
        "filterCriteria", "condition", "enablePromoExp"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(p.toMap())
}

// toMap converts the PromoAlert object to a map representation for JSON marshaling.
func (p PromoAlert) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, p.AdditionalProperties)
    if p.FilterCriteria != nil {
        structMap["filterCriteria"] = p.FilterCriteria
    }
    if p.Condition != nil {
        structMap["condition"] = p.Condition
    }
    if p.EnablePromoExp != nil {
        structMap["enablePromoExp"] = p.EnablePromoExp
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for PromoAlert.
// It customizes the JSON unmarshaling process for PromoAlert objects.
func (p *PromoAlert) UnmarshalJSON(input []byte) error {
    var temp tempPromoAlert
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "filterCriteria", "condition", "enablePromoExp")
    if err != nil {
    	return err
    }
    p.AdditionalProperties = additionalProperties
    
    p.FilterCriteria = temp.FilterCriteria
    p.Condition = temp.Condition
    p.EnablePromoExp = temp.EnablePromoExp
    return nil
}

// tempPromoAlert is a temporary struct used for validating the fields of PromoAlert.
type tempPromoAlert  struct {
    FilterCriteria []ReadySimServicePlan `json:"filterCriteria,omitempty"`
    Condition      []Keyschunk2          `json:"condition,omitempty"`
    EnablePromoExp *bool                 `json:"enablePromoExp,omitempty"`
}
