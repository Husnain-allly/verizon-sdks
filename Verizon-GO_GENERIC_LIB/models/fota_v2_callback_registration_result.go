/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// FotaV2CallbackRegistrationResult represents a FotaV2CallbackRegistrationResult struct.
// Callback listener URL.
type FotaV2CallbackRegistrationResult struct {
    // Callback URL.
    Url                  *string                `json:"url,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for FotaV2CallbackRegistrationResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (f FotaV2CallbackRegistrationResult) String() string {
    return fmt.Sprintf(
    	"FotaV2CallbackRegistrationResult[Url=%v, AdditionalProperties=%v]",
    	f.Url, f.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for FotaV2CallbackRegistrationResult.
// It customizes the JSON marshaling process for FotaV2CallbackRegistrationResult objects.
func (f FotaV2CallbackRegistrationResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(f.AdditionalProperties,
        "url"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(f.toMap())
}

// toMap converts the FotaV2CallbackRegistrationResult object to a map representation for JSON marshaling.
func (f FotaV2CallbackRegistrationResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, f.AdditionalProperties)
    if f.Url != nil {
        structMap["url"] = f.Url
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for FotaV2CallbackRegistrationResult.
// It customizes the JSON unmarshaling process for FotaV2CallbackRegistrationResult objects.
func (f *FotaV2CallbackRegistrationResult) UnmarshalJSON(input []byte) error {
    var temp tempFotaV2CallbackRegistrationResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "url")
    if err != nil {
    	return err
    }
    f.AdditionalProperties = additionalProperties
    
    f.Url = temp.Url
    return nil
}

// tempFotaV2CallbackRegistrationResult is a temporary struct used for validating the fields of FotaV2CallbackRegistrationResult.
type tempFotaV2CallbackRegistrationResult  struct {
    Url *string `json:"url,omitempty"`
}
