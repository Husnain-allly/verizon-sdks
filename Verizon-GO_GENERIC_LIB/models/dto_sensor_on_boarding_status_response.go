/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DtoSensorOnBoardingStatusResponse represents a DtoSensorOnBoardingStatusResponse struct.
type DtoSensorOnBoardingStatusResponse struct {
    Events []DtoSensorBoardingEvent `json:"events,omitempty"`
}

// String implements the fmt.Stringer interface for DtoSensorOnBoardingStatusResponse,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoSensorOnBoardingStatusResponse) String() string {
    return fmt.Sprintf(
    	"DtoSensorOnBoardingStatusResponse[Events=%v]",
    	d.Events)
}

// MarshalJSON implements the json.Marshaler interface for DtoSensorOnBoardingStatusResponse.
// It customizes the JSON marshaling process for DtoSensorOnBoardingStatusResponse objects.
func (d DtoSensorOnBoardingStatusResponse) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(d.toMap())
}

// toMap converts the DtoSensorOnBoardingStatusResponse object to a map representation for JSON marshaling.
func (d DtoSensorOnBoardingStatusResponse) toMap() map[string]any {
    structMap := make(map[string]any)
    if d.Events != nil {
        structMap["events"] = d.Events
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoSensorOnBoardingStatusResponse.
// It customizes the JSON unmarshaling process for DtoSensorOnBoardingStatusResponse objects.
func (d *DtoSensorOnBoardingStatusResponse) UnmarshalJSON(input []byte) error {
    var temp tempDtoSensorOnBoardingStatusResponse
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    d.Events = temp.Events
    return nil
}

// tempDtoSensorOnBoardingStatusResponse is a temporary struct used for validating the fields of DtoSensorOnBoardingStatusResponse.
type tempDtoSensorOnBoardingStatusResponse  struct {
    Events []DtoSensorBoardingEvent `json:"events,omitempty"`
}
