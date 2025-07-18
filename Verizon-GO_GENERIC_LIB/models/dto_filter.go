/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// DtoFilter represents a DtoFilter struct.
type DtoFilter struct {
    // Use to provide device details for alerts specific to a device
    MExpand       *string                `json:"$expand,omitempty"`
    // Limit the number of results returned
    MLimitnumber  *int                   `json:"$limitnumber,omitempty"`
    // A flag set to show if pagination requested (false) or not (true)
    MNopagination *bool                  `json:"$nopagination,omitempty"`
    MPage         *string                `json:"$page,omitempty"`
    MPagenumber   *int                   `json:"$pagenumber,omitempty"`
    // Limits the fields of the device that the user is interested in rather than all of the fields
    MProjection   []string               `json:"$projection,omitempty"`
    // Filters results based on user defined criteria
    MSelection    map[string]interface{} `json:"$selection,omitempty"`
}

// String implements the fmt.Stringer interface for DtoFilter,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (d DtoFilter) String() string {
    return fmt.Sprintf(
    	"DtoFilter[MExpand=%v, MLimitnumber=%v, MNopagination=%v, MPage=%v, MPagenumber=%v, MProjection=%v, MSelection=%v]",
    	d.MExpand, d.MLimitnumber, d.MNopagination, d.MPage, d.MPagenumber, d.MProjection, d.MSelection)
}

// MarshalJSON implements the json.Marshaler interface for DtoFilter.
// It customizes the JSON marshaling process for DtoFilter objects.
func (d DtoFilter) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(d.toMap())
}

// toMap converts the DtoFilter object to a map representation for JSON marshaling.
func (d DtoFilter) toMap() map[string]any {
    structMap := make(map[string]any)
    if d.MExpand != nil {
        structMap["$expand"] = d.MExpand
    }
    if d.MLimitnumber != nil {
        structMap["$limitnumber"] = d.MLimitnumber
    }
    if d.MNopagination != nil {
        structMap["$nopagination"] = d.MNopagination
    }
    if d.MPage != nil {
        structMap["$page"] = d.MPage
    }
    if d.MPagenumber != nil {
        structMap["$pagenumber"] = d.MPagenumber
    }
    if d.MProjection != nil {
        structMap["$projection"] = d.MProjection
    }
    if d.MSelection != nil {
        structMap["$selection"] = d.MSelection
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for DtoFilter.
// It customizes the JSON unmarshaling process for DtoFilter objects.
func (d *DtoFilter) UnmarshalJSON(input []byte) error {
    var temp tempDtoFilter
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    d.MExpand = temp.MExpand
    d.MLimitnumber = temp.MLimitnumber
    d.MNopagination = temp.MNopagination
    d.MPage = temp.MPage
    d.MPagenumber = temp.MPagenumber
    d.MProjection = temp.MProjection
    d.MSelection = temp.MSelection
    return nil
}

// tempDtoFilter is a temporary struct used for validating the fields of DtoFilter.
type tempDtoFilter  struct {
    MExpand       *string                `json:"$expand,omitempty"`
    MLimitnumber  *int                   `json:"$limitnumber,omitempty"`
    MNopagination *bool                  `json:"$nopagination,omitempty"`
    MPage         *string                `json:"$page,omitempty"`
    MPagenumber   *int                   `json:"$pagenumber,omitempty"`
    MProjection   []string               `json:"$projection,omitempty"`
    MSelection    map[string]interface{} `json:"$selection,omitempty"`
}
