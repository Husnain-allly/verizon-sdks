/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// SensitivityParameters represents a SensitivityParameters struct.
// Details for sensitivity parameters.
type SensitivityParameters struct {
    // The maximum value of the threshold in the units being measured.
    AbnormalMaxValue     *float64 `json:"abnormalMaxValue,omitempty"`
    // If abnormal values are being monitored.<br />true - Monitor for abnormal values<br />false - Do not monitor for abnormal values.
    EnableAbnormal       *bool    `json:"enableAbnormal,omitempty"`
    // If very abnormal values are being monitored.<br />true - Monitor for very abnormal values<br />false - Do not monitor for very abnormal values.
    EnableVeryAbnormal   *bool    `json:"enableVeryAbnormal,omitempty"`
    // The maximum value of the threshold in the units being measured.
    VeryAbnormalMaxValue *float64 `json:"veryAbnormalMaxValue,omitempty"`
}

// String implements the fmt.Stringer interface for SensitivityParameters,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (s SensitivityParameters) String() string {
    return fmt.Sprintf(
    	"SensitivityParameters[AbnormalMaxValue=%v, EnableAbnormal=%v, EnableVeryAbnormal=%v, VeryAbnormalMaxValue=%v]",
    	s.AbnormalMaxValue, s.EnableAbnormal, s.EnableVeryAbnormal, s.VeryAbnormalMaxValue)
}

// MarshalJSON implements the json.Marshaler interface for SensitivityParameters.
// It customizes the JSON marshaling process for SensitivityParameters objects.
func (s SensitivityParameters) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(s.toMap())
}

// toMap converts the SensitivityParameters object to a map representation for JSON marshaling.
func (s SensitivityParameters) toMap() map[string]any {
    structMap := make(map[string]any)
    if s.AbnormalMaxValue != nil {
        structMap["abnormalMaxValue"] = s.AbnormalMaxValue
    }
    if s.EnableAbnormal != nil {
        structMap["enableAbnormal"] = s.EnableAbnormal
    }
    if s.EnableVeryAbnormal != nil {
        structMap["enableVeryAbnormal"] = s.EnableVeryAbnormal
    }
    if s.VeryAbnormalMaxValue != nil {
        structMap["veryAbnormalMaxValue"] = s.VeryAbnormalMaxValue
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for SensitivityParameters.
// It customizes the JSON unmarshaling process for SensitivityParameters objects.
func (s *SensitivityParameters) UnmarshalJSON(input []byte) error {
    var temp tempSensitivityParameters
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    s.AbnormalMaxValue = temp.AbnormalMaxValue
    s.EnableAbnormal = temp.EnableAbnormal
    s.EnableVeryAbnormal = temp.EnableVeryAbnormal
    s.VeryAbnormalMaxValue = temp.VeryAbnormalMaxValue
    return nil
}

// tempSensitivityParameters is a temporary struct used for validating the fields of SensitivityParameters.
type tempSensitivityParameters  struct {
    AbnormalMaxValue     *float64 `json:"abnormalMaxValue,omitempty"`
    EnableAbnormal       *bool    `json:"enableAbnormal,omitempty"`
    EnableVeryAbnormal   *bool    `json:"enableVeryAbnormal,omitempty"`
    VeryAbnormalMaxValue *float64 `json:"veryAbnormalMaxValue,omitempty"`
}
