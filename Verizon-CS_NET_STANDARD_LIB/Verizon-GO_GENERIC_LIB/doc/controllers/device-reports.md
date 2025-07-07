# Device Reports

```go
deviceReportsApi := client.DeviceReportsApi()
```

## Class Name

`DeviceReportsApi`

## Methods

* [Calculate Aggregated Report Synchronous](../../doc/controllers/device-reports.md#calculate-aggregated-report-synchronous)
* [Calculate Aggregated Report Asynchronous](../../doc/controllers/device-reports.md#calculate-aggregated-report-asynchronous)
* [Get Sessions Report](../../doc/controllers/device-reports.md#get-sessions-report)


# Calculate Aggregated Report Synchronous

Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).

```go
CalculateAggregatedReportSynchronous(
    ctx context.Context,
    body models.AggregateSessionReportRequest) (
    models.ApiResponse[models.AggregateSessionReport],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.AggregateSessionReportRequest`](../../doc/models/aggregate-session-report-request.md) | Body, Required | Aggregated report request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AggregateSessionReport](../../doc/models/aggregate-session-report.md).

## Example Usage

```go
ctx := context.Background()

body := models.AggregateSessionReportRequest{
    AccountNumber:         "0844021539-00001",
    StartDate:             models.ToPointer("2022-12-09T22:01:06.217Z"),
    EndDate:               models.ToPointer("2022-12-09T22:01:08.734Z"),
    Imei:                  []string{
        "709312034493372",
    },
    NoSessionFlag:         models.ToPointer("false"),
}

apiResponse, err := deviceReportsApi.CalculateAggregatedReportSynchronous(ctx, body)
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
  "txid": null,
  "usage": [
    {
      "imei": "709312034493372",
      "numberOfSessions": 1,
      "bytesTransferred": 2057
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |


# Calculate Aggregated Report Asynchronous

Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).

```go
CalculateAggregatedReportAsynchronous(
    ctx context.Context,
    body models.AggregateSessionReportRequest) (
    models.ApiResponse[models.AggregatedReportCallbackResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.AggregateSessionReportRequest`](../../doc/models/aggregate-session-report-request.md) | Body, Required | Aggregated session report request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AggregatedReportCallbackResult](../../doc/models/aggregated-report-callback-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.AggregateSessionReportRequest{
    AccountNumber:         "0844021539-00001",
    StartDate:             models.ToPointer("2022-12-09T22:01:06.217Z"),
    EndDate:               models.ToPointer("2022-12-09T22:01:08.734Z"),
    Imei:                  []string{
        "709312034493372",
    },
    NoSessionFlag:         models.ToPointer("false"),
}

apiResponse, err := deviceReportsApi.CalculateAggregatedReportAsynchronous(ctx, body)
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
  "txid": "60c07fff-470b-4d6d-afcc-75e6a7c238f6",
  "status": "QUEUED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |


# Get Sessions Report

Detailed report of session duration and number of bytes transferred per day.

```go
GetSessionsReport(
    ctx context.Context,
    body models.SessionReportRequest) (
    models.ApiResponse[models.SessionReport],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SessionReportRequest`](../../doc/models/session-report-request.md) | Body, Required | Request for sessions report. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SessionReport](../../doc/models/session-report.md).

## Example Usage

```go
ctx := context.Background()

body := models.SessionReportRequest{
    AccountNumber:         "0844021539-00001",
    Imei:                  "709312034493372",
    StartDate:             models.ToPointer("2022-12-09T22:01:06.217Z"),
    EndDate:               models.ToPointer("2022-12-09T22:01:08.734Z"),
}

apiResponse, err := deviceReportsApi.GetSessionsReport(ctx, body)
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
  "id": "709312034493372",
  "txid": "60c07fff-470b-4d6d-afcc-75e6a7c238f6"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 401 | Unauthorized request. Access token is missing or invalid. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 403 | Forbidden request. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 404 | Bad request. Not found. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 409 | Bad request. Conflict state. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |
| 500 | Internal Server Error. | [`HyperPreciseLocationResultException`](../../doc/models/hyper-precise-location-result-exception.md) |

