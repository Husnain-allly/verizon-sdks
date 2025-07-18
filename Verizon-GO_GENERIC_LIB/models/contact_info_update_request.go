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

// ContactInfoUpdateRequest represents a ContactInfoUpdateRequest struct.
// Request to update contact information.
type ContactInfoUpdateRequest struct {
    // The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.
    PrimaryPlaceOfUse    PlaceOfUse             `json:"primaryPlaceOfUse"`
    // The name of the billing account that the devices belong to. An account name is usually numeric, and must include any leading zeros.
    AccountName          *string                `json:"accountName,omitempty"`
    // A list of the devices that you want to change, specified by device identifier. You only need to provide one identifier per device. Do not include accountName, groupName, customFields, or servicePlan if you use this parameter.
    Devices              []AccountDeviceList    `json:"devices,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for ContactInfoUpdateRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c ContactInfoUpdateRequest) String() string {
    return fmt.Sprintf(
    	"ContactInfoUpdateRequest[PrimaryPlaceOfUse=%v, AccountName=%v, Devices=%v, AdditionalProperties=%v]",
    	c.PrimaryPlaceOfUse, c.AccountName, c.Devices, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for ContactInfoUpdateRequest.
// It customizes the JSON marshaling process for ContactInfoUpdateRequest objects.
func (c ContactInfoUpdateRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "primaryPlaceOfUse", "accountName", "devices"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the ContactInfoUpdateRequest object to a map representation for JSON marshaling.
func (c ContactInfoUpdateRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    structMap["primaryPlaceOfUse"] = c.PrimaryPlaceOfUse.toMap()
    if c.AccountName != nil {
        structMap["accountName"] = c.AccountName
    }
    if c.Devices != nil {
        structMap["devices"] = c.Devices
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ContactInfoUpdateRequest.
// It customizes the JSON unmarshaling process for ContactInfoUpdateRequest objects.
func (c *ContactInfoUpdateRequest) UnmarshalJSON(input []byte) error {
    var temp tempContactInfoUpdateRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "primaryPlaceOfUse", "accountName", "devices")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.PrimaryPlaceOfUse = *temp.PrimaryPlaceOfUse
    c.AccountName = temp.AccountName
    c.Devices = temp.Devices
    return nil
}

// tempContactInfoUpdateRequest is a temporary struct used for validating the fields of ContactInfoUpdateRequest.
type tempContactInfoUpdateRequest  struct {
    PrimaryPlaceOfUse *PlaceOfUse         `json:"primaryPlaceOfUse"`
    AccountName       *string             `json:"accountName,omitempty"`
    Devices           []AccountDeviceList `json:"devices,omitempty"`
}

func (c *tempContactInfoUpdateRequest) validate() error {
    var errs []string
    if c.PrimaryPlaceOfUse == nil {
        errs = append(errs, "required field `primaryPlaceOfUse` is missing for type `ContactInfoUpdateRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
