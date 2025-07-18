/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// AnomalyDetectionRequest represents a AnomalyDetectionRequest struct.
// Anomaly detection request.
type AnomalyDetectionRequest struct {
    // The name of a billing account. An account name is usually numeric, and must include any leading zeros.
    AccountName          *string                `json:"accountName,omitempty"`
    // The type of request being made. anomaly is the request to activate anomaly detection.
    RequestType          *string                `json:"requestType,omitempty"`
    // Details for sensitivity parameters.
    SensitivityParameter *SensitivityParameters `json:"sensitivityParameter,omitempty"`
}

// String implements the fmt.Stringer interface for AnomalyDetectionRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (a AnomalyDetectionRequest) String() string {
    return fmt.Sprintf(
    	"AnomalyDetectionRequest[AccountName=%v, RequestType=%v, SensitivityParameter=%v]",
    	a.AccountName, a.RequestType, a.SensitivityParameter)
}

// MarshalJSON implements the json.Marshaler interface for AnomalyDetectionRequest.
// It customizes the JSON marshaling process for AnomalyDetectionRequest objects.
func (a AnomalyDetectionRequest) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(a.toMap())
}

// toMap converts the AnomalyDetectionRequest object to a map representation for JSON marshaling.
func (a AnomalyDetectionRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    if a.AccountName != nil {
        structMap["accountName"] = a.AccountName
    }
    if a.RequestType != nil {
        structMap["requestType"] = a.RequestType
    }
    if a.SensitivityParameter != nil {
        structMap["sensitivityParameter"] = a.SensitivityParameter.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for AnomalyDetectionRequest.
// It customizes the JSON unmarshaling process for AnomalyDetectionRequest objects.
func (a *AnomalyDetectionRequest) UnmarshalJSON(input []byte) error {
    var temp tempAnomalyDetectionRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    a.AccountName = temp.AccountName
    a.RequestType = temp.RequestType
    a.SensitivityParameter = temp.SensitivityParameter
    return nil
}

// tempAnomalyDetectionRequest is a temporary struct used for validating the fields of AnomalyDetectionRequest.
type tempAnomalyDetectionRequest  struct {
    AccountName          *string                `json:"accountName,omitempty"`
    RequestType          *string                `json:"requestType,omitempty"`
    SensitivityParameter *SensitivityParameters `json:"sensitivityParameter,omitempty"`
}
