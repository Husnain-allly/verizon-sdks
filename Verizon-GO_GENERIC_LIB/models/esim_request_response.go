/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// EsimRequestResponse represents a EsimRequestResponse struct.
type EsimRequestResponse struct {
    RequestId *string `json:"requestId,omitempty"`
}

// String implements the fmt.Stringer interface for EsimRequestResponse,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (e EsimRequestResponse) String() string {
    return fmt.Sprintf(
    	"EsimRequestResponse[RequestId=%v]",
    	e.RequestId)
}

// MarshalJSON implements the json.Marshaler interface for EsimRequestResponse.
// It customizes the JSON marshaling process for EsimRequestResponse objects.
func (e EsimRequestResponse) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(e.toMap())
}

// toMap converts the EsimRequestResponse object to a map representation for JSON marshaling.
func (e EsimRequestResponse) toMap() map[string]any {
    structMap := make(map[string]any)
    if e.RequestId != nil {
        structMap["requestId"] = e.RequestId
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for EsimRequestResponse.
// It customizes the JSON unmarshaling process for EsimRequestResponse objects.
func (e *EsimRequestResponse) UnmarshalJSON(input []byte) error {
    var temp tempEsimRequestResponse
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    e.RequestId = temp.RequestId
    return nil
}

// tempEsimRequestResponse is a temporary struct used for validating the fields of EsimRequestResponse.
type tempEsimRequestResponse  struct {
    RequestId *string `json:"requestId,omitempty"`
}
