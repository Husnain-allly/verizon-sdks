/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "errors"
    "fmt"
    "log"
    "strings"
    "time"
)

// DiagnosticsObservationResult represents a DiagnosticsObservationResult struct.
// A success response containing the current status of the request.
type DiagnosticsObservationResult struct {
    // Transaction identifier.
    TransactionId        string                 `json:"transactionID"`
    // Status of the request.
    Status               string                 `json:"status"`
    // The date and time of when this request was created.
    CreatedOn            time.Time              `json:"createdOn"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for DiagnosticsObservationResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DiagnosticsObservationResult) String() string {
    return fmt.Sprintf(
    	"DiagnosticsObservationResult[TransactionId=%v, Status=%v, CreatedOn=%v, AdditionalProperties=%v]",
    	d.TransactionId, d.Status, d.CreatedOn, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DiagnosticsObservationResult.
// It customizes the JSON marshaling process for DiagnosticsObservationResult objects.
func (d DiagnosticsObservationResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "transactionID", "status", "createdOn"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DiagnosticsObservationResult object to a map representation for JSON marshaling.
func (d DiagnosticsObservationResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    structMap["transactionID"] = d.TransactionId
    structMap["status"] = d.Status
    structMap["createdOn"] = d.CreatedOn.Format(time.RFC3339)
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DiagnosticsObservationResult.
// It customizes the JSON unmarshaling process for DiagnosticsObservationResult objects.
func (d *DiagnosticsObservationResult) UnmarshalJSON(input []byte) error {
    var temp tempDiagnosticsObservationResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "transactionID", "status", "createdOn")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.TransactionId = *temp.TransactionId
    d.Status = *temp.Status
    CreatedOnVal, err := time.Parse(time.RFC3339, *temp.CreatedOn)
    if err != nil {
        log.Fatalf("Cannot Parse createdOn as % s format.", time.RFC3339)
    }
    d.CreatedOn = CreatedOnVal
    return nil
}

// tempDiagnosticsObservationResult is a temporary struct used for validating the fields of DiagnosticsObservationResult.
type tempDiagnosticsObservationResult  struct {
    TransactionId *string `json:"transactionID"`
    Status        *string `json:"status"`
    CreatedOn     *string `json:"createdOn"`
}

func (d *tempDiagnosticsObservationResult) validate() error {
    var errs []string
    if d.TransactionId == nil {
        errs = append(errs, "required field `transactionID` is missing for type `DiagnosticsObservationResult`")
    }
    if d.Status == nil {
        errs = append(errs, "required field `status` is missing for type `DiagnosticsObservationResult`")
    }
    if d.CreatedOn == nil {
        errs = append(errs, "required field `createdOn` is missing for type `DiagnosticsObservationResult`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
