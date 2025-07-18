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

// V3TimeWindow represents a V3TimeWindow struct.
// Time window.
type V3TimeWindow struct {
    // Start hour in range [0..23], current hour >= startTime.
    StartTime            int                    `json:"startTime"`
    // End hour in range [1..24], current hour < endTime.
    EndTime              int                    `json:"endTime"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for V3TimeWindow,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (v V3TimeWindow) String() string {
    return fmt.Sprintf(
    	"V3TimeWindow[StartTime=%v, EndTime=%v, AdditionalProperties=%v]",
    	v.StartTime, v.EndTime, v.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for V3TimeWindow.
// It customizes the JSON marshaling process for V3TimeWindow objects.
func (v V3TimeWindow) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(v.AdditionalProperties,
        "startTime", "endTime"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(v.toMap())
}

// toMap converts the V3TimeWindow object to a map representation for JSON marshaling.
func (v V3TimeWindow) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, v.AdditionalProperties)
    structMap["startTime"] = v.StartTime
    structMap["endTime"] = v.EndTime
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for V3TimeWindow.
// It customizes the JSON unmarshaling process for V3TimeWindow objects.
func (v *V3TimeWindow) UnmarshalJSON(input []byte) error {
    var temp tempV3TimeWindow
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "startTime", "endTime")
    if err != nil {
    	return err
    }
    v.AdditionalProperties = additionalProperties
    
    v.StartTime = *temp.StartTime
    v.EndTime = *temp.EndTime
    return nil
}

// tempV3TimeWindow is a temporary struct used for validating the fields of V3TimeWindow.
type tempV3TimeWindow  struct {
    StartTime *int `json:"startTime"`
    EndTime   *int `json:"endTime"`
}

func (v *tempV3TimeWindow) validate() error {
    var errs []string
    if v.StartTime == nil {
        errs = append(errs, "required field `startTime` is missing for type `V3TimeWindow`")
    }
    if v.EndTime == nil {
        errs = append(errs, "required field `endTime` is missing for type `V3TimeWindow`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
