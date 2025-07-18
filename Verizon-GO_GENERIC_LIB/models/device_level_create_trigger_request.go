/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DeviceLevelCreateTriggerRequest represents a DeviceLevelCreateTriggerRequest struct.
type DeviceLevelCreateTriggerRequest struct {
    // The user defined name of the trigger
    TriggerName     *string            `json:"triggerName,omitempty"`
    // The Enterprise Customer Profile Database ID
    EcpdId          *string            `json:"ecpdId,omitempty"`
    // The type of trigger being created or modified
    TriggerCategory *TriggerCategory   `json:"triggerCategory,omitempty"`
    DataTrigger     *DataTrigger2      `json:"dataTrigger,omitempty"`
    Notification    *Notificationarray `json:"notification,omitempty"`
    // A flag to indicate of the trigger is active, true, or not, false
    Active          *Active            `json:"active,omitempty"`
}

// String implements the fmt.Stringer interface for DeviceLevelCreateTriggerRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DeviceLevelCreateTriggerRequest) String() string {
    return fmt.Sprintf(
    	"DeviceLevelCreateTriggerRequest[TriggerName=%v, EcpdId=%v, TriggerCategory=%v, DataTrigger=%v, Notification=%v, Active=%v]",
    	d.TriggerName, d.EcpdId, d.TriggerCategory, d.DataTrigger, d.Notification, d.Active)
}

// MarshalJSON implements the json.Marshaler interface for DeviceLevelCreateTriggerRequest.
// It customizes the JSON marshaling process for DeviceLevelCreateTriggerRequest objects.
func (d DeviceLevelCreateTriggerRequest) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(d.toMap())
}

// toMap converts the DeviceLevelCreateTriggerRequest object to a map representation for JSON marshaling.
func (d DeviceLevelCreateTriggerRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    if d.TriggerName != nil {
        structMap["triggerName"] = d.TriggerName
    }
    if d.EcpdId != nil {
        structMap["ecpdId"] = d.EcpdId
    }
    if d.TriggerCategory != nil {
        structMap["triggerCategory"] = d.TriggerCategory
    }
    if d.DataTrigger != nil {
        structMap["dataTrigger"] = d.DataTrigger.toMap()
    }
    if d.Notification != nil {
        structMap["notification"] = d.Notification.toMap()
    }
    if d.Active != nil {
        structMap["active"] = d.Active
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DeviceLevelCreateTriggerRequest.
// It customizes the JSON unmarshaling process for DeviceLevelCreateTriggerRequest objects.
func (d *DeviceLevelCreateTriggerRequest) UnmarshalJSON(input []byte) error {
    var temp tempDeviceLevelCreateTriggerRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    d.TriggerName = temp.TriggerName
    d.EcpdId = temp.EcpdId
    d.TriggerCategory = temp.TriggerCategory
    d.DataTrigger = temp.DataTrigger
    d.Notification = temp.Notification
    d.Active = temp.Active
    return nil
}

// tempDeviceLevelCreateTriggerRequest is a temporary struct used for validating the fields of DeviceLevelCreateTriggerRequest.
type tempDeviceLevelCreateTriggerRequest  struct {
    TriggerName     *string            `json:"triggerName,omitempty"`
    EcpdId          *string            `json:"ecpdId,omitempty"`
    TriggerCategory *TriggerCategory   `json:"triggerCategory,omitempty"`
    DataTrigger     *DataTrigger2      `json:"dataTrigger,omitempty"`
    Notification    *Notificationarray `json:"notification,omitempty"`
    Active          *Active            `json:"active,omitempty"`
}
