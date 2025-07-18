/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
    "log"
    "time"
)

// DtoNotificationGroupResponseEntity represents a DtoNotificationGroupResponseEntity struct.
type DtoNotificationGroupResponseEntity struct {
    // Timestamp of the record
    Createdon   *time.Time   `json:"createdon,omitempty"`
    // a short description
    Description *string      `json:"description,omitempty"`
    // UUID of the ECPD account the user belongs to
    Foreignid   *string      `json:"foreignid,omitempty"`
    // Contact email for the group
    Groupemail  *string      `json:"groupemail,omitempty"`
    // UUID of the user record, assigned at creation
    Id          *string      `json:"id,omitempty"`
    // Timestamp of the record
    Lastupdated *time.Time   `json:"lastupdated,omitempty"`
    // User defined name of the record
    Name        *string      `json:"name,omitempty"`
    Users       []DtoUserDto `json:"users,omitempty"`
    // The resource version
    Version     *string      `json:"version,omitempty"`
    // The UUID of the resource version
    Versionid   *string      `json:"versionid,omitempty"`
}

// String implements the fmt.Stringer interface for DtoNotificationGroupResponseEntity,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoNotificationGroupResponseEntity) String() string {
    return fmt.Sprintf(
    	"DtoNotificationGroupResponseEntity[Createdon=%v, Description=%v, Foreignid=%v, Groupemail=%v, Id=%v, Lastupdated=%v, Name=%v, Users=%v, Version=%v, Versionid=%v]",
    	d.Createdon, d.Description, d.Foreignid, d.Groupemail, d.Id, d.Lastupdated, d.Name, d.Users, d.Version, d.Versionid)
}

// MarshalJSON implements the json.Marshaler interface for DtoNotificationGroupResponseEntity.
// It customizes the JSON marshaling process for DtoNotificationGroupResponseEntity objects.
func (d DtoNotificationGroupResponseEntity) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(d.toMap())
}

// toMap converts the DtoNotificationGroupResponseEntity object to a map representation for JSON marshaling.
func (d DtoNotificationGroupResponseEntity) toMap() map[string]any {
    structMap := make(map[string]any)
    if d.Createdon != nil {
        structMap["createdon"] = d.Createdon.Format(time.RFC3339)
    }
    if d.Description != nil {
        structMap["description"] = d.Description
    }
    if d.Foreignid != nil {
        structMap["foreignid"] = d.Foreignid
    }
    if d.Groupemail != nil {
        structMap["groupemail"] = d.Groupemail
    }
    if d.Id != nil {
        structMap["id"] = d.Id
    }
    if d.Lastupdated != nil {
        structMap["lastupdated"] = d.Lastupdated.Format(time.RFC3339)
    }
    if d.Name != nil {
        structMap["name"] = d.Name
    }
    if d.Users != nil {
        structMap["users"] = d.Users
    }
    if d.Version != nil {
        structMap["version"] = d.Version
    }
    if d.Versionid != nil {
        structMap["versionid"] = d.Versionid
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoNotificationGroupResponseEntity.
// It customizes the JSON unmarshaling process for DtoNotificationGroupResponseEntity objects.
func (d *DtoNotificationGroupResponseEntity) UnmarshalJSON(input []byte) error {
    var temp tempDtoNotificationGroupResponseEntity
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    if temp.Createdon != nil {
        CreatedonVal, err := time.Parse(time.RFC3339, *temp.Createdon)
        if err != nil {
            log.Fatalf("Cannot Parse createdon as % s format.", time.RFC3339)
        }
        d.Createdon = &CreatedonVal
    }
    d.Description = temp.Description
    d.Foreignid = temp.Foreignid
    d.Groupemail = temp.Groupemail
    d.Id = temp.Id
    if temp.Lastupdated != nil {
        LastupdatedVal, err := time.Parse(time.RFC3339, *temp.Lastupdated)
        if err != nil {
            log.Fatalf("Cannot Parse lastupdated as % s format.", time.RFC3339)
        }
        d.Lastupdated = &LastupdatedVal
    }
    d.Name = temp.Name
    d.Users = temp.Users
    d.Version = temp.Version
    d.Versionid = temp.Versionid
    return nil
}

// tempDtoNotificationGroupResponseEntity is a temporary struct used for validating the fields of DtoNotificationGroupResponseEntity.
type tempDtoNotificationGroupResponseEntity  struct {
    Createdon   *string      `json:"createdon,omitempty"`
    Description *string      `json:"description,omitempty"`
    Foreignid   *string      `json:"foreignid,omitempty"`
    Groupemail  *string      `json:"groupemail,omitempty"`
    Id          *string      `json:"id,omitempty"`
    Lastupdated *string      `json:"lastupdated,omitempty"`
    Name        *string      `json:"name,omitempty"`
    Users       []DtoUserDto `json:"users,omitempty"`
    Version     *string      `json:"version,omitempty"`
    Versionid   *string      `json:"versionid,omitempty"`
}
