/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// SecuritySubscriptionResult represents a SecuritySubscriptionResult struct.
// Response for a subscription request.
type SecuritySubscriptionResult struct {
    // The name of a billing account.
    AccountName      *string                `json:"accountName,omitempty"`
    // The list of SKU numbers and counts for each license type specified in the request.
    SubscriptionList []SecuritySubscription `json:"subscriptionList,omitempty"`
}

// String implements the fmt.Stringer interface for SecuritySubscriptionResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (s SecuritySubscriptionResult) String() string {
    return fmt.Sprintf(
    	"SecuritySubscriptionResult[AccountName=%v, SubscriptionList=%v]",
    	s.AccountName, s.SubscriptionList)
}

// MarshalJSON implements the json.Marshaler interface for SecuritySubscriptionResult.
// It customizes the JSON marshaling process for SecuritySubscriptionResult objects.
func (s SecuritySubscriptionResult) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(s.toMap())
}

// toMap converts the SecuritySubscriptionResult object to a map representation for JSON marshaling.
func (s SecuritySubscriptionResult) toMap() map[string]any {
    structMap := make(map[string]any)
    if s.AccountName != nil {
        structMap["accountName"] = s.AccountName
    }
    if s.SubscriptionList != nil {
        structMap["subscriptionList"] = s.SubscriptionList
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for SecuritySubscriptionResult.
// It customizes the JSON unmarshaling process for SecuritySubscriptionResult objects.
func (s *SecuritySubscriptionResult) UnmarshalJSON(input []byte) error {
    var temp tempSecuritySubscriptionResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    s.AccountName = temp.AccountName
    s.SubscriptionList = temp.SubscriptionList
    return nil
}

// tempSecuritySubscriptionResult is a temporary struct used for validating the fields of SecuritySubscriptionResult.
type tempSecuritySubscriptionResult  struct {
    AccountName      *string                `json:"accountName,omitempty"`
    SubscriptionList []SecuritySubscription `json:"subscriptionList,omitempty"`
}
