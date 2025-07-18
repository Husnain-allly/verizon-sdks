/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package models

import (
    "encoding/json"
    "fmt"
)

// CreateIoTApplicationRequest represents a CreateIoTApplicationRequest struct.
// The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.
type CreateIoTApplicationRequest struct {
    // A user defined name for the application being deployed in Azure IoT Central.
    AppName              *string                `json:"appName,omitempty"`
    // The ThingSpace ID of the authenticating billing account
    BillingAccountId     *string                `json:"billingAccountID,omitempty"`
    // The Azure ClientID of the associated Azure target account
    ClientId             *string                `json:"clientID,omitempty"`
    // The Azure Client Secret of the associated Azure target account
    ClientSecret         *string                `json:"clientSecret,omitempty"`
    // The “email IDs” to be added to/sent to with this API.
    EmailIDs             *string                `json:"emailIDs,omitempty"`
    // The Azure Resource group of the associated Azure target account
    Resourcegroup        *string                `json:"resourcegroup,omitempty"`
    // This is the reference Azure IoT Central application developed by Verizon.
    SampleIoTcApp        *string                `json:"sampleIOTcApp,omitempty"`
    // The Azure Subscription ID of the associated Azure target account
    SubscriptionId       *string                `json:"subscriptionID,omitempty"`
    // The Azure Tenant ID of the associated Azure target account
    TenantId             *string                `json:"tenantID,omitempty"`
    AdditionalProperties map[string]interface{} `json:"_"`
}

// String implements the fmt.Stringer interface for CreateIoTApplicationRequest,
// providing a human-readable string representation useful for logging, debugging or displaying information.
func (c CreateIoTApplicationRequest) String() string {
    return fmt.Sprintf(
    	"CreateIoTApplicationRequest[AppName=%v, BillingAccountId=%v, ClientId=%v, ClientSecret=%v, EmailIDs=%v, Resourcegroup=%v, SampleIoTcApp=%v, SubscriptionId=%v, TenantId=%v, AdditionalProperties=%v]",
    	c.AppName, c.BillingAccountId, c.ClientId, c.ClientSecret, c.EmailIDs, c.Resourcegroup, c.SampleIoTcApp, c.SubscriptionId, c.TenantId, c.AdditionalProperties)
}

// MarshalJSON implements the json.Marshaler interface for CreateIoTApplicationRequest.
// It customizes the JSON marshaling process for CreateIoTApplicationRequest objects.
func (c CreateIoTApplicationRequest) MarshalJSON() (
    []byte,
    error) {
    if err := DetectConflictingProperties(c.AdditionalProperties,
        "appName", "billingAccountID", "clientID", "clientSecret", "emailIDs", "resourcegroup", "sampleIOTcApp", "subscriptionID", "tenantID"); err != nil {
        return []byte{}, err
    }
    return json.Marshal(c.toMap())
}

// toMap converts the CreateIoTApplicationRequest object to a map representation for JSON marshaling.
func (c CreateIoTApplicationRequest) toMap() map[string]any {
    structMap := make(map[string]any)
    MergeAdditionalProperties(structMap, c.AdditionalProperties)
    if c.AppName != nil {
        structMap["appName"] = c.AppName
    }
    if c.BillingAccountId != nil {
        structMap["billingAccountID"] = c.BillingAccountId
    }
    if c.ClientId != nil {
        structMap["clientID"] = c.ClientId
    }
    if c.ClientSecret != nil {
        structMap["clientSecret"] = c.ClientSecret
    }
    if c.EmailIDs != nil {
        structMap["emailIDs"] = c.EmailIDs
    }
    if c.Resourcegroup != nil {
        structMap["resourcegroup"] = c.Resourcegroup
    }
    if c.SampleIoTcApp != nil {
        structMap["sampleIOTcApp"] = c.SampleIoTcApp
    }
    if c.SubscriptionId != nil {
        structMap["subscriptionID"] = c.SubscriptionId
    }
    if c.TenantId != nil {
        structMap["tenantID"] = c.TenantId
    }
    return structMap
}

// UnmarshalJSON implements the json.Unmarshaler interface for CreateIoTApplicationRequest.
// It customizes the JSON unmarshaling process for CreateIoTApplicationRequest objects.
func (c *CreateIoTApplicationRequest) UnmarshalJSON(input []byte) error {
    var temp tempCreateIoTApplicationRequest
    err := json.Unmarshal(input, &temp)
    if err != nil {
    	return err
    }
    additionalProperties, err := ExtractAdditionalProperties[interface{}](input, "appName", "billingAccountID", "clientID", "clientSecret", "emailIDs", "resourcegroup", "sampleIOTcApp", "subscriptionID", "tenantID")
    if err != nil {
    	return err
    }
    c.AdditionalProperties = additionalProperties
    
    c.AppName = temp.AppName
    c.BillingAccountId = temp.BillingAccountId
    c.ClientId = temp.ClientId
    c.ClientSecret = temp.ClientSecret
    c.EmailIDs = temp.EmailIDs
    c.Resourcegroup = temp.Resourcegroup
    c.SampleIoTcApp = temp.SampleIoTcApp
    c.SubscriptionId = temp.SubscriptionId
    c.TenantId = temp.TenantId
    return nil
}

// tempCreateIoTApplicationRequest is a temporary struct used for validating the fields of CreateIoTApplicationRequest.
type tempCreateIoTApplicationRequest  struct {
    AppName          *string `json:"appName,omitempty"`
    BillingAccountId *string `json:"billingAccountID,omitempty"`
    ClientId         *string `json:"clientID,omitempty"`
    ClientSecret     *string `json:"clientSecret,omitempty"`
    EmailIDs         *string `json:"emailIDs,omitempty"`
    Resourcegroup    *string `json:"resourcegroup,omitempty"`
    SampleIoTcApp    *string `json:"sampleIOTcApp,omitempty"`
    SubscriptionId   *string `json:"subscriptionID,omitempty"`
    TenantId         *string `json:"tenantID,omitempty"`
}
