/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// M5GBiRequestResponse represents a M5GBiRequestResponse struct.
type M5GBiRequestResponse struct {
    RequestId            *string                `json:"requestId,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for M5GBiRequestResponse,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (m M5GBiRequestResponse) String() string {
    return fmt.Sprintf(
    	"M5GBiRequestResponse[RequestId=%v, AdditionalProperties=%v]",
    	m.RequestId, m.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for M5GBiRequestResponse.
// It customizes the JSON marshaling process for M5GBiRequestResponse objects.
func (m M5GBiRequestResponse) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(m.AdditionalProperties,
        "requestId"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(m.toMap())
}

// toMap converts the M5GBiRequestResponse object to a map representation for JSON marshaling.
func (m M5GBiRequestResponse) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, m.AdditionalProperties)
    if m.RequestId != nil {
        structMap["requestId"] = m.RequestId
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for M5GBiRequestResponse.
// It customizes the JSON unmarshaling process for M5GBiRequestResponse objects.
func (m *M5GBiRequestResponse) UnmarshalJSON(input []byte) error {
    var temp tempM5GBiRequestResponse
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "requestId")
    if err != nil {
    	return err
    }
    m.AdditionalProperties = additionalProperties
    
    m.RequestId = temp.RequestId
    return nil
}

// tempM5GBiRequestResponse is a temporary struct used for validating the fields of M5GBiRequestResponse.
type tempM5GBiRequestResponse  struct {
    RequestId *string `json:"requestId,omitempty"`
}
