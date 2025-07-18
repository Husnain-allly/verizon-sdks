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

// AnomalyTriggersApi represents a controller struct.
type AnomalyTriggersApi struct {
    baseApi
}

// NewAnomalyTriggersApi creates a new instance of AnomalyTriggersApi.
// It takes a baseController as a parameter and returns a pointer to the AnomalyTriggersApi.
func NewAnomalyTriggersApi(baseApi baseApi) *AnomalyTriggersApi {
    anomalyTriggersApi := AnomalyTriggersApi{baseApi: baseApi}
    return &anomalyTriggersApi
}

// ListAnomalyDetectionTriggers takes context as parameters and
// returns an models.ApiResponse with []models.GetTriggerResponseList data and
// an error if there was an issue with the request or response.
// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
func (a *AnomalyTriggersApi) ListAnomalyDetectionTriggers(ctx context.Context) (
    models.ApiResponse[[]models.GetTriggerResponseList],
    error) {
    req := a.prepareRequest(ctx, "GET", "/m2m/v1/triggers")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad request", Unmarshaller: errors.NewIntelligenceResult},
        "401": {Message: "Unauthorized", Unmarshaller: errors.NewIntelligenceResult},
        "403": {Message: "Forbidden", Unmarshaller: errors.NewIntelligenceResult},
        "404": {Message: "Not Found / Does not exist", Unmarshaller: errors.NewIntelligenceResult},
        "406": {Message: "Format / Request Unacceptable", Unmarshaller: errors.NewIntelligenceResult},
        "429": {Message: "Too many requests", Unmarshaller: errors.NewIntelligenceResult},
        "0": {Message: "Error response", Unmarshaller: errors.NewIntelligenceResult},
    })
    var result []models.GetTriggerResponseList
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[[]models.GetTriggerResponseList](decoder)
    return models.NewApiResponse(result, resp), err
}

// UpdateAnomalyDetectionTrigger takes context, body as parameters and
// returns an models.ApiResponse with models.AnomalyDetectionTrigger data and
// an error if there was an issue with the request or response.
// This corresponds to the M2M-MC SOAP interface, ```UpdateTriggerRequest```.
func (a *AnomalyTriggersApi) UpdateAnomalyDetectionTrigger(
    ctx context.Context,
    body models.UpdateTriggerRequest) (
    models.ApiResponse[models.AnomalyDetectionTrigger],
    error) {
    req := a.prepareRequest(ctx, "PUT", "/m2m/v1/triggers")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad request", Unmarshaller: errors.NewIntelligenceResult},
        "401": {Message: "Unauthorized", Unmarshaller: errors.NewIntelligenceResult},
        "403": {Message: "Forbidden", Unmarshaller: errors.NewIntelligenceResult},
        "404": {Message: "Not Found / Does not exist", Unmarshaller: errors.NewIntelligenceResult},
        "406": {Message: "Format / Request Unacceptable", Unmarshaller: errors.NewIntelligenceResult},
        "429": {Message: "Too many requests", Unmarshaller: errors.NewIntelligenceResult},
        "0": {Message: "Error response", Unmarshaller: errors.NewIntelligenceResult},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.AnomalyDetectionTrigger
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.AnomalyDetectionTrigger](decoder)
    return models.NewApiResponse(result, resp), err
}

// CreateAnomalyDetectionTrigger takes context, body as parameters and
// returns an models.ApiResponse with models.AnomalyDetectionTrigger data and
// an error if there was an issue with the request or response.
// This corresponds to the M2M-MC SOAP interface, ```CreateTrigger```.
func (a *AnomalyTriggersApi) CreateAnomalyDetectionTrigger(
    ctx context.Context,
    body models.CreateTriggerRequest) (
    models.ApiResponse[models.AnomalyDetectionTrigger],
    error) {
    req := a.prepareRequest(ctx, "POST", "/m2m/v1/triggers")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad request", Unmarshaller: errors.NewIntelligenceResult},
        "401": {Message: "Unauthorized", Unmarshaller: errors.NewIntelligenceResult},
        "403": {Message: "Forbidden", Unmarshaller: errors.NewIntelligenceResult},
        "404": {Message: "Not Found / Does not exist", Unmarshaller: errors.NewIntelligenceResult},
        "406": {Message: "Format / Request Unacceptable", Unmarshaller: errors.NewIntelligenceResult},
        "429": {Message: "Too many requests", Unmarshaller: errors.NewIntelligenceResult},
        "0": {Message: "Error response", Unmarshaller: errors.NewIntelligenceResult},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    var result models.AnomalyDetectionTrigger
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.AnomalyDetectionTrigger](decoder)
    return models.NewApiResponse(result, resp), err
}

// ListAnomalyDetectionTriggerSettings takes context, triggerId as parameters and
// returns an models.ApiResponse with []models.GetTriggerResponseList data and
// an error if there was an issue with the request or response.
// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
func (a *AnomalyTriggersApi) ListAnomalyDetectionTriggerSettings(
    ctx context.Context,
    triggerId string) (
    models.ApiResponse[[]models.GetTriggerResponseList],
    error) {
    req := a.prepareRequest(ctx, "GET", "/m2m/v1/triggers/%v")
    req.AppendTemplateParams(triggerId)
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Bad request", Unmarshaller: errors.NewIntelligenceResult},
        "401": {Message: "Unauthorized", Unmarshaller: errors.NewIntelligenceResult},
        "403": {Message: "Forbidden", Unmarshaller: errors.NewIntelligenceResult},
        "404": {Message: "Not Found / Does not exist", Unmarshaller: errors.NewIntelligenceResult},
        "406": {Message: "Format / Request Unacceptable", Unmarshaller: errors.NewIntelligenceResult},
        "429": {Message: "Too many requests", Unmarshaller: errors.NewIntelligenceResult},
        "0": {Message: "Error response", Unmarshaller: errors.NewIntelligenceResult},
    })
    
    var result []models.GetTriggerResponseList
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[[]models.GetTriggerResponseList](decoder)
    return models.NewApiResponse(result, resp), err
}

// DeleteAnomalyDetectionTrigger takes context, triggerId as parameters and
// returns an models.ApiResponse with models.AnomalyDetectionTrigger data and
// an error if there was an issue with the request or response.
// Deletes a specific trigger ID
func (a *AnomalyTriggersApi) DeleteAnomalyDetectionTrigger(
    ctx context.Context,
    triggerId string) (
    models.ApiResponse[models.AnomalyDetectionTrigger],
    error) {
    req := a.prepareRequest(ctx, "DELETE", "/m2m/v1/triggers/%v")
    req.AppendTemplateParams(triggerId)
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewIntelligenceResult},
    })
    
    var result models.AnomalyDetectionTrigger
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.AnomalyDetectionTrigger](decoder)
    return models.NewApiResponse(result, resp), err
}
