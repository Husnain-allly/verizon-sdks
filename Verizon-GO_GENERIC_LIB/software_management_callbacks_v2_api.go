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

// SoftwareManagementCallbacksV2Api represents a controller struct.
type SoftwareManagementCallbacksV2Api struct {
    baseApi
}

// NewSoftwareManagementCallbacksV2Api creates a new instance of SoftwareManagementCallbacksV2Api.
// It takes a baseController as a parameter and returns a pointer to the SoftwareManagementCallbacksV2Api.
func NewSoftwareManagementCallbacksV2Api(baseApi baseApi) *SoftwareManagementCallbacksV2Api {
    softwareManagementCallbacksV2Api := SoftwareManagementCallbacksV2Api{baseApi: baseApi}
    return &softwareManagementCallbacksV2Api
}

// ListRegisteredCallbacks takes context, account as parameters and
// returns an models.ApiResponse with models.CallbackSummary data and
// an error if there was an issue with the request or response.
// This endpoint allows user to get the registered callback information.
func (s *SoftwareManagementCallbacksV2Api) ListRegisteredCallbacks(
    ctx context.Context,
    account string) (
    models.ApiResponse[models.CallbackSummary],
    error) {
    req := s.prepareRequest(ctx, "GET", "/callbacks/%v")
    req.AppendTemplateParams(account)
    req.BaseUrl("Software Management V2")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV2Result},
    })
    
    var result models.CallbackSummary
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.CallbackSummary](decoder)
    return models.NewApiResponse(result, resp), err
}

// UpdateCallback takes context, account, body as parameters and
// returns an models.ApiResponse with models.FotaV2CallbackRegistrationResult data and
// an error if there was an issue with the request or response.
// This endpoint allows user to update the HTTPS callback address.
func (s *SoftwareManagementCallbacksV2Api) UpdateCallback(
    ctx context.Context,
    account string,
    body models.FotaV2CallbackRegistrationRequest) (
    models.ApiResponse[models.FotaV2CallbackRegistrationResult],
    error) {
    req := s.prepareRequest(ctx, "PUT", "/callbacks/%v")
    req.AppendTemplateParams(account)
    req.BaseUrl("Software Management V2")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV2Result},
    })
    req.Header("Content-Type", "*/*")
    req.Json(&body)
    
    var result models.FotaV2CallbackRegistrationResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.FotaV2CallbackRegistrationResult](decoder)
    return models.NewApiResponse(result, resp), err
}

// RegisterCallback takes context, account, body as parameters and
// returns an models.ApiResponse with models.FotaV2CallbackRegistrationResult data and
// an error if there was an issue with the request or response.
// This endpoint allows user to create the HTTPS callback address.
func (s *SoftwareManagementCallbacksV2Api) RegisterCallback(
    ctx context.Context,
    account string,
    body models.FotaV2CallbackRegistrationRequest) (
    models.ApiResponse[models.FotaV2CallbackRegistrationResult],
    error) {
    req := s.prepareRequest(ctx, "POST", "/callbacks/%v")
    req.AppendTemplateParams(account)
    req.BaseUrl("Software Management V2")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV2Result},
    })
    req.Header("Content-Type", "*/*")
    req.Json(&body)
    
    var result models.FotaV2CallbackRegistrationResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.FotaV2CallbackRegistrationResult](decoder)
    return models.NewApiResponse(result, resp), err
}

// DeregisterCallback takes context, account as parameters and
// returns an models.ApiResponse with models.FotaV2SuccessResult data and
// an error if there was an issue with the request or response.
// This endpoint allows user to delete a previously registered callback URL.
func (s *SoftwareManagementCallbacksV2Api) DeregisterCallback(
    ctx context.Context,
    account string) (
    models.ApiResponse[models.FotaV2SuccessResult],
    error) {
    req := s.prepareRequest(ctx, "DELETE", "/callbacks/%v")
    req.AppendTemplateParams(account)
    req.BaseUrl("Software Management V2")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV2Result},
    })
    
    var result models.FotaV2SuccessResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.FotaV2SuccessResult](decoder)
    return models.NewApiResponse(result, resp), err
}
