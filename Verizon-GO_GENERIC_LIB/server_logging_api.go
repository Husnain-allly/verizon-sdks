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

// ServerLoggingApi represents a controller struct.
type ServerLoggingApi struct {
    baseApi
}

// NewServerLoggingApi creates a new instance of ServerLoggingApi.
// It takes a baseController as a parameter and returns a pointer to the ServerLoggingApi.
func NewServerLoggingApi(baseApi baseApi) *ServerLoggingApi {
    serverLoggingApi := ServerLoggingApi{baseApi: baseApi}
    return &serverLoggingApi
}

// GetDeviceCheckInHistory takes context, account, deviceId as parameters and
// returns an models.ApiResponse with []models.CheckInHistoryItem data and
// an error if there was an issue with the request or response.
// Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.
func (s *ServerLoggingApi) GetDeviceCheckInHistory(
    ctx context.Context,
    account string,
    deviceId string) (
    models.ApiResponse[[]models.CheckInHistoryItem],
    error) {
    req := s.prepareRequest(ctx, "GET", "/logging/%v/devices/%v/checkInHistory")
    req.AppendTemplateParams(account, deviceId)
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
    
    var result []models.CheckInHistoryItem
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[[]models.CheckInHistoryItem](decoder)
    return models.NewApiResponse(result, resp), err
}
