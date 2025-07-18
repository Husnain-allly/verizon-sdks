/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// SessionResetPasswordResult represents a SessionResetPasswordResult struct.
// Response to a new, randomly generated password for the current username.
type SessionResetPasswordResult struct {
    // The new password for the username.
    NewPassword          *string                `json:"newPassword,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for SessionResetPasswordResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (s SessionResetPasswordResult) String() string {
    return fmt.Sprintf(
    	"SessionResetPasswordResult[NewPassword=%v, AdditionalProperties=%v]",
    	s.NewPassword, s.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for SessionResetPasswordResult.
// It customizes the JSON marshaling process for SessionResetPasswordResult objects.
func (s SessionResetPasswordResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(s.AdditionalProperties,
        "newPassword"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(s.toMap())
}

// toMap converts the SessionResetPasswordResult object to a map representation for JSON marshaling.
func (s SessionResetPasswordResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, s.AdditionalProperties)
    if s.NewPassword != nil {
        structMap["newPassword"] = s.NewPassword
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for SessionResetPasswordResult.
// It customizes the JSON unmarshaling process for SessionResetPasswordResult objects.
func (s *SessionResetPasswordResult) UnmarshalJSON(input []byte) error {
    var temp tempSessionResetPasswordResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "newPassword")
    if err != nil {
    	return err
    }
    s.AdditionalProperties = additionalProperties
    
    s.NewPassword = temp.NewPassword
    return nil
}

// tempSessionResetPasswordResult is a temporary struct used for validating the fields of SessionResetPasswordResult.
type tempSessionResetPasswordResult  struct {
    NewPassword *string `json:"newPassword,omitempty"`
}
