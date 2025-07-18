/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// UpgradeListQueryResult represents a UpgradeListQueryResult struct.
// Upgrade information.
type UpgradeListQueryResult struct {
    // True if there are more devices to retrieve.
    HasMoreFlag          *bool                       `json:"hasMoreFlag,omitempty"`
    // If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
    LastSeenUpgradeId    *int                        `json:"lastSeenUpgradeId,omitempty"`
    // Array of upgrade objects with the specified status.
    ReportList           Optional[[]FirmwareUpgrade] `json:"reportList"`
    AdditionalProperties map[string]interface{}      `json:"_"`
}

// String implements the fmt.Stringer interface for UpgradeListQueryResult,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (u UpgradeListQueryResult) String() string {
    return fmt.Sprintf(
    	"UpgradeListQueryResult[HasMoreFlag=%v, LastSeenUpgradeId=%v, ReportList=%v, AdditionalProperties=%v]",
    	u.HasMoreFlag, u.LastSeenUpgradeId, u.ReportList, u.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for UpgradeListQueryResult.
// It customizes the JSON marshaling process for UpgradeListQueryResult objects.
func (u UpgradeListQueryResult) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(u.AdditionalProperties,
        "hasMoreFlag", "lastSeenUpgradeId", "reportList"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(u.toMap())
}

// toMap converts the UpgradeListQueryResult object to a map representation for JSON marshaling.
func (u UpgradeListQueryResult) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, u.AdditionalProperties)
    if u.HasMoreFlag != nil {
        structMap["hasMoreFlag"] = u.HasMoreFlag
    }
    if u.LastSeenUpgradeId != nil {
        structMap["lastSeenUpgradeId"] = u.LastSeenUpgradeId
    }
    if u.ReportList.IsValueSet() {
        if u.ReportList.Value() != nil {
            structMap["reportList"] = u.ReportList.Value()
        } else {
            structMap["reportList"] = nil
        }
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for UpgradeListQueryResult.
// It customizes the JSON unmarshaling process for UpgradeListQueryResult objects.
func (u *UpgradeListQueryResult) UnmarshalJSON(input []byte) error {
    var temp tempUpgradeListQueryResult
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "hasMoreFlag", "lastSeenUpgradeId", "reportList")
    if err != nil {
    	return err
    }
    u.AdditionalProperties = additionalProperties
    
    u.HasMoreFlag = temp.HasMoreFlag
    u.LastSeenUpgradeId = temp.LastSeenUpgradeId
    u.ReportList = temp.ReportList
    return nil
}

// tempUpgradeListQueryResult is a temporary struct used for validating the fields of UpgradeListQueryResult.
type tempUpgradeListQueryResult  struct {
    HasMoreFlag       *bool                       `json:"hasMoreFlag,omitempty"`
    LastSeenUpgradeId *int                        `json:"lastSeenUpgradeId,omitempty"`
    ReportList        Optional[[]FirmwareUpgrade] `json:"reportList"`
}
