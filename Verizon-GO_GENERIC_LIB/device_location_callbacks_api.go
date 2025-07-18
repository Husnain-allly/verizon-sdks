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

// DeviceLocationCallbacksApi represents a controller struct.
type DeviceLocationCallbacksApi struct {
    baseApi
}

// NewDeviceLocationCallbacksApi creates a new instance of DeviceLocationCallbacksApi.
// It takes a baseController as a parameter and returns a pointer to the DeviceLocationCallbacksApi.
func NewDeviceLocationCallbacksApi(baseApi baseApi) *DeviceLocationCallbacksApi {
    deviceLocationCallbacksApi := DeviceLocationCallbacksApi{baseApi: baseApi}
    return &deviceLocationCallbacksApi
}

// CancelAsyncReport takes context, accountName, txid as parameters and
// returns an models.ApiResponse with models.TransactionId data and
// an error if there was an issue with the request or response.
// Cancel an asynchronous report request.
func (d *DeviceLocationCallbacksApi) CancelAsyncReport(
    ctx context.Context,
    accountName string,
    txid string) (
    models.ApiResponse[models.TransactionId],
    error) {
    req := d.prepareRequest(ctx, "DELETE", "/devicelocations/%v")
    req.AppendTemplateParams(txid)
    req.BaseUrl("Device Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Unexpected error.", Unmarshaller: errors.NewDeviceLocationResult},
    })
    req.QueryParam("accountName", accountName)
    
    var result models.TransactionId
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.TransactionId](decoder)
    return models.NewApiResponse(result, resp), err
}

// ListRegisteredCallbacks takes context, accountName as parameters and
// returns an models.ApiResponse with []models.DeviceLocationCallback data and
// an error if there was an issue with the request or response.
// Returns a list of all registered callback URLs for the account.
func (d *DeviceLocationCallbacksApi) ListRegisteredCallbacks(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[[]models.DeviceLocationCallback],
    error) {
    req := d.prepareRequest(ctx, "GET", "/callbacks/%v")
    req.AppendTemplateParams(accountName)
    req.BaseUrl("Device Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Error response.", Unmarshaller: errors.NewDeviceLocationResult},
    })
    
    var result []models.DeviceLocationCallback
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[[]models.DeviceLocationCallback](decoder)
    return models.NewApiResponse(result, resp), err
}

// RegisterCallback takes context, accountName, body as parameters and
// returns an models.ApiResponse with models.CallbackRegistrationResult data and
// an error if there was an issue with the request or response.
// Provide a URL to receive messages from a ThingSpace callback service.
func (d *DeviceLocationCallbacksApi) RegisterCallback(
    ctx context.Context,
    accountName string,
    body models.DeviceLocationCallback) (
    models.ApiResponse[models.CallbackRegistrationResult],
    error) {
    req := d.prepareRequest(ctx, "POST", "/callbacks/%v")
    req.AppendTemplateParams(accountName)
    req.BaseUrl("Device Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Error response.", Unmarshaller: errors.NewDeviceLocationResult},
    })
    req.Header("Content-Type", "*/*")
    req.Json(&body)
    
    var result models.CallbackRegistrationResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.CallbackRegistrationResult](decoder)
    return models.NewApiResponse(result, resp), err
}

// DeregisterCallback takes context, accountName, service as parameters and
// returns an models.ApiResponse with models.DeviceLocationSuccessResult data and
// an error if there was an issue with the request or response.
// Deregister a URL to stop receiving callback messages.
func (d *DeviceLocationCallbacksApi) DeregisterCallback(
    ctx context.Context,
    accountName string,
    service models.CallbackServiceName) (
    models.ApiResponse[models.DeviceLocationSuccessResult],
    error) {
    req := d.prepareRequest(ctx, "DELETE", "/callbacks/%v/name/%v")
    req.AppendTemplateParams(accountName, service)
    req.BaseUrl("Device Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Error response.", Unmarshaller: errors.NewDeviceLocationResult},
    })
    
    var result models.DeviceLocationSuccessResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.DeviceLocationSuccessResult](decoder)
    return models.NewApiResponse(result, resp), err
}
