# Map Data Manager

```go
mapDataManagerApi := client.MapDataManagerApi()
```

## Class Name

`MapDataManagerApi`

## Methods

* [Upload Map Data Message](../../doc/controllers/map-data-manager.md#upload-map-data-message)
* [Download Map Data Message](../../doc/controllers/map-data-manager.md#download-map-data-message)


# Upload Map Data Message

This endpoint allows the user to upload map messages in SAE J2735 MAP messages in ASN.1 UPER or JER (JSON) formats. The MAP data message can have more than one intersections in it.
Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```go
UploadMapDataMessage(
    ctx context.Context,
    vendorId string,
    body string) (
    models.ApiResponse[string],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | `string` | Body, Required | **Constraints**: *Maximum Length*: `1000000` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type string.

## Example Usage

```go
ctx := context.Background()

vendorId := "VerizonETX"

body := "{\"messageId\":18,\"value\":{\"intersections\":[{\"id\":{\"region\":0,\"id\":156},\"laneSet\":[{\"connectsTo\":[{\"connectingLane\":{\"lane\":25,\"maneuver\":\"8000\"},\"signalGroup\":2},{\"connectingLane\":{\"lane\":29,\"maneuver\":\"2000\"},\"signalGroup\":2}],\"laneAttributes\":{\"directionalUse\":\"80\",\"laneType\":{\"parking\":\"0000\"},\"sharedWith\":\"0000\"},\"laneID\":1,\"maneuvers\":\"a000\",\"nodeList\":{\"nodes\":[{\"delta\":{\"node-XY6\":{\"x\":-4012,\"y\":365}}},{\"delta\":{\"node-XY6\":{\"x\":-5541,\"y\":7249}}},{\"delta\":{\"node-XY6\":{\"x\":-4379,\"y\":5828}}},{\"delta\":{\"node-XY6\":{\"x\":-3590,\"y\":4729}}},{\"delta\":{\"node-XY6\":{\"x\":-5012,\"y\":6994}}}]}}],\"laneWidth\":366,\"refPoint\":{\"lat\":389284111,\"long\":-772410713},\"revision\":3}],\"msgIssueRevision\":3}}\n"

apiResponse, err := mapDataManagerApi.UploadMapDataMessage(ctx, vendorId, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 401 | Unauthorized | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 403 | Forbidden Request | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 429 | Too Many Requests | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 503 | Internal server Error | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| Default | Unexpected Error | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |


# Download Map Data Message

This endpoint allows user to download SAE J2735 MAP messages in ASN.1 UPER format. The area for the MAP messages is needed to be defined in the query.

```go
DownloadMapDataMessage(
    ctx context.Context,
    vendorId string,
    geofence models.Geofence) (
    models.ApiResponse[string],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `geofence` | [`models.Geofence`](../../doc/models/geofence.md) | Query, Required | The area where the user wants to receive MAP data from. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type string.

## Example Usage

```go
ctx := context.Background()

vendorId := "VerizonETX"

geofence := models.Geofence{
    Type:        "Polygon",
    Coordinates: [][]float64{
        {
            float64(-77.479395),
            float64(38.990773),
        },
        {
            float64(-77.114566),
            float64(38.99944),
        },
        {
            float64(-77.100228),
            float64(38.817204),
        },
        {
            float64(-77.418059),
            float64(38.827754),
        },
        {
            float64(-77.479395),
            float64(38.990773),
        },
    },
}

apiResponse, err := mapDataManagerApi.DownloadMapDataMessage(ctx, vendorId, geofence)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 401 | Unauthorized | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 403 | Forbidden Request | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 429 | Too Many Requests | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| 503 | Internal server Error | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |
| Default | Unexpected Error | [`MapDataResponseErrorException`](../../doc/models/map-data-response-error-exception.md) |

