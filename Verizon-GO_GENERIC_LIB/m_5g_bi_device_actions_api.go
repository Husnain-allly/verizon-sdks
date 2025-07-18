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

// M5GBiDeviceActionsApi represents a controller struct.
type M5GBiDeviceActionsApi struct {
    baseApi
}

// NewM5GBiDeviceActionsApi creates a new instance of M5GBiDeviceActionsApi.
// It takes a baseController as a parameter and returns a pointer to the M5GBiDeviceActionsApi.
func NewM5GBiDeviceActionsApi(baseApi baseApi) *M5GBiDeviceActionsApi {
    m5GBiDeviceActionsApi := M5GBiDeviceActionsApi{baseApi: baseApi}
    return &m5GBiDeviceActionsApi
}

// BusinessInternetlistDeviceInformation takes context, body as parameters and
// returns an models.ApiResponse with models.M5GBideviceDetailsresponse data and
// an error if there was an issue with the request or response.
// Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.
func (m *M5GBiDeviceActionsApi) BusinessInternetlistDeviceInformation(
    ctx context.Context,
    body models.M5GBideviceId) (
    models.ApiResponse[models.M5GBideviceDetailsresponse],
    error) {
    req := m.prepareRequest(ctx, "POST", "/actions/list")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewOrAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewM5GBiRestErrorResponse},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.M5GBideviceDetailsresponse
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.M5GBideviceDetailsresponse](decoder)
    return models.NewApiResponse(result, resp), err
}

// BusinessInternetactivateUsingPost takes context, body as parameters and
// returns an models.ApiResponse with models.M5GBiRequestResponse data and
// an error if there was an issue with the request or response.
// Uses the device's ICCID and IMEI to activate service.
func (m *M5GBiDeviceActionsApi) BusinessInternetactivateUsingPost(
    ctx context.Context,
    body models.M5GBiactivateRequest) (
    models.ApiResponse[models.M5GBiRequestResponse],
    error) {
    req := m.prepareRequest(ctx, "POST", "/actions/activate")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewOrAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewM5GBiRestErrorResponse},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.M5GBiRequestResponse
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.M5GBiRequestResponse](decoder)
    return models.NewApiResponse(result, resp), err
}

// BusinessInternetServiceplanchange takes context, body as parameters and
// returns an models.ApiResponse with models.M5GBiRequestResponse data and
// an error if there was an issue with the request or response.
// Change a device's service plan to use 5G BI.
func (m *M5GBiDeviceActionsApi) BusinessInternetServiceplanchange(
    ctx context.Context,
    body models.M5GBichangeRequest) (
    models.ApiResponse[models.M5GBiRequestResponse],
    error) {
    req := m.prepareRequest(ctx, "PUT", "/actions/plan")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewOrAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewM5GBiRestErrorResponse},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.M5GBiRequestResponse
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.M5GBiRequestResponse](decoder)
    return models.NewApiResponse(result, resp), err
}
