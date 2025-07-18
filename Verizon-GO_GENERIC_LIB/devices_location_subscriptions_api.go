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

// DevicesLocationSubscriptionsApi represents a controller struct.
type DevicesLocationSubscriptionsApi struct {
    baseApi
}

// NewDevicesLocationSubscriptionsApi creates a new instance of DevicesLocationSubscriptionsApi.
// It takes a baseController as a parameter and returns a pointer to the DevicesLocationSubscriptionsApi.
func NewDevicesLocationSubscriptionsApi(baseApi baseApi) *DevicesLocationSubscriptionsApi {
    devicesLocationSubscriptionsApi := DevicesLocationSubscriptionsApi{baseApi: baseApi}
    return &devicesLocationSubscriptionsApi
}

// GetLocationServiceSubscriptionStatus takes context, accountName as parameters and
// returns an models.ApiResponse with models.DeviceLocationSubscription data and
// an error if there was an issue with the request or response.
// This subscriptions endpoint retrieves an account's current location subscription status.
func (d *DevicesLocationSubscriptionsApi) GetLocationServiceSubscriptionStatus(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.DeviceLocationSubscription],
    error) {
    req := d.prepareRequest(ctx, "GET", "/subscriptions/%v")
    req.AppendTemplateParams(accountName)
    req.BaseUrl("Device Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewDeviceLocationResult},
    })
    
    var result models.DeviceLocationSubscription
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.DeviceLocationSubscription](decoder)
    return models.NewApiResponse(result, resp), err
}

// GetLocationServiceUsage takes context, body as parameters and
// returns an models.ApiResponse with interface{} data and
// an error if there was an issue with the request or response.
// This endpoint allows user to search for billable usage for accounts based on the provided date range.
func (d *DevicesLocationSubscriptionsApi) GetLocationServiceUsage(
    ctx context.Context,
    body models.BillUsageRequest) (
    models.ApiResponse[interface{}],
    error) {
    req := d.prepareRequest(ctx, "POST", "/usage")
    
    req.BaseUrl("Device Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewDeviceLocationResult},
    })
    req.Header("Content-Type", "*/*")
    req.Json(&body)
    var result interface{}
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[interface{}](decoder)
    return models.NewApiResponse(result, resp), err
}
