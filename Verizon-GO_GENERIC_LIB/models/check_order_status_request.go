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

// CheckOrderStatusRequest represents a CheckOrderStatusRequest struct.
// The request body identifies the devices to upload.
type CheckOrderStatusRequest struct {
    // The name of a billing account. An account name is usually numeric, and must include any leading zeros.
    AccountName          string                 `json:"accountName"`
    // The request id from the activation order.
    OrderRequestId       *string                `json:"orderRequestId,omitempty"`
    // The devices to upload, specified by device IDs in a format matching uploadType.
    Devices              []DeviceList           `json:"devices"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for CheckOrderStatusRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c CheckOrderStatusRequest) String() string {
    return fmt.Sprintf(
    	"CheckOrderStatusRequest[AccountName=%v, OrderRequestId=%v, Devices=%v, AdditionalProperties=%v]",
    	c.AccountName, c.OrderRequestId, c.Devices, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for CheckOrderStatusRequest.
// It customizes the JSON marshaling process for CheckOrderStatusRequest objects.
func (c CheckOrderStatusRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "accountName", "orderRequestId", "devices"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the CheckOrderStatusRequest object to a map representation for JSON marshaling.
func (c CheckOrderStatusRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    structMap["accountName"] = c.AccountName
    if c.OrderRequestId != nil {
        structMap["orderRequestId"] = c.OrderRequestId
    }
    structMap["devices"] = c.Devices
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for CheckOrderStatusRequest.
// It customizes the JSON unmarshaling process for CheckOrderStatusRequest objects.
func (c *CheckOrderStatusRequest) UnmarshalJSON(input []byte) error {
    var temp tempCheckOrderStatusRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "accountName", "orderRequestId", "devices")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.AccountName = *temp.AccountName
    c.OrderRequestId = temp.OrderRequestId
    c.Devices = *temp.Devices
    return nil
}

// tempCheckOrderStatusRequest is a temporary struct used for validating the fields of CheckOrderStatusRequest.
type tempCheckOrderStatusRequest  struct {
    AccountName    *string       `json:"accountName"`
    OrderRequestId *string       `json:"orderRequestId,omitempty"`
    Devices        *[]DeviceList `json:"devices"`
}

func (c *tempCheckOrderStatusRequest) validate() error {
    var errs []string
    if c.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `CheckOrderStatusRequest`")
    }
    if c.Devices == nil {
        errs = append(errs, "required field `devices` is missing for type `CheckOrderStatusRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
