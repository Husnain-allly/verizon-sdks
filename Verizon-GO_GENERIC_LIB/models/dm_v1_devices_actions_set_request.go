/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DmV1DevicesActionsSetRequest represents a DmV1DevicesActionsSetRequest struct.
type DmV1DevicesActionsSetRequest struct {
    // The numeric account name, which must include leading zeros
    Accountname          *string                           `json:"accountname,omitempty"`
    Configuration        *DtoDeviceActionSetConfiguration1 `json:"configuration,omitempty"`
    // Device identifiers, one or more are required
    Resourceidentifier   *DtoDeviceResourceIdentifier1     `json:"resourceidentifier,omitempty"`
    AdditionalProperties map[string]interface{}            `json:"_"`
}

// String implements the fmt.Stringer interface for DmV1DevicesActionsSetRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DmV1DevicesActionsSetRequest) String() string {
    return fmt.Sprintf(
    	"DmV1DevicesActionsSetRequest[Accountname=%v, Configuration=%v, Resourceidentifier=%v, AdditionalProperties=%v]",
    	d.Accountname, d.Configuration, d.Resourceidentifier, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DmV1DevicesActionsSetRequest.
// It customizes the JSON marshaling process for DmV1DevicesActionsSetRequest objects.
func (d DmV1DevicesActionsSetRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "accountname", "configuration", "resourceidentifier"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DmV1DevicesActionsSetRequest object to a map representation for JSON marshaling.
func (d DmV1DevicesActionsSetRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    if d.Accountname != nil {
        structMap["accountname"] = d.Accountname
    }
    if d.Configuration != nil {
        structMap["configuration"] = d.Configuration.toMap()
    }
    if d.Resourceidentifier != nil {
        structMap["resourceidentifier"] = d.Resourceidentifier.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DmV1DevicesActionsSetRequest.
// It customizes the JSON unmarshaling process for DmV1DevicesActionsSetRequest objects.
func (d *DmV1DevicesActionsSetRequest) UnmarshalJSON(input []byte) error {
    var temp tempDmV1DevicesActionsSetRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountname", "configuration", "resourceidentifier")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.Accountname = temp.Accountname
    d.Configuration = temp.Configuration
    d.Resourceidentifier = temp.Resourceidentifier
    return nil
}

// tempDmV1DevicesActionsSetRequest is a temporary struct used for validating the fields of DmV1DevicesActionsSetRequest.
type tempDmV1DevicesActionsSetRequest  struct {
    Accountname        *string                           `json:"accountname,omitempty"`
    Configuration      *DtoDeviceActionSetConfiguration1 `json:"configuration,omitempty"`
    Resourceidentifier *DtoDeviceResourceIdentifier1     `json:"resourceidentifier,omitempty"`
}
