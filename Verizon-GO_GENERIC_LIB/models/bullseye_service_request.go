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

// BullseyeServiceRequest represents a BullseyeServiceRequest struct.
// Account number and list of devices.
type BullseyeServiceRequest struct {
    // A list of devices.
    DeviceList           []DeviceServiceRequest `json:"deviceList"`
    // A unique identifier for an account.
    AccountNumber        string                 `json:"accountNumber"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for BullseyeServiceRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (b BullseyeServiceRequest) String() string {
    return fmt.Sprintf(
    	"BullseyeServiceRequest[DeviceList=%v, AccountNumber=%v, AdditionalProperties=%v]",
    	b.DeviceList, b.AccountNumber, b.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for BullseyeServiceRequest.
// It customizes the JSON marshaling process for BullseyeServiceRequest objects.
func (b BullseyeServiceRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(b.AdditionalProperties,
        "deviceList", "accountNumber"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(b.toMap())
}

// toMap converts the BullseyeServiceRequest object to a map representation for JSON marshaling.
func (b BullseyeServiceRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, b.AdditionalProperties)
    structMap["deviceList"] = b.DeviceList
    structMap["accountNumber"] = b.AccountNumber
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for BullseyeServiceRequest.
// It customizes the JSON unmarshaling process for BullseyeServiceRequest objects.
func (b *BullseyeServiceRequest) UnmarshalJSON(input []byte) error {
    var temp tempBullseyeServiceRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "deviceList", "accountNumber")
    if err != nil {
    	return err
    }
    b.AdditionalProperties = additionalProperties
    
    b.DeviceList = *temp.DeviceList
    b.AccountNumber = *temp.AccountNumber
    return nil
}

// tempBullseyeServiceRequest is a temporary struct used for validating the fields of BullseyeServiceRequest.
type tempBullseyeServiceRequest  struct {
    DeviceList    *[]DeviceServiceRequest `json:"deviceList"`
    AccountNumber *string                 `json:"accountNumber"`
}

func (b *tempBullseyeServiceRequest) validate() error {
    var errs []string
    if b.DeviceList == nil {
        errs = append(errs, "required field `deviceList` is missing for type `BullseyeServiceRequest`")
    }
    if b.AccountNumber == nil {
        errs = append(errs, "required field `accountNumber` is missing for type `BullseyeServiceRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
