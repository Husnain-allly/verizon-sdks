/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// KpiInfoList represents a KpiInfoList struct.
type KpiInfoList struct {
    KpiInfoList          []KpiInfo              `json:"KpiInfoList,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for KpiInfoList,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (k KpiInfoList) String() string {
    return fmt.Sprintf(
    	"KpiInfoList[KpiInfoList=%v, AdditionalProperties=%v]",
    	k.KpiInfoList, k.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for KpiInfoList.
// It customizes the JSON marshaling process for KpiInfoList objects.
func (k KpiInfoList) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(k.AdditionalProperties,
        "KpiInfoList"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(k.toMap())
}

// toMap converts the KpiInfoList object to a map representation for JSON marshaling.
func (k KpiInfoList) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, k.AdditionalProperties)
    if k.KpiInfoList != nil {
        structMap["KpiInfoList"] = k.KpiInfoList
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for KpiInfoList.
// It customizes the JSON unmarshaling process for KpiInfoList objects.
func (k *KpiInfoList) UnmarshalJSON(input []byte) error {
    var temp tempKpiInfoList
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "KpiInfoList")
    if err != nil {
    	return err
    }
    k.AdditionalProperties = additionalProperties
    
    k.KpiInfoList = temp.KpiInfoList
    return nil
}

// tempKpiInfoList is a temporary struct used for validating the fields of KpiInfoList.
type tempKpiInfoList  struct {
    KpiInfoList []KpiInfo `json:"KpiInfoList,omitempty"`
}
