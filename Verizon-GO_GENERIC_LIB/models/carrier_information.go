/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// CarrierInformation represents a CarrierInformation struct.
// Information about the carrier.
type CarrierInformation struct {
    // The carrier that will perform the activation. This parameter is only required if you have more than one carrier.
    CarrierName          *string                `json:"carrierName,omitempty"`
    // The service plan code that is assigned to the device.
    ServicePlan          *string                `json:"servicePlan,omitempty"`
    // The device state. Valid values include: Activate, Suspend, Deactive, Pre-active.
    State                *string                `json:"state,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for CarrierInformation,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c CarrierInformation) String() string {
    return fmt.Sprintf(
    	"CarrierInformation[CarrierName=%v, ServicePlan=%v, State=%v, AdditionalProperties=%v]",
    	c.CarrierName, c.ServicePlan, c.State, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for CarrierInformation.
// It customizes the JSON marshaling process for CarrierInformation objects.
func (c CarrierInformation) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "carrierName", "servicePlan", "state"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the CarrierInformation object to a map representation for JSON marshaling.
func (c CarrierInformation) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    if c.CarrierName != nil {
        structMap["carrierName"] = c.CarrierName
    }
    if c.ServicePlan != nil {
        structMap["servicePlan"] = c.ServicePlan
    }
    if c.State != nil {
        structMap["state"] = c.State
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for CarrierInformation.
// It customizes the JSON unmarshaling process for CarrierInformation objects.
func (c *CarrierInformation) UnmarshalJSON(input []byte) error {
    var temp tempCarrierInformation
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "carrierName", "servicePlan", "state")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.CarrierName = temp.CarrierName
    c.ServicePlan = temp.ServicePlan
    c.State = temp.State
    return nil
}

// tempCarrierInformation is a temporary struct used for validating the fields of CarrierInformation.
type tempCarrierInformation  struct {
    CarrierName *string `json:"carrierName,omitempty"`
    ServicePlan *string `json:"servicePlan,omitempty"`
    State       *string `json:"state,omitempty"`
}
