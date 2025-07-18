/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "errors"
    "fmt"
    "strings"
)

// GetNetworkConditionsRequest represents a GetNetworkConditionsRequest struct.
// Get network conditions.
type GetNetworkConditionsRequest struct {
    // Account name.
    AccountName  string      `json:"accountName"`
    // Type of location detail.
    LocationType string      `json:"locationType"`
    // Coordinates information.
    Coordinates  Coordinates `json:"coordinates"`
}

// String implements the fmt.Stringer interface for GetNetworkConditionsRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (g GetNetworkConditionsRequest) String() string {
    return fmt.Sprintf(
    	"GetNetworkConditionsRequest[AccountName=%v, LocationType=%v, Coordinates=%v]",
    	g.AccountName, g.LocationType, g.Coordinates)
}

// MarshalJSON implements the json.Marshaler interface for GetNetworkConditionsRequest.
// It customizes the JSON marshaling process for GetNetworkConditionsRequest objects.
func (g GetNetworkConditionsRequest) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(g.toMap())
}

// toMap converts the GetNetworkConditionsRequest object to a map representation for JSON marshaling.
func (g GetNetworkConditionsRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    structMap["accountName"] = g.AccountName
    structMap["locationType"] = g.LocationType
    structMap["coordinates"] = g.Coordinates.toMap()
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for GetNetworkConditionsRequest.
// It customizes the JSON unmarshaling process for GetNetworkConditionsRequest objects.
func (g *GetNetworkConditionsRequest) UnmarshalJSON(input []byte) error {
    var temp tempGetNetworkConditionsRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    
    g.AccountName = *temp.AccountName
    g.LocationType = *temp.LocationType
    g.Coordinates = *temp.Coordinates
    return nil
}

// tempGetNetworkConditionsRequest is a temporary struct used for validating the fields of GetNetworkConditionsRequest.
type tempGetNetworkConditionsRequest  struct {
    AccountName  *string      `json:"accountName"`
    LocationType *string      `json:"locationType"`
    Coordinates  *Coordinates `json:"coordinates"`
}

func (g *tempGetNetworkConditionsRequest) validate() error {
    var errs []string
    if g.AccountName == nil {
        errs = append(errs, "required field `accountName` is missing for type `GetNetworkConditionsRequest`")
    }
    if g.LocationType == nil {
        errs = append(errs, "required field `locationType` is missing for type `GetNetworkConditionsRequest`")
    }
    if g.Coordinates == nil {
        errs = append(errs, "required field `coordinates` is missing for type `GetNetworkConditionsRequest`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
