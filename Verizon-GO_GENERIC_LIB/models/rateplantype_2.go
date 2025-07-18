/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Rateplantype2 represents a Rateplantype2 struct.
type Rateplantype2 struct {
    Description          *string                `json:"description,omitempty"`
    SizeKb               *string                `json:"sizeKb,omitempty"`
    CarrierRatePlanCode  *string                `json:"carrierRatePlanCode,omitempty"`
    ZeroDollarBilling    *bool                  `json:"zeroDollarBilling,omitempty"`
    PromotionOffered     *bool                  `json:"promotionOffered,omitempty"`
    PromotionDays        *int                   `json:"promotionDays,omitempty"`
    RatePlanType         *string                `json:"ratePlanType,omitempty"`
    // Account information
    Account              []Accountid            `json:"account,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Rateplantype2,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (r Rateplantype2) String() string {
    return fmt.Sprintf(
    	"Rateplantype2[Description=%v, SizeKb=%v, CarrierRatePlanCode=%v, ZeroDollarBilling=%v, PromotionOffered=%v, PromotionDays=%v, RatePlanType=%v, Account=%v, AdditionalProperties=%v]",
    	r.Description, r.SizeKb, r.CarrierRatePlanCode, r.ZeroDollarBilling, r.PromotionOffered, r.PromotionDays, r.RatePlanType, r.Account, r.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Rateplantype2.
// It customizes the JSON marshaling process for Rateplantype2 objects.
func (r Rateplantype2) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(r.AdditionalProperties,
        "description", "sizeKb", "carrierRatePlanCode", "zeroDollarBilling", "promotionOffered", "promotionDays", "ratePlanType", "account"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(r.toMap())
}

// toMap converts the Rateplantype2 object to a map representation for JSON marshaling.
func (r Rateplantype2) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, r.AdditionalProperties)
    if r.Description != nil {
        structMap["description"] = r.Description
    }
    if r.SizeKb != nil {
        structMap["sizeKb"] = r.SizeKb
    }
    if r.CarrierRatePlanCode != nil {
        structMap["carrierRatePlanCode"] = r.CarrierRatePlanCode
    }
    if r.ZeroDollarBilling != nil {
        structMap["zeroDollarBilling"] = r.ZeroDollarBilling
    }
    if r.PromotionOffered != nil {
        structMap["promotionOffered"] = r.PromotionOffered
    }
    if r.PromotionDays != nil {
        structMap["promotionDays"] = r.PromotionDays
    }
    if r.RatePlanType != nil {
        structMap["ratePlanType"] = r.RatePlanType
    }
    if r.Account != nil {
        structMap["account"] = r.Account
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Rateplantype2.
// It customizes the JSON unmarshaling process for Rateplantype2 objects.
func (r *Rateplantype2) UnmarshalJSON(input []byte) error {
    var temp tempRateplantype2
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "description", "sizeKb", "carrierRatePlanCode", "zeroDollarBilling", "promotionOffered", "promotionDays", "ratePlanType", "account")
    if err != nil {
    	return err
    }
    r.AdditionalProperties = additionalProperties
    
    r.Description = temp.Description
    r.SizeKb = temp.SizeKb
    r.CarrierRatePlanCode = temp.CarrierRatePlanCode
    r.ZeroDollarBilling = temp.ZeroDollarBilling
    r.PromotionOffered = temp.PromotionOffered
    r.PromotionDays = temp.PromotionDays
    r.RatePlanType = temp.RatePlanType
    r.Account = temp.Account
    return nil
}

// tempRateplantype2 is a temporary struct used for validating the fields of Rateplantype2.
type tempRateplantype2  struct {
    Description         *string     `json:"description,omitempty"`
    SizeKb              *string     `json:"sizeKb,omitempty"`
    CarrierRatePlanCode *string     `json:"carrierRatePlanCode,omitempty"`
    ZeroDollarBilling   *bool       `json:"zeroDollarBilling,omitempty"`
    PromotionOffered    *bool       `json:"promotionOffered,omitempty"`
    PromotionDays       *int        `json:"promotionDays,omitempty"`
    RatePlanType        *string     `json:"ratePlanType,omitempty"`
    Account             []Accountid `json:"account,omitempty"`
}
