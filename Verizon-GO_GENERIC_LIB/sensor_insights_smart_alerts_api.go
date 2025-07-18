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

// SensorInsightsSmartAlertsApi represents a controller struct.
type SensorInsightsSmartAlertsApi struct {
    baseApi
}

// NewSensorInsightsSmartAlertsApi creates a new instance of SensorInsightsSmartAlertsApi.
// It takes a baseController as a parameter and returns a pointer to the SensorInsightsSmartAlertsApi.
func NewSensorInsightsSmartAlertsApi(baseApi baseApi) *SensorInsightsSmartAlertsApi {
    sensorInsightsSmartAlertsApi := SensorInsightsSmartAlertsApi{baseApi: baseApi}
    return &sensorInsightsSmartAlertsApi
}

// SensorInsightsListSmartAlertsRequest takes context, body as parameters and
// returns an models.ApiResponse with []models.UserSmartAlert data and
// an error if there was an issue with the request or response.
func (s *SensorInsightsSmartAlertsApi) SensorInsightsListSmartAlertsRequest(
    ctx context.Context,
    body models.DtoListSmartAlertsRequest) (
    models.ApiResponse[[]models.UserSmartAlert],
    error) {
    req := s.prepareRequest(ctx, "POST", "/dm/v1/smartAlerts/actions/query")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad Request", Unmarshaller: errors.NewM400ManagementError},
        "401": {Message: "UnAuthorized", Unmarshaller: errors.NewManagementError},
        "403": {Message: "Forbidden", Unmarshaller: errors.NewM403ManagementError},
        "404": {Message: "Not Found", Unmarshaller: errors.NewM404ManagementError},
        "406": {Message: "Not Acceptable", Unmarshaller: errors.NewManagementError},
        "415": {Message: "Unsupported media type", Unmarshaller: errors.NewManagementError},
        "429": {Message: "Too many requests", Unmarshaller: errors.NewManagementError},
        "500": {Message: "Internal server error.", Unmarshaller: errors.NewM500ManagementError},
        "0": {Message: "Unexpected error", Unmarshaller: errors.NewManagementError},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result []models.UserSmartAlert
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[[]models.UserSmartAlert](decoder)
    return models.NewApiResponse(result, resp), err
}

// SensorInsightsPatchSmartAlertRequest takes context, body as parameters and
// returns an models.ApiResponse with models.UserSmartAlert data and
// an error if there was an issue with the request or response.
func (s *SensorInsightsSmartAlertsApi) SensorInsightsPatchSmartAlertRequest(
    ctx context.Context,
    body models.DtoPatchSmartAlertRequest) (
    models.ApiResponse[models.UserSmartAlert],
    error) {
    req := s.prepareRequest(ctx, "PATCH", "/dm/v1/smartAlerts")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad Request", Unmarshaller: errors.NewM400ManagementError},
        "401": {Message: "UnAuthorized", Unmarshaller: errors.NewManagementError},
        "403": {Message: "Forbidden", Unmarshaller: errors.NewM403ManagementError},
        "404": {Message: "Not Found", Unmarshaller: errors.NewM404ManagementError},
        "406": {Message: "Not Acceptable", Unmarshaller: errors.NewManagementError},
        "415": {Message: "Unsupported media type", Unmarshaller: errors.NewManagementError},
        "429": {Message: "Too many requests", Unmarshaller: errors.NewManagementError},
        "500": {Message: "Internal server error.", Unmarshaller: errors.NewM500ManagementError},
        "0": {Message: "Unexpected error", Unmarshaller: errors.NewManagementError},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.UserSmartAlert
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.UserSmartAlert](decoder)
    return models.NewApiResponse(result, resp), err
}

// SensorInsightsBulkUpdate takes context, body as parameters and
// returns an models.ApiResponse with models.UserSmartAlert data and
// an error if there was an issue with the request or response.
func (s *SensorInsightsSmartAlertsApi) SensorInsightsBulkUpdate(
    ctx context.Context,
    body models.DtoBulkUpdate) (
    models.ApiResponse[models.UserSmartAlert],
    error) {
    req := s.prepareRequest(ctx, "POST", "/dm/v1/smartAlerts/actions/bulkupdate")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad Request", Unmarshaller: errors.NewM400ManagementError},
        "401": {Message: "UnAuthorized", Unmarshaller: errors.NewManagementError},
        "403": {Message: "Forbidden", Unmarshaller: errors.NewM403ManagementError},
        "404": {Message: "Not Found", Unmarshaller: errors.NewM404ManagementError},
        "406": {Message: "Not Acceptable", Unmarshaller: errors.NewManagementError},
        "415": {Message: "Unsupported media type", Unmarshaller: errors.NewManagementError},
        "429": {Message: "Too many requests", Unmarshaller: errors.NewManagementError},
        "500": {Message: "Internal server error.", Unmarshaller: errors.NewM500ManagementError},
        "0": {Message: "Unexpected error", Unmarshaller: errors.NewManagementError},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.UserSmartAlert
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.UserSmartAlert](decoder)
    return models.NewApiResponse(result, resp), err
}
