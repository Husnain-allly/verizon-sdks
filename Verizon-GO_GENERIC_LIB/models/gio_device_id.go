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

// GioDeviceId represents a GioDeviceId struct.
type GioDeviceId struct {
    Kind string `json:"kind"`
    Id   string `json:"id"`
}

// String implements the fmt.Stringer interface for GioDeviceId,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (g GioDeviceId) String() string {
    return fmt.Sprintf(
    	"GioDeviceId[Kind=%v, Id=%v]",
    	g.Kind, g.Id)
}

// MarshalJSON implements the json.Marshaler interface for GioDeviceId.
// It customizes the JSON marshaling process for GioDeviceId objects.
func (g GioDeviceId) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(g.toMap())
}

// toMap converts the GioDeviceId object to a map representation for JSON marshaling.
func (g GioDeviceId) toMap() map[string]any {
    structMap := make(map[string]any)
    structMap["kind"] = g.Kind
    structMap["id"] = g.Id
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for GioDeviceId.
// It customizes the JSON unmarshaling process for GioDeviceId objects.
func (g *GioDeviceId) UnmarshalJSON(input []byte) error {
    var temp tempGioDeviceId
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    
    g.Kind = *temp.Kind
    g.Id = *temp.Id
    return nil
}

// tempGioDeviceId is a temporary struct used for validating the fields of GioDeviceId.
type tempGioDeviceId  struct {
    Kind *string `json:"kind"`
    Id   *string `json:"id"`
}

func (g *tempGioDeviceId) validate() error {
    var errs []string
    if g.Kind == nil {
        errs = append(errs, "required field `kind` is missing for type `GIODeviceId`")
    }
    if g.Id == nil {
        errs = append(errs, "required field `id` is missing for type `GIODeviceId`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
