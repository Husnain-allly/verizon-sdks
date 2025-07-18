/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Target represents a Target struct.
// Target resource definition.
type Target struct {
    // The endpoint for data streams.
    Address              *string                `json:"address,omitempty"`
    // The transport format.
    Addressscheme        *string                `json:"addressscheme,omitempty"`
    // The billing account ID.
    Billingaccountid     *string                `json:"billingaccountid,omitempty"`
    // The date the resource was created.
    Createdon            *string                `json:"createdon,omitempty"`
    // Security identification string.
    Externalid           *string                `json:"externalid,omitempty"`
    // ThingSpace unique ID for the target that was created.
    Id                   *string                `json:"id,omitempty"`
    // Identifies the resource kind. Targets are ts.target.
    Kind                 *string                `json:"kind,omitempty"`
    // The date the resource was last updated.
    Lastupdated          *string                `json:"lastupdated,omitempty"`
    // Name of the target.
    Name                 *string                `json:"name,omitempty"`
    // AWS region value.
    Region               *string                `json:"region,omitempty"`
    // Version of the underlying schema resource.
    Version              *string                `json:"version,omitempty"`
    // The version of the resource.
    Versionid            *string                `json:"versionid,omitempty"`
    // Description of the target.
    Description          *string                `json:"description,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Target,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (t Target) String() string {
    return fmt.Sprintf(
    	"Target[Address=%v, Addressscheme=%v, Billingaccountid=%v, Createdon=%v, Externalid=%v, Id=%v, Kind=%v, Lastupdated=%v, Name=%v, Region=%v, Version=%v, Versionid=%v, Description=%v, AdditionalProperties=%v]",
    	t.Address, t.Addressscheme, t.Billingaccountid, t.Createdon, t.Externalid, t.Id, t.Kind, t.Lastupdated, t.Name, t.Region, t.Version, t.Versionid, t.Description, t.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Target.
// It customizes the JSON marshaling process for Target objects.
func (t Target) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(t.AdditionalProperties,
        "address", "addressscheme", "billingaccountid", "createdon", "externalid", "id", "kind", "lastupdated", "name", "region", "version", "versionid", "description"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(t.toMap())
}

// toMap converts the Target object to a map representation for JSON marshaling.
func (t Target) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, t.AdditionalProperties)
    if t.Address != nil {
        structMap["address"] = t.Address
    }
    if t.Addressscheme != nil {
        structMap["addressscheme"] = t.Addressscheme
    }
    if t.Billingaccountid != nil {
        structMap["billingaccountid"] = t.Billingaccountid
    }
    if t.Createdon != nil {
        structMap["createdon"] = t.Createdon
    }
    if t.Externalid != nil {
        structMap["externalid"] = t.Externalid
    }
    if t.Id != nil {
        structMap["id"] = t.Id
    }
    if t.Kind != nil {
        structMap["kind"] = t.Kind
    }
    if t.Lastupdated != nil {
        structMap["lastupdated"] = t.Lastupdated
    }
    if t.Name != nil {
        structMap["name"] = t.Name
    }
    if t.Region != nil {
        structMap["region"] = t.Region
    }
    if t.Version != nil {
        structMap["version"] = t.Version
    }
    if t.Versionid != nil {
        structMap["versionid"] = t.Versionid
    }
    if t.Description != nil {
        structMap["description"] = t.Description
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Target.
// It customizes the JSON unmarshaling process for Target objects.
func (t *Target) UnmarshalJSON(input []byte) error {
    var temp tempTarget
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "address", "addressscheme", "billingaccountid", "createdon", "externalid", "id", "kind", "lastupdated", "name", "region", "version", "versionid", "description")
    if err != nil {
    	return err
    }
    t.AdditionalProperties = additionalProperties
    
    t.Address = temp.Address
    t.Addressscheme = temp.Addressscheme
    t.Billingaccountid = temp.Billingaccountid
    t.Createdon = temp.Createdon
    t.Externalid = temp.Externalid
    t.Id = temp.Id
    t.Kind = temp.Kind
    t.Lastupdated = temp.Lastupdated
    t.Name = temp.Name
    t.Region = temp.Region
    t.Version = temp.Version
    t.Versionid = temp.Versionid
    t.Description = temp.Description
    return nil
}

// tempTarget is a temporary struct used for validating the fields of Target.
type tempTarget  struct {
    Address          *string `json:"address,omitempty"`
    Addressscheme    *string `json:"addressscheme,omitempty"`
    Billingaccountid *string `json:"billingaccountid,omitempty"`
    Createdon        *string `json:"createdon,omitempty"`
    Externalid       *string `json:"externalid,omitempty"`
    Id               *string `json:"id,omitempty"`
    Kind             *string `json:"kind,omitempty"`
    Lastupdated      *string `json:"lastupdated,omitempty"`
    Name             *string `json:"name,omitempty"`
    Region           *string `json:"region,omitempty"`
    Version          *string `json:"version,omitempty"`
    Versionid        *string `json:"versionid,omitempty"`
    Description      *string `json:"description,omitempty"`
}
