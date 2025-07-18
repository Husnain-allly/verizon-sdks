/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Location represents a Location struct.
// Device location information.
type Location struct {
    // MDN.
    Msid                 *string                `json:"msid,omitempty"`
    // Position data.
    Pd                   *PositionData          `json:"pd,omitempty"`
    // Position error.
    Error                *PositionError         `json:"error,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Location,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (l Location) String() string {
    return fmt.Sprintf(
    	"Location[Msid=%v, Pd=%v, Error=%v, AdditionalProperties=%v]",
    	l.Msid, l.Pd, l.Error, l.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Location.
// It customizes the JSON marshaling process for Location objects.
func (l Location) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(l.AdditionalProperties,
        "msid", "pd", "error"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(l.toMap())
}

// toMap converts the Location object to a map representation for JSON marshaling.
func (l Location) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, l.AdditionalProperties)
    if l.Msid != nil {
        structMap["msid"] = l.Msid
    }
    if l.Pd != nil {
        structMap["pd"] = l.Pd.toMap()
    }
    if l.Error != nil {
        structMap["error"] = l.Error.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Location.
// It customizes the JSON unmarshaling process for Location objects.
func (l *Location) UnmarshalJSON(input []byte) error {
    var temp tempLocation
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "msid", "pd", "error")
    if err != nil {
    	return err
    }
    l.AdditionalProperties = additionalProperties
    
    l.Msid = temp.Msid
    l.Pd = temp.Pd
    l.Error = temp.Error
    return nil
}

// tempLocation is a temporary struct used for validating the fields of Location.
type tempLocation  struct {
    Msid  *string        `json:"msid,omitempty"`
    Pd    *PositionData  `json:"pd,omitempty"`
    Error *PositionError `json:"error,omitempty"`
}
