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

// CampaignsV3Api represents a controller struct.
type CampaignsV3Api struct {
    baseApi
}

// NewCampaignsV3Api creates a new instance of CampaignsV3Api.
// It takes a baseController as a parameter and returns a pointer to the CampaignsV3Api.
func NewCampaignsV3Api(baseApi baseApi) *CampaignsV3Api {
    campaignsV3Api := CampaignsV3Api{baseApi: baseApi}
    return &campaignsV3Api
}

// ScheduleCampaignFirmwareUpgrade takes context, accountName, body as parameters and
// returns an models.ApiResponse with models.FirmwareCampaign data and
// an error if there was an issue with the request or response.
// This endpoint allows a user to schedule a firmware upgrade for a list of devices.
func (c *CampaignsV3Api) ScheduleCampaignFirmwareUpgrade(
    ctx context.Context,
    accountName string,
    body models.CampaignFirmwareUpgrade) (
    models.ApiResponse[models.FirmwareCampaign],
    error) {
    req := c.prepareRequest(ctx, "POST", "/campaigns/firmware/%v")
    req.AppendTemplateParams(accountName)
    req.BaseUrl("Software Management V3")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV3Result},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    
    var result models.FirmwareCampaign
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.FirmwareCampaign](decoder)
    return models.NewApiResponse(result, resp), err
}

// UpdateCampaignFirmwareDevices takes context, acc, campaignId, body as parameters and
// returns an models.ApiResponse with models.V3AddOrRemoveDeviceResult data and
// an error if there was an issue with the request or response.
// This endpoint allows user to Add or Remove devices to an existing campaign.
func (c *CampaignsV3Api) UpdateCampaignFirmwareDevices(
    ctx context.Context,
    acc string,
    campaignId string,
    body models.V3AddOrRemoveDeviceRequest) (
    models.ApiResponse[models.V3AddOrRemoveDeviceResult],
    error) {
    req := c.prepareRequest(ctx, "PUT", "/campaigns/firmware/%v/%v")
    req.AppendTemplateParams(acc, campaignId)
    req.BaseUrl("Software Management V3")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV3Result},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    
    var result models.V3AddOrRemoveDeviceResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.V3AddOrRemoveDeviceResult](decoder)
    return models.NewApiResponse(result, resp), err
}

// UpdateCampaignDates takes context, acc, campaignId, body as parameters and
// returns an models.ApiResponse with models.FirmwareCampaign data and
// an error if there was an issue with the request or response.
// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
func (c *CampaignsV3Api) UpdateCampaignDates(
    ctx context.Context,
    acc string,
    campaignId string,
    body models.V3ChangeCampaignDatesRequest) (
    models.ApiResponse[models.FirmwareCampaign],
    error) {
    req := c.prepareRequest(ctx, "PUT", "/campaigns/firmware/%v/%v/dates")
    req.AppendTemplateParams(acc, campaignId)
    req.BaseUrl("Software Management V3")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV3Result},
    })
    req.Header("Content-Type", "application/json")
    req.Json(&body)
    
    var result models.FirmwareCampaign
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.FirmwareCampaign](decoder)
    return models.NewApiResponse(result, resp), err
}

// GetCampaignInformation takes context, accountName, campaignId as parameters and
// returns an models.ApiResponse with models.Campaign data and
// an error if there was an issue with the request or response.
// This endpoint allows the user to retrieve campaign level information for a specified campaign.
func (c *CampaignsV3Api) GetCampaignInformation(
    ctx context.Context,
    accountName string,
    campaignId string) (
    models.ApiResponse[models.Campaign],
    error) {
    req := c.prepareRequest(ctx, "GET", "/campaigns/%v/%v")
    req.AppendTemplateParams(accountName, campaignId)
    req.BaseUrl("Software Management V3")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV3Result},
    })
    
    var result models.Campaign
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.Campaign](decoder)
    return models.NewApiResponse(result, resp), err
}

// CancelCampaign takes context, accountName, campaignId as parameters and
// returns an models.ApiResponse with models.FotaV3SuccessResult data and
// an error if there was an issue with the request or response.
// This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.
func (c *CampaignsV3Api) CancelCampaign(
    ctx context.Context,
    accountName string,
    campaignId string) (
    models.ApiResponse[models.FotaV3SuccessResult],
    error) {
    req := c.prepareRequest(ctx, "DELETE", "/campaigns/%v/%v")
    req.AppendTemplateParams(accountName, campaignId)
    req.BaseUrl("Software Management V3")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Unexpected error.", Unmarshaller: errors.NewFotaV3Result},
    })
    
    var result models.FotaV3SuccessResult
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[models.FotaV3SuccessResult](decoder)
    return models.NewApiResponse(result, resp), err
}
