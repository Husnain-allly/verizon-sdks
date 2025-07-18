/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package verizon

import (
    "context"
    "fmt"
    "github.com/apimatic/go-core-runtime/https"
    "verizon/errors"
    "verizon/models"
)

// MapDataManagerApi represents a controller struct.
type MapDataManagerApi struct {
    baseApi
}

// NewMapDataManagerApi creates a new instance of MapDataManagerApi.
// It takes a baseController as a parameter and returns a pointer to the MapDataManagerApi.
func NewMapDataManagerApi(baseApi baseApi) *MapDataManagerApi {
    mapDataManagerApi := MapDataManagerApi{baseApi: baseApi}
    return &mapDataManagerApi
}

// UploadMapDataMessage takes context, vendorId, body as parameters and
// returns an models.ApiResponse with string data and
// an error if there was an issue with the request or response.
// This endpoint allows the user to upload map messages in SAE J2735 MAP messages in ASN.1 UPER or JER (JSON) formats. The MAP data message can have more than one intersections in it.
// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
func (m *MapDataManagerApi) UploadMapDataMessage(
    ctx context.Context,
    vendorId string,
    body string) (
    models.ApiResponse[string],
    error) {
    req := m.prepareRequest(ctx, "POST", "/api/v2/mapdata")
    
    req.BaseUrl("IMP Server")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("SessionToken"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Invalid request", Unmarshaller: errors.NewMapDataResponseError},
        "401": {Message: "Unauthorized", Unmarshaller: errors.NewMapDataResponseError},
        "403": {Message: "Forbidden Request", Unmarshaller: errors.NewMapDataResponseError},
        "429": {Message: "Too Many Requests", Unmarshaller: errors.NewMapDataResponseError},
        "503": {Message: "Internal server Error", Unmarshaller: errors.NewMapDataResponseError},
        "0": {Message: "Unexpected Error", Unmarshaller: errors.NewMapDataResponseError},
    })
    req.Header("VendorID", vendorId)
    req.Header("Content-Type", "application/json")
    req.Text(fmt.Sprint(body))
    str, resp, err := req.CallAsText()
    var result string = str

    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    return models.NewApiResponse(result, resp), err
}

// DownloadMapDataMessage takes context, vendorId, geofence as parameters and
// returns an models.ApiResponse with string data and
// an error if there was an issue with the request or response.
// This endpoint allows user to download SAE J2735 MAP messages in ASN.1 UPER format. The area for the MAP messages is needed to be defined in the query.
func (m *MapDataManagerApi) DownloadMapDataMessage(
    ctx context.Context,
    vendorId string,
    geofence models.Geofence) (
    models.ApiResponse[string],
    error) {
    req := m.prepareRequest(ctx, "GET", "/api/v2/mapdata")
    
    req.BaseUrl("IMP Server")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("SessionToken"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Invalid request", Unmarshaller: errors.NewMapDataResponseError},
        "401": {Message: "Unauthorized", Unmarshaller: errors.NewMapDataResponseError},
        "403": {Message: "Forbidden Request", Unmarshaller: errors.NewMapDataResponseError},
        "429": {Message: "Too Many Requests", Unmarshaller: errors.NewMapDataResponseError},
        "503": {Message: "Internal server Error", Unmarshaller: errors.NewMapDataResponseError},
        "0": {Message: "Unexpected Error", Unmarshaller: errors.NewMapDataResponseError},
    })
    req.Header("VendorID", vendorId)
    req.QueryParam("Geofence", geofence)
    str, resp, err := req.CallAsText()
    var result string = str

    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    return models.NewApiResponse(result, resp), err
}
