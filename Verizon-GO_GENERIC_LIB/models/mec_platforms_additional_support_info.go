/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// MecPlatformsAdditionalSupportInfo represents a MecPlatformsAdditionalSupportInfo struct.
// Additional service support information for the MEC platform.
type MecPlatformsAdditionalSupportInfo struct {
    // Type of additional service support information for the MEC platform.
    Type *string                                `json:"type,omitempty"`
    // Data about additional service support information for the MEC platform.
    Data *MecPlatformsAdditionalSupportInfoData `json:"data,omitempty"`
}

// String implements the fmt.Stringer interface for MecPlatformsAdditionalSupportInfo,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (m MecPlatformsAdditionalSupportInfo) String() string {
    return fmt.Sprintf(
    	"MecPlatformsAdditionalSupportInfo[Type=%v, Data=%v]",
    	m.Type, m.Data)
}

// MarshalJSON implements the json.Marshaler interface for MecPlatformsAdditionalSupportInfo.
// It customizes the JSON marshaling process for MecPlatformsAdditionalSupportInfo objects.
func (m MecPlatformsAdditionalSupportInfo) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(m.toMap())
}

// toMap converts the MecPlatformsAdditionalSupportInfo object to a map representation for JSON marshaling.
func (m MecPlatformsAdditionalSupportInfo) toMap() map[string]any {
    structMap := make(map[string]any)
    if m.Type != nil {
        structMap["type"] = m.Type
    }
    if m.Data != nil {
        structMap["data"] = m.Data.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for MecPlatformsAdditionalSupportInfo.
// It customizes the JSON unmarshaling process for MecPlatformsAdditionalSupportInfo objects.
func (m *MecPlatformsAdditionalSupportInfo) UnmarshalJSON(input []byte) error {
    var temp tempMecPlatformsAdditionalSupportInfo
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    m.Type = temp.Type
    m.Data = temp.Data
    return nil
}

// tempMecPlatformsAdditionalSupportInfo is a temporary struct used for validating the fields of MecPlatformsAdditionalSupportInfo.
type tempMecPlatformsAdditionalSupportInfo  struct {
    Type *string                                `json:"type,omitempty"`
    Data *MecPlatformsAdditionalSupportInfoData `json:"data,omitempty"`
}
