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

// ResourcesServiceProfile represents a ResourcesServiceProfile struct.
// Information about the resource requirements and service characteristics of an edge application. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Does not include serviceProfileId
type ResourcesServiceProfile struct {
    // The category of application client.
    ClientType        ClientType                         `json:"clientType"`
    // Identity of the preferred Edge Computing Service Provider.
    EcspFilter        *string                            `json:"ecspFilter,omitempty"`
    // The expected operation schedule of the application client (e.g. time windows).
    ClientSchedule    *string                            `json:"clientSchedule,omitempty"`
    // The expected location(s) (e.g. route) of the hosting UE during the Client's operation schedule.
    ClientServiceArea *string                            `json:"clientServiceArea,omitempty"`
    // Network resources of a service profile.
    NetworkResources  *NetworkResourcesType              `json:"networkResources,omitempty"`
    // Compute resources of a service profile.
    ComputeResources  *ComputeResourcesType              `json:"computeResources,omitempty"`
    // Additional service support information for the MEC platform.
    Properties        *MecPlatformsAdditionalSupportInfo `json:"properties,omitempty"`
}

// String implements the fmt.Stringer interface for ResourcesServiceProfile,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (r ResourcesServiceProfile) String() string {
    return fmt.Sprintf(
    	"ResourcesServiceProfile[ClientType=%v, EcspFilter=%v, ClientSchedule=%v, ClientServiceArea=%v, NetworkResources=%v, ComputeResources=%v, Properties=%v]",
    	r.ClientType, r.EcspFilter, r.ClientSchedule, r.ClientServiceArea, r.NetworkResources, r.ComputeResources, r.Properties)
}

// MarshalJSON implements the json.Marshaler interface for ResourcesServiceProfile.
// It customizes the JSON marshaling process for ResourcesServiceProfile objects.
func (r ResourcesServiceProfile) MarshalJSON() (
    []byte,
    error) {
    return json.Marshal(r.toMap())
}

// toMap converts the ResourcesServiceProfile object to a map representation for JSON marshaling.
func (r ResourcesServiceProfile) toMap() map[string]any {
    structMap := make(map[string]any)
    structMap["clientType"] = r.ClientType
    if r.EcspFilter != nil {
        structMap["ecspFilter"] = r.EcspFilter
    }
    if r.ClientSchedule != nil {
        structMap["clientSchedule"] = r.ClientSchedule
    }
    if r.ClientServiceArea != nil {
        structMap["clientServiceArea"] = r.ClientServiceArea
    }
    if r.NetworkResources != nil {
        structMap["networkResources"] = r.NetworkResources.toMap()
    }
    if r.ComputeResources != nil {
        structMap["computeResources"] = r.ComputeResources.toMap()
    }
    if r.Properties != nil {
        structMap["properties"] = r.Properties.toMap()
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for ResourcesServiceProfile.
// It customizes the JSON unmarshaling process for ResourcesServiceProfile objects.
func (r *ResourcesServiceProfile) UnmarshalJSON(input []byte) error {
    var temp tempResourcesServiceProfile
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    err = temp.validate()
    if err != nil {
    	return err
    }
    
    r.ClientType = *temp.ClientType
    r.EcspFilter = temp.EcspFilter
    r.ClientSchedule = temp.ClientSchedule
    r.ClientServiceArea = temp.ClientServiceArea
    r.NetworkResources = temp.NetworkResources
    r.ComputeResources = temp.ComputeResources
    r.Properties = temp.Properties
    return nil
}

// tempResourcesServiceProfile is a temporary struct used for validating the fields of ResourcesServiceProfile.
type tempResourcesServiceProfile  struct {
    ClientType        *ClientType                        `json:"clientType"`
    EcspFilter        *string                            `json:"ecspFilter,omitempty"`
    ClientSchedule    *string                            `json:"clientSchedule,omitempty"`
    ClientServiceArea *string                            `json:"clientServiceArea,omitempty"`
    NetworkResources  *NetworkResourcesType              `json:"networkResources,omitempty"`
    ComputeResources  *ComputeResourcesType              `json:"computeResources,omitempty"`
    Properties        *MecPlatformsAdditionalSupportInfo `json:"properties,omitempty"`
}

func (r *tempResourcesServiceProfile) validate() error {
    var errs []string
    if r.ClientType == nil {
        errs = append(errs, "required field `clientType` is missing for type `ResourcesServiceProfile`")
    }
    if len(errs) == 0 {
        return nil
    }
    return errors.New(strings.Join (errs, "\n"))
}
