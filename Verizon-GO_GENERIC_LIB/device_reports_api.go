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

// DeviceReportsApi represents a controller struct.
type DeviceReportsApi struct {
    baseApi
}

// NewDeviceReportsApi creates a new instance of DeviceReportsApi.
// It takes a baseController as a parameter and returns a pointer to the DeviceReportsApi.
func NewDeviceReportsApi(baseApi baseApi) *DeviceReportsApi {
    deviceReportsApi := DeviceReportsApi{baseApi: baseApi}
    return &deviceReportsApi
}

// CalculateAggregatedReportSynchronous takes context, body as parameters and
// returns an models.ApiResponse with models.AggregateSessionReport data and
// an error if there was an issue with the request or response.
// Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).
func (d *DeviceReportsApi) CalculateAggregatedReportSynchronous(
    ctx context.Context,
    body models.AggregateSessionReportRequest) (
    models.ApiResponse[models.AggregateSessionReport],
    error) {
    req := d.prepareRequest(ctx, "POST", "/report/aggregate")
    
    req.BaseUrl("Hyper Precise Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad request.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "401": {Message: "Unauthorized request. Access token is missing or invalid.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "403": {Message: "Forbidden request.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "404": {Message: "Bad request. Not found.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "409": {Message: "Bad request. Conflict state.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "500": {Message: "Internal Server Error.", Unmarshaller: errors.NewHyperPreciseLocationResult},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.AggregateSessionReport
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.AggregateSessionReport](decoder)
    return models.NewApiResponse(result, resp), err
}

// CalculateAggregatedReportAsynchronous takes context, body as parameters and
// returns an models.ApiResponse with models.AggregatedReportCallbackResult data and
// an error if there was an issue with the request or response.
// Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).
func (d *DeviceReportsApi) CalculateAggregatedReportAsynchronous(
    ctx context.Context,
    body models.AggregateSessionReportRequest) (
    models.ApiResponse[models.AggregatedReportCallbackResult],
    error) {
    req := d.prepareRequest(ctx, "POST", "/report/async/aggregate")
    
    req.BaseUrl("Hyper Precise Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad request.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "401": {Message: "Unauthorized request. Access token is missing or invalid.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "403": {Message: "Forbidden request.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "404": {Message: "Bad request. Not found.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "409": {Message: "Bad request. Conflict state.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "500": {Message: "Internal Server Error.", Unmarshaller: errors.NewHyperPreciseLocationResult},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.AggregatedReportCallbackResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.AggregatedReportCallbackResult](decoder)
    return models.NewApiResponse(result, resp), err
}

// GetSessionsReport takes context, body as parameters and
// returns an models.ApiResponse with models.SessionReport data and
// an error if there was an issue with the request or response.
// Detailed report of session duration and number of bytes transferred per day.
func (d *DeviceReportsApi) GetSessionsReport(
    ctx context.Context,
    body models.SessionReportRequest) (
    models.ApiResponse[models.SessionReport],
    error) {
    req := d.prepareRequest(ctx, "POST", "/report/sessions")
    
    req.BaseUrl("Hyper Precise Location")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad request.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "401": {Message: "Unauthorized request. Access token is missing or invalid.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "403": {Message: "Forbidden request.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "404": {Message: "Bad request. Not found.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "409": {Message: "Bad request. Conflict state.", Unmarshaller: errors.NewHyperPreciseLocationResult},
        "500": {Message: "Internal Server Error.", Unmarshaller: errors.NewHyperPreciseLocationResult},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.SessionReport
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.SessionReport](decoder)
    return models.NewApiResponse(result, resp), err
}
