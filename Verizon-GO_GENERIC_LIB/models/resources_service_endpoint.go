/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// ResourcesServiceEndpoint represents a ResourcesServiceEndpoint struct.
// Service Endpoint path, address, and port.
type ResourcesServiceEndpoint struct {
    // URI of Service Endpoint if available.
    Uri         *string `json:"URI,omitempty"`
    // FQDN of Service Endpoint if available.
    Fqdn        *string `json:"FQDN,omitempty"`
    // IPv4 Address of Service Endpoint if available.
    IPv4Address *string `json:"IPv4Address,omitempty"`
    // IPv6 Address of Service Endpoint if available.
    IPv6Address *string `json:"IPv6Address,omitempty"`
    // Port information of Service Endpoint if IPv4 or IPv6 is mentioned.
    Port        *int    `json:"port,omitempty"`
}

// String implements the fmt.Stringer interface for ResourcesServiceEndpoint,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (r ResourcesServiceEndpoint) String() string {
    return fmt.Sprintf(
    	"ResourcesServiceEndpoint[Uri=%v, Fqdn=%v, IPv4Address=%v, IPv6Address=%v, Port=%v]",
    	r.Uri, r.Fqdn, r.IPv4Address, r.IPv6Address, r.Port)
}

// MarshalJSON implements the json.Marshaler interface for ResourcesServiceEndpoint.
// It customizes the JSON marshaling process for ResourcesServiceEndpoint objects.
func (r ResourcesServiceEndpoint) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(r.toMap())
}

// toMap converts the ResourcesServiceEndpoint object to a map representation for JSON marshaling.
func (r ResourcesServiceEndpoint) toMap() map[string]any {
    structMap := make(map[string]any)
    if r.Uri != nil {
        structMap["URI"] = r.Uri
    }
    if r.Fqdn != nil {
        structMap["FQDN"] = r.Fqdn
    }
    if r.IPv4Address != nil {
        structMap["IPv4Address"] = r.IPv4Address
    }
    if r.IPv6Address != nil {
        structMap["IPv6Address"] = r.IPv6Address
    }
    if r.Port != nil {
        structMap["port"] = r.Port
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ResourcesServiceEndpoint.
// It customizes the JSON unmarshaling process for ResourcesServiceEndpoint objects.
func (r *ResourcesServiceEndpoint) UnmarshalJSON(input []byte) error {
    var temp tempResourcesServiceEndpoint
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    
    r.Uri = temp.Uri
    r.Fqdn = temp.Fqdn
    r.IPv4Address = temp.IPv4Address
    r.IPv6Address = temp.IPv6Address
    r.Port = temp.Port
    return nil
}

// tempResourcesServiceEndpoint is a temporary struct used for validating the fields of ResourcesServiceEndpoint.
type tempResourcesServiceEndpoint  struct {
    Uri         *string `json:"URI,omitempty"`
    Fqdn        *string `json:"FQDN,omitempty"`
    IPv4Address *string `json:"IPv4Address,omitempty"`
    IPv6Address *string `json:"IPv6Address,omitempty"`
    Port        *int    `json:"port,omitempty"`
}
