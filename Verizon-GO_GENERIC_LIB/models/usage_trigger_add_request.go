/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "errors"
    "fmt"
    "strings"
)

// UsageTriggerAddRequest represents a UsageTriggerAddRequest struct.
type UsageTriggerAddRequest struct {
    // Usage trigger name
    TriggerName           *string                `json:"triggerName,omitempty"`
    // Account name
    AccountName           string                 `json:"accountName"`
    // Service name
    ServiceName           ServiceName            `json:"serviceName"`
    // The percent of subscribed usage required to activate the trigger, such as 90 or 100.
    ThresholdValue        string                 `json:"thresholdValue"`
    // Allow additional requests after thresholdValue is reached. (currently not functional)
    AllowExcess           *bool                  `json:"allowExcess,omitempty"`
    // Send SMS (text) alerts when the thresholdValue is reached.
    SendSmsNotification   *bool                  `json:"sendSmsNotification,omitempty"`
    // Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc.
    SmsPhoneNumbers       *string                `json:"smsPhoneNumbers,omitempty"`
    // Send email alerts when the thresholdValue is reached.
    SendEmailNotification *bool                  `json:"sendEmailNotification,omitempty"`
    // Comma-separated list of email addresses to send alerts to.
    EmailAddresses        *string                `json:"emailAddresses,omitempty"`
    AdditionalProperties  map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for UsageTriggerAddRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (u UsageTriggerAddRequest) String() string {
    return fmt.Sprintf(
    	"UsageTriggerAddRequest[TriggerName=%v, AccountName=%v, ServiceName=%v, ThresholdValue=%v, AllowExcess=%v, SendSmsNotification=%v, SmsPhoneNumbers=%v, SendEmailNotification=%v, EmailAddresses=%v, AdditionalProperties=%v]",
    	u.TriggerName, u.AccountName, u.ServiceName, u.ThresholdValue, u.AllowExcess, u.SendSmsNotification, u.SmsPhoneNumbers, u.SendEmailNotification, u.EmailAddresses, u.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for UsageTriggerAddRequest.
// It customizes the JSON marshaling process for UsageTriggerAddRequest objects.
func (u UsageTriggerAddRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(u.AdditionalProperties,
        "triggerName", "accountName", "serviceName", "thresholdValue", "allowExcess", "sendSmsNotification", "smsPhoneNumbers", "sendEmailNotification", "emailAddresses"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(u.toMap())
}

// toMap converts the UsageTriggerAddRequest object to a map representation for JSON marshaling.
func (u UsageTriggerAddRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, u.AdditionalProperties)
    if u.TriggerName != nil {
        structMap["triggerName"] = u.TriggerName
    }
    structMap["accountName"] = u.AccountName
    structMap["serviceName"] = u.ServiceName
    structMap["thresholdValue"] = u.ThresholdValue
    if u.AllowExcess != nil {
        structMap["allowExcess"] = u.AllowExcess
    }
    if u.SendSmsNotification != nil {
        structMap["sendSmsNotification"] = u.SendSmsNotification
    }
    if u.SmsPhoneNumbers != nil {
        structMap["smsPhoneNumbers"] = u.SmsPhoneNumbers
    }
    if u.SendEmailNotification != nil {
        structMap["sendEmailNotification"] = u.SendEmailNotification
    }
    if u.EmailAddresses != nil {
        structMap["emailAddresses"] = u.EmailAddresses
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for UsageTriggerAddRequest.
// It customizes the JSON unmarshaling process for UsageTriggerAddRequest objects.
func (u *UsageTriggerAddRequest) UnmarshalJSON(input []byte) error {
    var temp tempUsageTriggerAddRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "triggerName", "accountName", "serviceName", "thresholdValue", "allowExcess", "sendSmsNotification", "smsPhoneNumbers", "sendEmailNotification", "emailAddresses")
    if err != nil {
    	return err
    }
    u.AdditionalProperties = additionalProperties
    
    u.TriggerName = temp.TriggerName
    u.AccountName = *temp.AccountName
    u.ServiceName = *temp.ServiceName
    u.ThresholdValue = *temp.ThresholdValue
    u.AllowExcess = temp.AllowExcess
    u.SendSmsNotification = temp.SendSmsNotification
    u.SmsPhoneNumbers = temp.SmsPhoneNumbers
    u.SendEmailNotification = temp.SendEmailNotification
    u.EmailAddresses = temp.EmailAddresses
    return nil
}

// tempUsageTriggerAddRequest is a temporary struct used for validating the fields of UsageTriggerAddRequest.
type tempUsageTriggerAddRequest  struct {
    TriggerName           *string      `json:"triggerName,omitempty"`
    AccountName           *string      `json:"accountName"`
    ServiceName           *ServiceName `json:"serviceName"`
    ThresholdValue        *string      `json:"thresholdValue"`
    AllowExcess           *bool        `json:"allowExcess,omitempty"`
    SendSmsNotification   *bool        `json:"sendSmsNotification,omitempty"`
    SmsPhoneNumbers       *string      `json:"smsPhoneNumbers,omitempty"`
    SendEmailNotification *bool        `json:"sendEmailNotification,omitempty"`
    EmailAddresses        *string      `json:"emailAddresses,omitempty"`
}

func (u *tempUsageTriggerAddRequest) validate() error {
    var errs []string
    if u.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `UsageTriggerAddRequest`")
    }
    if u.ServiceName == nil {
        errs = append(errs, "required field `serviceName` is missing for type `UsageTriggerAddRequest`")
    }
    if u.ThresholdValue == nil {
        errs = append(errs, "required field `thresholdValue` is missing for type `UsageTriggerAddRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
