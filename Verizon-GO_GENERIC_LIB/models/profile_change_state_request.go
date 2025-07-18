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

// ProfileChangeStateRequest represents a ProfileChangeStateRequest struct.
type ProfileChangeStateRequest struct {
    Devices              []DeviceList           `json:"devices"`
    AccountName          string                 `json:"accountName"`
    SmsrOid              string                 `json:"smsrOid"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for ProfileChangeStateRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (p ProfileChangeStateRequest) String() string {
    return fmt.Sprintf(
    	"ProfileChangeStateRequest[Devices=%v, AccountName=%v, SmsrOid=%v, AdditionalProperties=%v]",
    	p.Devices, p.AccountName, p.SmsrOid, p.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for ProfileChangeStateRequest.
// It customizes the JSON marshaling process for ProfileChangeStateRequest objects.
func (p ProfileChangeStateRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(p.AdditionalProperties,
        "devices", "accountName", "smsrOid"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(p.toMap())
}

// toMap converts the ProfileChangeStateRequest object to a map representation for JSON marshaling.
func (p ProfileChangeStateRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, p.AdditionalProperties)
    structMap["devices"] = p.Devices
    structMap["accountName"] = p.AccountName
    structMap["smsrOid"] = p.SmsrOid
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ProfileChangeStateRequest.
// It customizes the JSON unmarshaling process for ProfileChangeStateRequest objects.
func (p *ProfileChangeStateRequest) UnmarshalJSON(input []byte) error {
    var temp tempProfileChangeStateRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "devices", "accountName", "smsrOid")
    if err != nil {
    	return err
    }
    p.AdditionalProperties = additionalProperties
    
    p.Devices = *temp.Devices
    p.AccountName = *temp.AccountName
    p.SmsrOid = *temp.SmsrOid
    return nil
}

// tempProfileChangeStateRequest is a temporary struct used for validating the fields of ProfileChangeStateRequest.
type tempProfileChangeStateRequest  struct {
    Devices     *[]DeviceList `json:"devices"`
    AccountName *string       `json:"accountName"`
    SmsrOid     *string       `json:"smsrOid"`
}

func (p *tempProfileChangeStateRequest) validate() error {
    var errs []string
    if p.Devices == nil {
        errs = append(errs, "required field `devices` is missing for type `ProfileChangeStateRequest`")
    }
    if p.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `ProfileChangeStateRequest`")
    }
    if p.SmsrOid == nil {
        errs = append(errs, "required field `smsrOid` is missing for type `ProfileChangeStateRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
