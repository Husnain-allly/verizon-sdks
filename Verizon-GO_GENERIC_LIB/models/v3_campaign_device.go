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

// V3CampaignDevice represents a V3CampaignDevice struct.
// Campaign history.
type V3CampaignDevice struct {
    // Total device count.
    TotalDevice          *int                   `json:"totalDevice,omitempty"`
    // Has more report flag.
    HasMoreData          bool                   `json:"hasMoreData"`
    // Device identifier.
    LastSeenDeviceId     *string                `json:"lastSeenDeviceId,omitempty"`
    // Maximum page size.
    MaxPageSize          int                    `json:"maxPageSize"`
    // List of devices with id in IMEI.
    DeviceList           []V3DeviceStatus       `json:"deviceList"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for V3CampaignDevice,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (v V3CampaignDevice) String() string {
    return fmt.Sprintf(
    	"V3CampaignDevice[TotalDevice=%v, HasMoreData=%v, LastSeenDeviceId=%v, MaxPageSize=%v, DeviceList=%v, AdditionalProperties=%v]",
    	v.TotalDevice, v.HasMoreData, v.LastSeenDeviceId, v.MaxPageSize, v.DeviceList, v.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for V3CampaignDevice.
// It customizes the JSON marshaling process for V3CampaignDevice objects.
func (v V3CampaignDevice) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(v.AdditionalProperties,
        "totalDevice", "hasMoreData", "lastSeenDeviceId", "maxPageSize", "deviceList"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(v.toMap())
}

// toMap converts the V3CampaignDevice object to a map representation for JSON marshaling.
func (v V3CampaignDevice) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, v.AdditionalProperties)
    if v.TotalDevice != nil {
        structMap["totalDevice"] = v.TotalDevice
    }
    structMap["hasMoreData"] = v.HasMoreData
    if v.LastSeenDeviceId != nil {
        structMap["lastSeenDeviceId"] = v.LastSeenDeviceId
    }
    structMap["maxPageSize"] = v.MaxPageSize
    structMap["deviceList"] = v.DeviceList
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for V3CampaignDevice.
// It customizes the JSON unmarshaling process for V3CampaignDevice objects.
func (v *V3CampaignDevice) UnmarshalJSON(input []byte) error {
    var temp tempV3CampaignDevice
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "totalDevice", "hasMoreData", "lastSeenDeviceId", "maxPageSize", "deviceList")
    if err != nil {
    	return err
    }
    v.AdditionalProperties = additionalProperties
    
    v.TotalDevice = temp.TotalDevice
    v.HasMoreData = *temp.HasMoreData
    v.LastSeenDeviceId = temp.LastSeenDeviceId
    v.MaxPageSize = *temp.MaxPageSize
    v.DeviceList = *temp.DeviceList
    return nil
}

// tempV3CampaignDevice is a temporary struct used for validating the fields of V3CampaignDevice.
type tempV3CampaignDevice  struct {
    TotalDevice      *int              `json:"totalDevice,omitempty"`
    HasMoreData      *bool             `json:"hasMoreData"`
    LastSeenDeviceId *string           `json:"lastSeenDeviceId,omitempty"`
    MaxPageSize      *int              `json:"maxPageSize"`
    DeviceList       *[]V3DeviceStatus `json:"deviceList"`
}

func (v *tempV3CampaignDevice) validate() error {
    var errs []string
    if v.HasMoreData == nil {
        errs = append(errs, "required field `hasMoreData` is missing for type `V3CampaignDevice`")
    }
    if v.MaxPageSize == nil {
        errs = append(errs, "required field `maxPageSize` is missing for type `V3CampaignDevice`")
    }
    if v.DeviceList == nil {
        errs = append(errs, "required field `deviceList` is missing for type `V3CampaignDevice`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
