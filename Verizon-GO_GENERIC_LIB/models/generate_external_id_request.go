/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// GenerateExternalIdRequest represents a GenerateExternalIdRequest struct.
// Authenticating account ID.
type GenerateExternalIdRequest struct {
    // The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
    Accountidentifier    *AccountIdentifier     `json:"accountidentifier,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for GenerateExternalIdRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (g GenerateExternalIdRequest) String() string {
    return fmt.Sprintf(
    	"GenerateExternalIdRequest[Accountidentifier=%v, AdditionalProperties=%v]",
    	g.Accountidentifier, g.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for GenerateExternalIdRequest.
// It customizes the JSON marshaling process for GenerateExternalIdRequest objects.
func (g GenerateExternalIdRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(g.AdditionalProperties,
        "accountidentifier"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(g.toMap())
}

// toMap converts the GenerateExternalIdRequest object to a map representation for JSON marshaling.
func (g GenerateExternalIdRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, g.AdditionalProperties)
    if g.Accountidentifier != nil {
        structMap["accountidentifier"] = g.Accountidentifier.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for GenerateExternalIdRequest.
// It customizes the JSON unmarshaling process for GenerateExternalIdRequest objects.
func (g *GenerateExternalIdRequest) UnmarshalJSON(input []byte) error {
    var temp tempGenerateExternalIdRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountidentifier")
    if err != nil {
    	return err
    }
    g.AdditionalProperties = additionalProperties
    
    g.Accountidentifier = temp.Accountidentifier
    return nil
}

// tempGenerateExternalIdRequest is a temporary struct used for validating the fields of GenerateExternalIdRequest.
type tempGenerateExternalIdRequest  struct {
    Accountidentifier *AccountIdentifier `json:"accountidentifier,omitempty"`
}
