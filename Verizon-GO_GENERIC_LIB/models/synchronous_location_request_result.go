/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "errors"
    "fmt"
    "strings"
)

// SynchronousLocationRequestResult represents a SynchronousLocationRequestResult struct.
type SynchronousLocationRequestResult struct {
    // The transaction ID of the report.
    Txid                 string                 `json:"txid"`
    // Status of the report.
    Status               ReportStatus           `json:"status"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for SynchronousLocationRequestResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (s SynchronousLocationRequestResult) String() string {
    return fmt.Sprintf(
    	"SynchronousLocationRequestResult[Txid=%v, Status=%v, AdditionalProperties=%v]",
    	s.Txid, s.Status, s.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for SynchronousLocationRequestResult.
// It customizes the JSON marshaling process for SynchronousLocationRequestResult objects.
func (s SynchronousLocationRequestResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(s.AdditionalProperties,
        "txid", "status"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(s.toMap())
}

// toMap converts the SynchronousLocationRequestResult object to a map representation for JSON marshaling.
func (s SynchronousLocationRequestResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, s.AdditionalProperties)
    structMap["txid"] = s.Txid
    structMap["status"] = s.Status
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for SynchronousLocationRequestResult.
// It customizes the JSON unmarshaling process for SynchronousLocationRequestResult objects.
func (s *SynchronousLocationRequestResult) UnmarshalJSON(input []byte) error {
    var temp tempSynchronousLocationRequestResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "txid", "status")
    if err != nil {
    	return err
    }
    s.AdditionalProperties = additionalProperties
    
    s.Txid = *temp.Txid
    s.Status = *temp.Status
    return nil
}

// tempSynchronousLocationRequestResult is a temporary struct used for validating the fields of SynchronousLocationRequestResult.
type tempSynchronousLocationRequestResult  struct {
    Txid   *string       `json:"txid"`
    Status *ReportStatus `json:"status"`
}

func (s *tempSynchronousLocationRequestResult) validate() error {
    var errs []string
    if s.Txid == nil {
        errs = append(errs, "required field `txid` is missing for type `SynchronousLocationRequestResult`")
    }
    if s.Status == nil {
        errs = append(errs, "required field `status` is missing for type `SynchronousLocationRequestResult`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
