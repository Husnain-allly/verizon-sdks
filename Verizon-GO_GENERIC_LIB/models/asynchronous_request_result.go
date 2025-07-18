/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// AsynchronousRequestResult represents a AsynchronousRequestResult struct.
// A successful request returns the request ID and the current status.
type AsynchronousRequestResult struct {
    // The unique ID of the asynchronous request.
    RequestId            *string                `json:"requestId,omitempty"`
    // The current status of the callback response.
    Status               *RequestStatus         `json:"status,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for AsynchronousRequestResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (a AsynchronousRequestResult) String() string {
    return fmt.Sprintf(
    	"AsynchronousRequestResult[RequestId=%v, Status=%v, AdditionalProperties=%v]",
    	a.RequestId, a.Status, a.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for AsynchronousRequestResult.
// It customizes the JSON marshaling process for AsynchronousRequestResult objects.
func (a AsynchronousRequestResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(a.AdditionalProperties,
        "requestId", "status"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(a.toMap())
}

// toMap converts the AsynchronousRequestResult object to a map representation for JSON marshaling.
func (a AsynchronousRequestResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, a.AdditionalProperties)
    if a.RequestId != nil {
        structMap["requestId"] = a.RequestId
    }
    if a.Status != nil {
        structMap["status"] = a.Status
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for AsynchronousRequestResult.
// It customizes the JSON unmarshaling process for AsynchronousRequestResult objects.
func (a *AsynchronousRequestResult) UnmarshalJSON(input []byte) error {
    var temp tempAsynchronousRequestResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "requestId", "status")
    if err != nil {
    	return err
    }
    a.AdditionalProperties = additionalProperties
    
    a.RequestId = temp.RequestId
    a.Status = temp.Status
    return nil
}

// tempAsynchronousRequestResult is a temporary struct used for validating the fields of AsynchronousRequestResult.
type tempAsynchronousRequestResult  struct {
    RequestId *string        `json:"requestId,omitempty"`
    Status    *RequestStatus `json:"status,omitempty"`
}
