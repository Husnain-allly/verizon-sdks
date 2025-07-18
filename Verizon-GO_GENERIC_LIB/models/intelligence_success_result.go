/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// IntelligenceSuccessResult represents a IntelligenceSuccessResult struct.
// Success response.
type IntelligenceSuccessResult struct {
    // Anomaly detection status.
    Status *string `json:"status,omitempty"`
}

// String implements the fmt.Stringer interface for IntelligenceSuccessResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (i IntelligenceSuccessResult) String() string {
    return fmt.Sprintf(
    	"IntelligenceSuccessResult[Status=%v]",
    	i.Status)
}

// MarshalJSON implements the json.Marshaler interface for IntelligenceSuccessResult.
// It customizes the JSON marshaling process for IntelligenceSuccessResult objects.
func (i IntelligenceSuccessResult) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(i.toMap())
}

// toMap converts the IntelligenceSuccessResult object to a map representation for JSON marshaling.
func (i IntelligenceSuccessResult) toMap() map[string]any {
    structMap := make(map[string]any)
    if i.Status != nil {
        structMap["status"] = i.Status
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for IntelligenceSuccessResult.
// It customizes the JSON unmarshaling process for IntelligenceSuccessResult objects.
func (i *IntelligenceSuccessResult) UnmarshalJSON(input []byte) error {
    var temp tempIntelligenceSuccessResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    i.Status = temp.Status
    return nil
}

// tempIntelligenceSuccessResult is a temporary struct used for validating the fields of IntelligenceSuccessResult.
type tempIntelligenceSuccessResult  struct {
    Status *string `json:"status,omitempty"`
}
