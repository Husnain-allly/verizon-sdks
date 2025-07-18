/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DataTrigger5 represents a DataTrigger5 struct.
type DataTrigger5 struct {
    FilterCriteria       *AccountLevelFilter           `json:"filterCriteria,omitempty"`
    Condition            *Rateplantype2Condition       `json:"condition,omitempty"`
    // The action taken when trigger conditions are met
    Action               *AccountLevelAction           `json:"action,omitempty"`
    // The condition type being monitored
    ConditionType        *ConditionType                `json:"conditionType,omitempty"`
    // The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To
    Comparitor           *Comparitor                   `json:"comparitor,omitempty"`
    // The threshold value the trigger monitors for
    Threshold            *int                          `json:"threshold,omitempty"`
    // The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits
    ThresholdUnit        *ThresholdUnit                `json:"thresholdUnit,omitempty"`
    // The interval to monitor for the threshold. This can be Daily, Weekly or Monthly
    CycleType            *RulesCycleType               `json:"cycleType,omitempty"`
    AllowanceThreshold   *AllowanceThreshold           `json:"allowanceThreshold,omitempty"`
    DeviceGroup          *DeviceGroupFilterCriteria    `json:"deviceGroup,omitempty"`
    AccountGroupShare    *AccountGroupShareIndividual1 `json:"accountGroupShare,omitempty"`
    AdditionalProperties map[string]interface{}        `json:"_"`
}

// String implements the fmt.Stringer interface for DataTrigger5,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DataTrigger5) String() string {
    return fmt.Sprintf(
    	"DataTrigger5[FilterCriteria=%v, Condition=%v, Action=%v, ConditionType=%v, Comparitor=%v, Threshold=%v, ThresholdUnit=%v, CycleType=%v, AllowanceThreshold=%v, DeviceGroup=%v, AccountGroupShare=%v, AdditionalProperties=%v]",
    	d.FilterCriteria, d.Condition, d.Action, d.ConditionType, d.Comparitor, d.Threshold, d.ThresholdUnit, d.CycleType, d.AllowanceThreshold, d.DeviceGroup, d.AccountGroupShare, d.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for DataTrigger5.
// It customizes the JSON marshaling process for DataTrigger5 objects.
func (d DataTrigger5) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(d.AdditionalProperties,
        "filterCriteria", "condition", "action", "conditionType", "comparitor", "threshold", "thresholdUnit", "cycleType", "allowanceThreshold", "deviceGroup", "accountGroupShare"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(d.toMap())
}

// toMap converts the DataTrigger5 object to a map representation for JSON marshaling.
func (d DataTrigger5) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, d.AdditionalProperties)
    if d.FilterCriteria != nil {
        structMap["filterCriteria"] = d.FilterCriteria.toMap()
    }
    if d.Condition != nil {
        structMap["condition"] = d.Condition.toMap()
    }
    if d.Action != nil {
        structMap["action"] = d.Action
    }
    if d.ConditionType != nil {
        structMap["conditionType"] = d.ConditionType
    }
    if d.Comparitor != nil {
        structMap["comparitor"] = d.Comparitor
    }
    if d.Threshold != nil {
        structMap["threshold"] = d.Threshold
    }
    if d.ThresholdUnit != nil {
        structMap["thresholdUnit"] = d.ThresholdUnit
    }
    if d.CycleType != nil {
        structMap["cycleType"] = d.CycleType
    }
    if d.AllowanceThreshold != nil {
        structMap["allowanceThreshold"] = d.AllowanceThreshold.toMap()
    }
    if d.DeviceGroup != nil {
        structMap["deviceGroup"] = d.DeviceGroup.toMap()
    }
    if d.AccountGroupShare != nil {
        structMap["accountGroupShare"] = d.AccountGroupShare.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DataTrigger5.
// It customizes the JSON unmarshaling process for DataTrigger5 objects.
func (d *DataTrigger5) UnmarshalJSON(input []byte) error {
    var temp tempDataTrigger5
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "filterCriteria", "condition", "action", "conditionType", "comparitor", "threshold", "thresholdUnit", "cycleType", "allowanceThreshold", "deviceGroup", "accountGroupShare")
    if err != nil {
    	return err
    }
    d.AdditionalProperties = additionalProperties
    
    d.FilterCriteria = temp.FilterCriteria
    d.Condition = temp.Condition
    d.Action = temp.Action
    d.ConditionType = temp.ConditionType
    d.Comparitor = temp.Comparitor
    d.Threshold = temp.Threshold
    d.ThresholdUnit = temp.ThresholdUnit
    d.CycleType = temp.CycleType
    d.AllowanceThreshold = temp.AllowanceThreshold
    d.DeviceGroup = temp.DeviceGroup
    d.AccountGroupShare = temp.AccountGroupShare
    return nil
}

// tempDataTrigger5 is a temporary struct used for validating the fields of DataTrigger5.
type tempDataTrigger5  struct {
    FilterCriteria     *AccountLevelFilter           `json:"filterCriteria,omitempty"`
    Condition          *Rateplantype2Condition       `json:"condition,omitempty"`
    Action             *AccountLevelAction           `json:"action,omitempty"`
    ConditionType      *ConditionType                `json:"conditionType,omitempty"`
    Comparitor         *Comparitor                   `json:"comparitor,omitempty"`
    Threshold          *int                          `json:"threshold,omitempty"`
    ThresholdUnit      *ThresholdUnit                `json:"thresholdUnit,omitempty"`
    CycleType          *RulesCycleType               `json:"cycleType,omitempty"`
    AllowanceThreshold *AllowanceThreshold           `json:"allowanceThreshold,omitempty"`
    DeviceGroup        *DeviceGroupFilterCriteria    `json:"deviceGroup,omitempty"`
    AccountGroupShare  *AccountGroupShareIndividual1 `json:"accountGroupShare,omitempty"`
}
