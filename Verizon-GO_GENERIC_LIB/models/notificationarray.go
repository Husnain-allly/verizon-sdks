/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Notificationarray represents a Notificationarray struct.
type Notificationarray struct {
    NotificationType              *string                `json:"notificationType,omitempty"`
    Callback                      *bool                  `json:"callback,omitempty"`
    EmailNotification             *bool                  `json:"emailNotification,omitempty"`
    NotificationGroupName         *string                `json:"notificationGroupName,omitempty"`
    NotificationFrequencyFactor   *int                   `json:"notificationFrequencyFactor,omitempty"`
    NotificationFrequencyInterval *string                `json:"notificationFrequencyInterval,omitempty"`
    ExternalEmailRecipients       *string                `json:"externalEmailRecipients,omitempty"`
    SmsNotification               *bool                  `json:"smsNotification,omitempty"`
    SmsNumbers                    []Cellphonenumber      `json:"smsNumbers,omitempty"`
    Reminder                      *bool                  `json:"reminder,omitempty"`
    Severity                      *string                `json:"severity,omitempty"`
    AdditionalProperties          map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Notificationarray,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (n Notificationarray) String() string {
    return fmt.Sprintf(
    	"Notificationarray[NotificationType=%v, Callback=%v, EmailNotification=%v, NotificationGroupName=%v, NotificationFrequencyFactor=%v, NotificationFrequencyInterval=%v, ExternalEmailRecipients=%v, SmsNotification=%v, SmsNumbers=%v, Reminder=%v, Severity=%v, AdditionalProperties=%v]",
    	n.NotificationType, n.Callback, n.EmailNotification, n.NotificationGroupName, n.NotificationFrequencyFactor, n.NotificationFrequencyInterval, n.ExternalEmailRecipients, n.SmsNotification, n.SmsNumbers, n.Reminder, n.Severity, n.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Notificationarray.
// It customizes the JSON marshaling process for Notificationarray objects.
func (n Notificationarray) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(n.AdditionalProperties,
        "notificationType", "callback", "emailNotification", "notificationGroupName", "notificationFrequencyFactor", "notificationFrequencyInterval", "externalEmailRecipients", "smsNotification", "smsNumbers", "reminder", "severity"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(n.toMap())
}

// toMap converts the Notificationarray object to a map representation for JSON marshaling.
func (n Notificationarray) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, n.AdditionalProperties)
    if n.NotificationType != nil {
        structMap["notificationType"] = n.NotificationType
    }
    if n.Callback != nil {
        structMap["callback"] = n.Callback
    }
    if n.EmailNotification != nil {
        structMap["emailNotification"] = n.EmailNotification
    }
    if n.NotificationGroupName != nil {
        structMap["notificationGroupName"] = n.NotificationGroupName
    }
    if n.NotificationFrequencyFactor != nil {
        structMap["notificationFrequencyFactor"] = n.NotificationFrequencyFactor
    }
    if n.NotificationFrequencyInterval != nil {
        structMap["notificationFrequencyInterval"] = n.NotificationFrequencyInterval
    }
    if n.ExternalEmailRecipients != nil {
        structMap["externalEmailRecipients"] = n.ExternalEmailRecipients
    }
    if n.SmsNotification != nil {
        structMap["smsNotification"] = n.SmsNotification
    }
    if n.SmsNumbers != nil {
        structMap["smsNumbers"] = n.SmsNumbers
    }
    if n.Reminder != nil {
        structMap["reminder"] = n.Reminder
    }
    if n.Severity != nil {
        structMap["severity"] = n.Severity
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Notificationarray.
// It customizes the JSON unmarshaling process for Notificationarray objects.
func (n *Notificationarray) UnmarshalJSON(input []byte) error {
    var temp tempNotificationarray
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "notificationType", "callback", "emailNotification", "notificationGroupName", "notificationFrequencyFactor", "notificationFrequencyInterval", "externalEmailRecipients", "smsNotification", "smsNumbers", "reminder", "severity")
    if err != nil {
    	return err
    }
    n.AdditionalProperties = additionalProperties
    
    n.NotificationType = temp.NotificationType
    n.Callback = temp.Callback
    n.EmailNotification = temp.EmailNotification
    n.NotificationGroupName = temp.NotificationGroupName
    n.NotificationFrequencyFactor = temp.NotificationFrequencyFactor
    n.NotificationFrequencyInterval = temp.NotificationFrequencyInterval
    n.ExternalEmailRecipients = temp.ExternalEmailRecipients
    n.SmsNotification = temp.SmsNotification
    n.SmsNumbers = temp.SmsNumbers
    n.Reminder = temp.Reminder
    n.Severity = temp.Severity
    return nil
}

// tempNotificationarray is a temporary struct used for validating the fields of Notificationarray.
type tempNotificationarray  struct {
    NotificationType              *string           `json:"notificationType,omitempty"`
    Callback                      *bool             `json:"callback,omitempty"`
    EmailNotification             *bool             `json:"emailNotification,omitempty"`
    NotificationGroupName         *string           `json:"notificationGroupName,omitempty"`
    NotificationFrequencyFactor   *int              `json:"notificationFrequencyFactor,omitempty"`
    NotificationFrequencyInterval *string           `json:"notificationFrequencyInterval,omitempty"`
    ExternalEmailRecipients       *string           `json:"externalEmailRecipients,omitempty"`
    SmsNotification               *bool             `json:"smsNotification,omitempty"`
    SmsNumbers                    []Cellphonenumber `json:"smsNumbers,omitempty"`
    Reminder                      *bool             `json:"reminder,omitempty"`
    Severity                      *string           `json:"severity,omitempty"`
}
