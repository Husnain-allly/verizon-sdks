/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// ResourcesEdgeHostedServiceWithProfileId represents a ResourcesEdgeHostedServiceWithProfileId struct.
// Edge hosted service represented by Service Endpoint definition.
type ResourcesEdgeHostedServiceWithProfileId struct {
    // Edge Resource Name. A string identifier for a set of edge resources.
    Ern                         *string                   `json:"ern,omitempty"`
    // Service Endpoint path, address, and port.
    ServiceEndpoint             *ResourcesServiceEndpoint `json:"serviceEndpoint,omitempty"`
    // Unique ID representing the Edge Application Provider.
    ApplicationServerProviderId *string                   `json:"applicationServerProviderId,omitempty"`
    // Unique ID representing the Edge Application.
    ApplicationId               *string                   `json:"applicationId,omitempty"`
    ServiceDescription          *string                   `json:"serviceDescription,omitempty"`
    // The system assigned ID of the service profile.
    ServiceProfileId            *string                   `json:"serviceProfileID,omitempty"`
    AdditionalProperties        map[string]interface{}    `json:"_"`
}

// String implements the fmt.Stringer interface for ResourcesEdgeHostedServiceWithProfileId,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (r ResourcesEdgeHostedServiceWithProfileId) String() string {
    return fmt.Sprintf(
    	"ResourcesEdgeHostedServiceWithProfileId[Ern=%v, ServiceEndpoint=%v, ApplicationServerProviderId=%v, ApplicationId=%v, ServiceDescription=%v, ServiceProfileId=%v, AdditionalProperties=%v]",
    	r.Ern, r.ServiceEndpoint, r.ApplicationServerProviderId, r.ApplicationId, r.ServiceDescription, r.ServiceProfileId, r.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for ResourcesEdgeHostedServiceWithProfileId.
// It customizes the JSON marshaling process for ResourcesEdgeHostedServiceWithProfileId objects.
func (r ResourcesEdgeHostedServiceWithProfileId) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(r.AdditionalProperties,
        "ern", "serviceEndpoint", "applicationServerProviderId", "applicationId", "serviceDescription", "serviceProfileID"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(r.toMap())
}

// toMap converts the ResourcesEdgeHostedServiceWithProfileId object to a map representation for JSON marshaling.
func (r ResourcesEdgeHostedServiceWithProfileId) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, r.AdditionalProperties)
    if r.Ern != nil {
        structMap["ern"] = r.Ern
    }
    if r.ServiceEndpoint != nil {
        structMap["serviceEndpoint"] = r.ServiceEndpoint.toMap()
    }
    if r.ApplicationServerProviderId != nil {
        structMap["applicationServerProviderId"] = r.ApplicationServerProviderId
    }
    if r.ApplicationId != nil {
        structMap["applicationId"] = r.ApplicationId
    }
    if r.ServiceDescription != nil {
        structMap["serviceDescription"] = r.ServiceDescription
    }
    if r.ServiceProfileId != nil {
        structMap["serviceProfileID"] = r.ServiceProfileId
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ResourcesEdgeHostedServiceWithProfileId.
// It customizes the JSON unmarshaling process for ResourcesEdgeHostedServiceWithProfileId objects.
func (r *ResourcesEdgeHostedServiceWithProfileId) UnmarshalJSON(input []byte) error {
    var temp tempResourcesEdgeHostedServiceWithProfileId
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "ern", "serviceEndpoint", "applicationServerProviderId", "applicationId", "serviceDescription", "serviceProfileID")
    if err != nil {
    	return err
    }
    r.AdditionalProperties = additionalProperties
    
    r.Ern = temp.Ern
    r.ServiceEndpoint = temp.ServiceEndpoint
    r.ApplicationServerProviderId = temp.ApplicationServerProviderId
    r.ApplicationId = temp.ApplicationId
    r.ServiceDescription = temp.ServiceDescription
    r.ServiceProfileId = temp.ServiceProfileId
    return nil
}

// tempResourcesEdgeHostedServiceWithProfileId is a temporary struct used for validating the fields of ResourcesEdgeHostedServiceWithProfileId.
type tempResourcesEdgeHostedServiceWithProfileId  struct {
    Ern                         *string                   `json:"ern,omitempty"`
    ServiceEndpoint             *ResourcesServiceEndpoint `json:"serviceEndpoint,omitempty"`
    ApplicationServerProviderId *string                   `json:"applicationServerProviderId,omitempty"`
    ApplicationId               *string                   `json:"applicationId,omitempty"`
    ServiceDescription          *string                   `json:"serviceDescription,omitempty"`
    ServiceProfileId            *string                   `json:"serviceProfileID,omitempty"`
}
