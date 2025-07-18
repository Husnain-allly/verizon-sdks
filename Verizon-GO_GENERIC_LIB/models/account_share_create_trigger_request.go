/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// AccountShareCreateTriggerRequest represents a AccountShareCreateTriggerRequest struct.
type AccountShareCreateTriggerRequest struct {
    // The user defined name of the trigger
    TriggerName          *string                       `json:"triggerName,omitempty"`
    // The Enterprise Customer Profile Database ID
    EcpdId               *string                       `json:"ecpdId,omitempty"`
    // The type of trigger being created or modified
    TriggerCategory      *TriggerCategory              `json:"triggerCategory,omitempty"`
    PricePlanTrigger     *AccountSharePricePlanTrigger `json:"pricePlanTrigger,omitempty"`
    Notification         *Notificationarray            `json:"notification,omitempty"`
    // A flag to indicate of the trigger is active, true, or not, false
    Active               *Active                       `json:"active,omitempty"`
    AdditionalProperties map[string]interface{}        `json:"_"`
}

// String implements the fmt.Stringer interface for AccountShareCreateTriggerRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (a AccountShareCreateTriggerRequest) String() string {
    return fmt.Sprintf(
    	"AccountShareCreateTriggerRequest[TriggerName=%v, EcpdId=%v, TriggerCategory=%v, PricePlanTrigger=%v, Notification=%v, Active=%v, AdditionalProperties=%v]",
    	a.TriggerName, a.EcpdId, a.TriggerCategory, a.PricePlanTrigger, a.Notification, a.Active, a.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for AccountShareCreateTriggerRequest.
// It customizes the JSON marshaling process for AccountShareCreateTriggerRequest objects.
func (a AccountShareCreateTriggerRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(a.AdditionalProperties,
        "triggerName", "ecpdId", "triggerCategory", "pricePlanTrigger", "notification", "active"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(a.toMap())
}

// toMap converts the AccountShareCreateTriggerRequest object to a map representation for JSON marshaling.
func (a AccountShareCreateTriggerRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, a.AdditionalProperties)
    if a.TriggerName != nil {
        structMap["triggerName"] = a.TriggerName
    }
    if a.EcpdId != nil {
        structMap["ecpdId"] = a.EcpdId
    }
    if a.TriggerCategory != nil {
        structMap["triggerCategory"] = a.TriggerCategory
    }
    if a.PricePlanTrigger != nil {
        structMap["pricePlanTrigger"] = a.PricePlanTrigger.toMap()
    }
    if a.Notification != nil {
        structMap["notification"] = a.Notification.toMap()
    }
    if a.Active != nil {
        structMap["active"] = a.Active
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for AccountShareCreateTriggerRequest.
// It customizes the JSON unmarshaling process for AccountShareCreateTriggerRequest objects.
func (a *AccountShareCreateTriggerRequest) UnmarshalJSON(input []byte) error {
    var temp tempAccountShareCreateTriggerRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "triggerName", "ecpdId", "triggerCategory", "pricePlanTrigger", "notification", "active")
    if err != nil {
    	return err
    }
    a.AdditionalProperties = additionalProperties
    
    a.TriggerName = temp.TriggerName
    a.EcpdId = temp.EcpdId
    a.TriggerCategory = temp.TriggerCategory
    a.PricePlanTrigger = temp.PricePlanTrigger
    a.Notification = temp.Notification
    a.Active = temp.Active
    return nil
}

// tempAccountShareCreateTriggerRequest is a temporary struct used for validating the fields of AccountShareCreateTriggerRequest.
type tempAccountShareCreateTriggerRequest  struct {
    TriggerName      *string                       `json:"triggerName,omitempty"`
    EcpdId           *string                       `json:"ecpdId,omitempty"`
    TriggerCategory  *TriggerCategory              `json:"triggerCategory,omitempty"`
    PricePlanTrigger *AccountSharePricePlanTrigger `json:"pricePlanTrigger,omitempty"`
    Notification     *Notificationarray            `json:"notification,omitempty"`
    Active           *Active                       `json:"active,omitempty"`
}
