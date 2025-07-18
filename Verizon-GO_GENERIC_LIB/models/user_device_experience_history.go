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

// UserDeviceExperienceHistory represents a UserDeviceExperienceHistory struct.
type UserDeviceExperienceHistory struct {
    // The billing account ID. This is the same value as the Account ID
    Billingaccountid *string    `json:"billingaccountid,omitempty"`
    // Timestamp of the record
    Createdon        *time.Time `json:"createdon,omitempty"`
    // Timestamp of the record
    Date             *time.Time `json:"date,omitempty"`
    // This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have failed
    Devicesbad       *int       `json:"devicesbad,omitempty"`
    // This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that are impaired
    Devicesfair      *int       `json:"devicesfair,omitempty"`
    // This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have no issues
    Devicesgood      *int       `json:"devicesgood,omitempty"`
    // A count of all devices
    Devicestotal     *int       `json:"devicestotal,omitempty"`
    // UUID of the ECPD account the user belongs to
    Foreignid        *string    `json:"foreignid,omitempty"`
    // UUID of the user record, assigned at creation
    Id               *string    `json:"id,omitempty"`
    // Timestamp of the record
    Lastupdated      *time.Time `json:"lastupdated,omitempty"`
    // The resource version
    Version          *string    `json:"version,omitempty"`
    // The UUID of the resource version
    Versionid        *string    `json:"versionid,omitempty"`
}

// String implements the fmt.Stringer interface for UserDeviceExperienceHistory,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (u UserDeviceExperienceHistory) String() string {
    return fmt.Sprintf(
    	"UserDeviceExperienceHistory[Billingaccountid=%v, Createdon=%v, Date=%v, Devicesbad=%v, Devicesfair=%v, Devicesgood=%v, Devicestotal=%v, Foreignid=%v, Id=%v, Lastupdated=%v, Version=%v, Versionid=%v]",
    	u.Billingaccountid, u.Createdon, u.Date, u.Devicesbad, u.Devicesfair, u.Devicesgood, u.Devicestotal, u.Foreignid, u.Id, u.Lastupdated, u.Version, u.Versionid)
}

// MarshalJSON implements the json.Marshaler interface for UserDeviceExperienceHistory.
// It customizes the JSON marshaling process for UserDeviceExperienceHistory objects.
func (u UserDeviceExperienceHistory) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(u.toMap())
}

// toMap converts the UserDeviceExperienceHistory object to a map representation for JSON marshaling.
func (u UserDeviceExperienceHistory) toMap() map[string]any {
    structMap := make(map[string]any)
    if u.Billingaccountid != nil {
        structMap["billingaccountid"] = u.Billingaccountid
    }
    if u.Createdon != nil {
        structMap["createdon"] = u.Createdon.Format(time.RFC3339)
    }
    if u.Date != nil {
        structMap["date"] = u.Date.Format(time.RFC3339)
    }
    if u.Devicesbad != nil {
        structMap["devicesbad"] = u.Devicesbad
    }
    if u.Devicesfair != nil {
        structMap["devicesfair"] = u.Devicesfair
    }
    if u.Devicesgood != nil {
        structMap["devicesgood"] = u.Devicesgood
    }
    if u.Devicestotal != nil {
        structMap["devicestotal"] = u.Devicestotal
    }
    if u.Foreignid != nil {
        structMap["foreignid"] = u.Foreignid
    }
    if u.Id != nil {
        structMap["id"] = u.Id
    }
    if u.Lastupdated != nil {
        structMap["lastupdated"] = u.Lastupdated.Format(time.RFC3339)
    }
    if u.Version != nil {
        structMap["version"] = u.Version
    }
    if u.Versionid != nil {
        structMap["versionid"] = u.Versionid
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for UserDeviceExperienceHistory.
// It customizes the JSON unmarshaling process for UserDeviceExperienceHistory objects.
func (u *UserDeviceExperienceHistory) UnmarshalJSON(input []byte) error {
    var temp tempUserDeviceExperienceHistory
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    u.Billingaccountid = temp.Billingaccountid
    if temp.Createdon != nil {
        CreatedonVal, err := time.Parse(time.RFC3339, *temp.Createdon)
        if err != nil {
            log.Fatalf("Cannot Parse createdon as % s format.", time.RFC3339)
        }
        u.Createdon = &CreatedonVal
    }
    if temp.Date != nil {
        DateVal, err := time.Parse(time.RFC3339, *temp.Date)
        if err != nil {
            log.Fatalf("Cannot Parse date as % s format.", time.RFC3339)
        }
        u.Date = &DateVal
    }
    u.Devicesbad = temp.Devicesbad
    u.Devicesfair = temp.Devicesfair
    u.Devicesgood = temp.Devicesgood
    u.Devicestotal = temp.Devicestotal
    u.Foreignid = temp.Foreignid
    u.Id = temp.Id
    if temp.Lastupdated != nil {
        LastupdatedVal, err := time.Parse(time.RFC3339, *temp.Lastupdated)
        if err != nil {
            log.Fatalf("Cannot Parse lastupdated as % s format.", time.RFC3339)
        }
        u.Lastupdated = &LastupdatedVal
    }
    u.Version = temp.Version
    u.Versionid = temp.Versionid
    return nil
}

// tempUserDeviceExperienceHistory is a temporary struct used for validating the fields of UserDeviceExperienceHistory.
type tempUserDeviceExperienceHistory  struct {
    Billingaccountid *string `json:"billingaccountid,omitempty"`
    Createdon        *string `json:"createdon,omitempty"`
    Date             *string `json:"date,omitempty"`
    Devicesbad       *int    `json:"devicesbad,omitempty"`
    Devicesfair      *int    `json:"devicesfair,omitempty"`
    Devicesgood      *int    `json:"devicesgood,omitempty"`
    Devicestotal     *int    `json:"devicestotal,omitempty"`
    Foreignid        *string `json:"foreignid,omitempty"`
    Id               *string `json:"id,omitempty"`
    Lastupdated      *string `json:"lastupdated,omitempty"`
    Version          *string `json:"version,omitempty"`
    Versionid        *string `json:"versionid,omitempty"`
}
