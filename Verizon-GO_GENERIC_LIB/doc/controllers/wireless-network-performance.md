# Wireless Network Performance

```go
wirelessNetworkPerformanceApi := client.WirelessNetworkPerformanceApi()
```

## Class Name

`WirelessNetworkPerformanceApi`

## Methods

* [Near Real Time Network Conditions](../../doc/controllers/wireless-network-performance.md#near-real-time-network-conditions)
* [Domestic 4 G and 5G Nationwide Network Coverage](../../doc/controllers/wireless-network-performance.md#domestic-4-g-and-5g-nationwide-network-coverage)
* [Site Proximity](../../doc/controllers/wireless-network-performance.md#site-proximity)
* [Device Experience 30 Days History](../../doc/controllers/wireless-network-performance.md#device-experience-30-days-history)
* [Device Experience Bulk Latest](../../doc/controllers/wireless-network-performance.md#device-experience-bulk-latest)


# Near Real Time Network Conditions

WNP Query for current network condition.

```go
NearRealTimeNetworkConditions(
    ctx context.Context,
    body models.GetNetworkConditionsRequest) (
    models.ApiResponse[models.WnpRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for current network health. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GetNetworkConditionsRequest{
    AccountName:  "0000123456-00001",
    LocationType: "LONGLAT",
    Coordinates:  models.Coordinates{
        Latitude:  models.ToPointer("-33.84819"),
        Longitude: models.ToPointer("151.22049"),
    },
}

apiResponse, err := wirelessNetworkPerformanceApi.NearRealTimeNetworkConditions(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Domestic 4 G and 5G Nationwide Network Coverage

Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.

```go
Domestic4GAnd5GNationwideNetworkCoverage(
    ctx context.Context,
    body models.M2MV1IntelligenceWirelessCoverageRequest) (
    models.ApiResponse[models.WnpRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.M2MV1IntelligenceWirelessCoverageRequest`](../../doc/models/m2m-v1-intelligence-wireless-coverage-request.md) | Body, Required | Request for network coverage details. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.M2MV1IntelligenceWirelessCoverageRequest{
    AccountName:           models.ToPointer("0000123456-00001"),
    RequestType:           models.ToPointer("FWA"),
    LocationType:          models.ToPointer("ADDRESS"),
    Locations:             models.ToPointer(models.Locations1{
        AddressList:           []models.AddressItem{
            models.AddressItem{
                AddressLine1: models.ToPointer("street address"),
                City:         models.ToPointer("city"),
                State:        models.ToPointer("LA"),
                Country:      models.ToPointer("USA"),
                Zip:          models.ToPointer("00000"),
            },
        },
    }),
    NetworkTypesList:      []models.NetworkTypeObject{
        models.NetworkTypeObject{
            NetworkType: models.ToPointer("LTE"),
        },
    },
}

apiResponse, err := wirelessNetworkPerformanceApi.Domestic4GAnd5GNationwideNetworkCoverage(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Site Proximity

Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.

```go
SiteProximity(
    ctx context.Context,
    body models.GetNetworkConditionsRequest) (
    models.ApiResponse[models.WnpRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for cell site proximity. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GetNetworkConditionsRequest{
    AccountName:  "0000123456-00001",
    LocationType: "LONGLAT",
    Coordinates:  models.Coordinates{
        Latitude:  models.ToPointer("-33.84819"),
        Longitude: models.ToPointer("151.22049"),
    },
}

apiResponse, err := wirelessNetworkPerformanceApi.SiteProximity(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience 30 Days History

A report of a specific device's service scores over a 30 day period.

```go
DeviceExperience30DaysHistory(
    ctx context.Context,
    body models.GetDeviceExperienceScoreHistoryRequest) (
    models.ApiResponse[models.WnpRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GetDeviceExperienceScoreHistoryRequest`](../../doc/models/get-device-experience-score-history-request.md) | Body, Required | Request for a device's 30 day experience. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GetDeviceExperienceScoreHistoryRequest{
    AccountName: "0000123456-00001",
    DeviceId:    models.DeviceIdentifier{
        Kind: "iccid",
        Id:   "01234567899876543210",
        Mdn:  models.ToPointer("0123456789"),
    },
}

apiResponse, err := wirelessNetworkPerformanceApi.DeviceExperience30DaysHistory(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience Bulk Latest

Run a report to view the latest device experience score for specific devices.

```go
DeviceExperienceBulkLatest(
    ctx context.Context,
    body models.GetDeviceExperienceScoreBulkRequest) (
    models.ApiResponse[models.WnpRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GetDeviceExperienceScoreBulkRequest`](../../doc/models/get-device-experience-score-bulk-request.md) | Body, Required | Request for bulk latest history details. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GetDeviceExperienceScoreBulkRequest{
    AccountName: "0000123456-00001",
    DeviceList:  []models.DeviceIdentifier{
        models.DeviceIdentifier{
            Kind: "iccid",
            Id:   "01234567899876543210",
            Mdn:  models.ToPointer("0123456789"),
        },
    },
}

apiResponse, err := wirelessNetworkPerformanceApi.DeviceExperienceBulkLatest(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |

