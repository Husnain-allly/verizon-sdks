/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// Subscription represents a Subscription struct.
// Subscription resource definition.
type Subscription struct {
    // The number of streaming failures due to faulty configuration.
    Configurationfailures *int                   `json:"configurationfailures,omitempty"`
    // The number of streaming failures due to faulty configuration.
    Createdon             *string                `json:"createdon,omitempty"`
    // Not currently used.
    Delegateid            *string                `json:"delegateid,omitempty"`
    // Description of the subscription.
    Description           *string                `json:"description,omitempty"`
    // Whether the subscription is currently sending data.
    Disabled              *bool                  `json:"disabled,omitempty"`
    // The address to which any error reports should be delivered.
    Email                 *string                `json:"email,omitempty"`
    // Filter for events.
    Filter                *string                `json:"filter,omitempty"`
    // ThingSpace unique ID for the subscription that was created.
    Id                    *string                `json:"id,omitempty"`
    // Identifies the resource kind.
    Kind                  *string                `json:"kind,omitempty"`
    // Possible values: success or fail.
    Laststreamingstatus   *string                `json:"laststreamingstatus,omitempty"`
    // The date and time that the last stream send was attempted.
    Laststreamingtime     *string                `json:"laststreamingtime,omitempty"`
    // The date the resource was last updated.
    Lastupdated           *string                `json:"lastupdated,omitempty"`
    // Name of the subscription.
    Name                  *string                `json:"name,omitempty"`
    // The number of failures due to network problems.
    Networkfailures       *int                   `json:"networkfailures,omitempty"`
    Streamfailures        *int                   `json:"streamfailures,omitempty"`
    // The event type that will be sent in the data stream.
    Streamkind            *string                `json:"streamkind,omitempty"`
    // Target to be used for dispatching events.
    Targetid              *string                `json:"targetid,omitempty"`
    Targettype            *string                `json:"targettype,omitempty"`
    // Version of the underlying schema resource.
    Version               *string                `json:"version,omitempty"`
    // The version of the resource.
    Versionid             *string                `json:"versionid,omitempty"`
    AdditionalProperties  map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for Subscription,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (s Subscription) String() string {
    return fmt.Sprintf(
    	"Subscription[Configurationfailures=%v, Createdon=%v, Delegateid=%v, Description=%v, Disabled=%v, Email=%v, Filter=%v, Id=%v, Kind=%v, Laststreamingstatus=%v, Laststreamingtime=%v, Lastupdated=%v, Name=%v, Networkfailures=%v, Streamfailures=%v, Streamkind=%v, Targetid=%v, Targettype=%v, Version=%v, Versionid=%v, AdditionalProperties=%v]",
    	s.Configurationfailures, s.Createdon, s.Delegateid, s.Description, s.Disabled, s.Email, s.Filter, s.Id, s.Kind, s.Laststreamingstatus, s.Laststreamingtime, s.Lastupdated, s.Name, s.Networkfailures, s.Streamfailures, s.Streamkind, s.Targetid, s.Targettype, s.Version, s.Versionid, s.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for Subscription.
// It customizes the JSON marshaling process for Subscription objects.
func (s Subscription) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(s.AdditionalProperties,
        "configurationfailures", "createdon", "delegateid", "description", "disabled", "email", "filter", "id", "kind", "laststreamingstatus", "laststreamingtime", "lastupdated", "name", "networkfailures", "streamfailures", "streamkind", "targetid", "targettype", "version", "versionid"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(s.toMap())
}

// toMap converts the Subscription object to a map representation for JSON marshaling.
func (s Subscription) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, s.AdditionalProperties)
    if s.Configurationfailures != nil {
        structMap["configurationfailures"] = s.Configurationfailures
    }
    if s.Createdon != nil {
        structMap["createdon"] = s.Createdon
    }
    if s.Delegateid != nil {
        structMap["delegateid"] = s.Delegateid
    }
    if s.Description != nil {
        structMap["description"] = s.Description
    }
    if s.Disabled != nil {
        structMap["disabled"] = s.Disabled
    }
    if s.Email != nil {
        structMap["email"] = s.Email
    }
    if s.Filter != nil {
        structMap["filter"] = s.Filter
    }
    if s.Id != nil {
        structMap["id"] = s.Id
    }
    if s.Kind != nil {
        structMap["kind"] = s.Kind
    }
    if s.Laststreamingstatus != nil {
        structMap["laststreamingstatus"] = s.Laststreamingstatus
    }
    if s.Laststreamingtime != nil {
        structMap["laststreamingtime"] = s.Laststreamingtime
    }
    if s.Lastupdated != nil {
        structMap["lastupdated"] = s.Lastupdated
    }
    if s.Name != nil {
        structMap["name"] = s.Name
    }
    if s.Networkfailures != nil {
        structMap["networkfailures"] = s.Networkfailures
    }
    if s.Streamfailures != nil {
        structMap["streamfailures"] = s.Streamfailures
    }
    if s.Streamkind != nil {
        structMap["streamkind"] = s.Streamkind
    }
    if s.Targetid != nil {
        structMap["targetid"] = s.Targetid
    }
    if s.Targettype != nil {
        structMap["targettype"] = s.Targettype
    }
    if s.Version != nil {
        structMap["version"] = s.Version
    }
    if s.Versionid != nil {
        structMap["versionid"] = s.Versionid
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for Subscription.
// It customizes the JSON unmarshaling process for Subscription objects.
func (s *Subscription) UnmarshalJSON(input []byte) error {
    var temp tempSubscription
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "configurationfailures", "createdon", "delegateid", "description", "disabled", "email", "filter", "id", "kind", "laststreamingstatus", "laststreamingtime", "lastupdated", "name", "networkfailures", "streamfailures", "streamkind", "targetid", "targettype", "version", "versionid")
    if err != nil {
    	return err
    }
    s.AdditionalProperties = additionalProperties
    
    s.Configurationfailures = temp.Configurationfailures
    s.Createdon = temp.Createdon
    s.Delegateid = temp.Delegateid
    s.Description = temp.Description
    s.Disabled = temp.Disabled
    s.Email = temp.Email
    s.Filter = temp.Filter
    s.Id = temp.Id
    s.Kind = temp.Kind
    s.Laststreamingstatus = temp.Laststreamingstatus
    s.Laststreamingtime = temp.Laststreamingtime
    s.Lastupdated = temp.Lastupdated
    s.Name = temp.Name
    s.Networkfailures = temp.Networkfailures
    s.Streamfailures = temp.Streamfailures
    s.Streamkind = temp.Streamkind
    s.Targetid = temp.Targetid
    s.Targettype = temp.Targettype
    s.Version = temp.Version
    s.Versionid = temp.Versionid
    return nil
}

// tempSubscription is a temporary struct used for validating the fields of Subscription.
type tempSubscription  struct {
    Configurationfailures *int    `json:"configurationfailures,omitempty"`
    Createdon             *string `json:"createdon,omitempty"`
    Delegateid            *string `json:"delegateid,omitempty"`
    Description           *string `json:"description,omitempty"`
    Disabled              *bool   `json:"disabled,omitempty"`
    Email                 *string `json:"email,omitempty"`
    Filter                *string `json:"filter,omitempty"`
    Id                    *string `json:"id,omitempty"`
    Kind                  *string `json:"kind,omitempty"`
    Laststreamingstatus   *string `json:"laststreamingstatus,omitempty"`
    Laststreamingtime     *string `json:"laststreamingtime,omitempty"`
    Lastupdated           *string `json:"lastupdated,omitempty"`
    Name                  *string `json:"name,omitempty"`
    Networkfailures       *int    `json:"networkfailures,omitempty"`
    Streamfailures        *int    `json:"streamfailures,omitempty"`
    Streamkind            *string `json:"streamkind,omitempty"`
    Targetid              *string `json:"targetid,omitempty"`
    Targettype            *string `json:"targettype,omitempty"`
    Version               *string `json:"version,omitempty"`
    Versionid             *string `json:"versionid,omitempty"`
}
