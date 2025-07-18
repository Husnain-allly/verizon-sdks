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

// RetrieveTheTriggersApi represents a controller struct.
type RetrieveTheTriggersApi struct {
    baseApi
}

// NewRetrieveTheTriggersApi creates a new instance of RetrieveTheTriggersApi.
// It takes a baseController as a parameter and returns a pointer to the RetrieveTheTriggersApi.
func NewRetrieveTheTriggersApi(baseApi baseApi) *RetrieveTheTriggersApi {
    retrieveTheTriggersApi := RetrieveTheTriggersApi{baseApi: baseApi}
    return &retrieveTheTriggersApi
}

// GetAllAvailableTriggers takes context as parameters and
// returns an models.ApiResponse with models.TriggerValueResponse data and
// an error if there was an issue with the request or response.
// Retrieves all of the available triggers for pseudo-MDN.
func (r *RetrieveTheTriggersApi) GetAllAvailableTriggers(ctx context.Context) (
    models.ApiResponse[models.TriggerValueResponse],
    error) {
    req := r.prepareRequest(ctx, "GET", "/m2m/v2/triggers")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewReadySimRestErrorResponse},
    })
    var result models.TriggerValueResponse
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.TriggerValueResponse](decoder)
    return models.NewApiResponse(result, resp), err
}

// GetAllTriggersByAccountName takes context, accountName as parameters and
// returns an models.ApiResponse with models.TriggerValueResponse data and
// an error if there was an issue with the request or response.
// Retrieve the triggers associated with an account name.
func (r *RetrieveTheTriggersApi) GetAllTriggersByAccountName(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.TriggerValueResponse],
    error) {
    req := r.prepareRequest(ctx, "GET", "/m2m/v2/triggers/accounts/%v")
    req.AppendTemplateParams(accountName)
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewReadySimRestErrorResponse},
    })
    
    var result models.TriggerValueResponse
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.TriggerValueResponse](decoder)
    return models.NewApiResponse(result, resp), err
}

// GetAllTriggersByTriggerCategory takes context as parameters and
// returns an models.ApiResponse with models.TriggerValueResponse2 data and
// an error if there was an issue with the request or response.
// Retrieves all of the triggers for the specified account associated with the PromoAlert category
func (r *RetrieveTheTriggersApi) GetAllTriggersByTriggerCategory(ctx context.Context) (
    models.ApiResponse[models.TriggerValueResponse2],
    error) {
    req := r.prepareRequest(ctx, "GET", "/m2m/v2/triggers/categories/PromoAlerts")
    
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewReadySimRestErrorResponse},
    })
    var result models.TriggerValueResponse2
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.TriggerValueResponse2](decoder)
    return models.NewApiResponse(result, resp), err
}

// GetTriggersById takes context, triggerId as parameters and
// returns an models.ApiResponse with models.TriggerValueResponse2 data and
// an error if there was an issue with the request or response.
// Retrives a specific trigger by its ID.
func (r *RetrieveTheTriggersApi) GetTriggersById(
    ctx context.Context,
    triggerId string) (
    models.ApiResponse[models.TriggerValueResponse2],
    error) {
    req := r.prepareRequest(ctx, "GET", "/m2m/v2/triggers/%v")
    req.AppendTemplateParams(triggerId)
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "0": {Message: "Error response", Unmarshaller: errors.NewReadySimRestErrorResponse},
    })
    
    var result models.TriggerValueResponse2
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.TriggerValueResponse2](decoder)
    return models.NewApiResponse(result, resp), err
}
