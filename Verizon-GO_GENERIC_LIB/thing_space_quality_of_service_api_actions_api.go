/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package verizon

import (
    "context"
    "github.com/apimatic/go-core-runtime/https"
    "github.com/apimatic/go-core-runtime/utilities"
    "verizon/errors"
    "verizon/models"
)

// ThingSpaceQualityOfServiceApiActionsApi represents a controller struct.
type ThingSpaceQualityOfServiceApiActionsApi struct {
    baseApi
}

// NewThingSpaceQualityOfServiceApiActionsApi creates a new instance of ThingSpaceQualityOfServiceApiActionsApi.
// It takes a baseController as a parameter and returns a pointer to the ThingSpaceQualityOfServiceApiActionsApi.
func NewThingSpaceQualityOfServiceApiActionsApi(baseApi baseApi) *ThingSpaceQualityOfServiceApiActionsApi {
    thingSpaceQualityOfServiceApiActionsApi := ThingSpaceQualityOfServiceApiActionsApi{baseApi: baseApi}
    return &thingSpaceQualityOfServiceApiActionsApi
}

// CreateAThingSpaceQualityOfServiceApiSubscription takes context, body as parameters and
// returns an models.ApiResponse with models.M201Success data and
// an error if there was an issue with the request or response.
// Creates a QoS elevation subscription ID and activates the subscription.
func (t *ThingSpaceQualityOfServiceApiActionsApi) CreateAThingSpaceQualityOfServiceApiSubscription(
    ctx context.Context,
    body models.SubscribeRequest) (
    models.ApiResponse[models.M201Success],
    error) {
    req := t.prepareRequest(ctx, "POST", "/m2m/v1/devices/actions/enhanceQoS")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error Response", Unmarshaller: errors.NewDefaultResponse},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.M201Success
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.M201Success](decoder)
    return models.NewApiResponse(result, resp), err
}

// StopAThingSpaceQualityOfServiceApiSubscription takes context, accountName, qosSubscriptionId as parameters and
// returns an models.ApiResponse with models.M201Success data and
// an error if there was an issue with the request or response.
// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.
func (t *ThingSpaceQualityOfServiceApiActionsApi) StopAThingSpaceQualityOfServiceApiSubscription(
    ctx context.Context,
    accountName string,
    qosSubscriptionId string) (
    models.ApiResponse[models.M201Success],
    error) {
    req := t.prepareRequest(ctx, "DELETE", "/m2m/v1/devices/actions/enhanceQoS")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error Response", Unmarshaller: errors.NewDefaultResponse},
    })
    req.QueryParam("accountName", accountName)
    req.QueryParam("qosSubscriptionId", qosSubscriptionId)
    var result models.M201Success
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.M201Success](decoder)
    return models.NewApiResponse(result, resp), err
}
