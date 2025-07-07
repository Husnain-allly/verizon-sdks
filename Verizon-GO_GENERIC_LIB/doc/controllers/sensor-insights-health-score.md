# Sensor Insights Health Score

```go
sensorInsightsHealthScoreApi := client.SensorInsightsHealthScoreApi()
```

## Class Name

`SensorInsightsHealthScoreApi`

## Methods

* [Sensor Insights Health Score Summary](../../doc/controllers/sensor-insights-health-score.md#sensor-insights-health-score-summary)
* [Sensor Insights Get Network Health Score Response](../../doc/controllers/sensor-insights-health-score.md#sensor-insights-get-network-health-score-response)


# Sensor Insights Health Score Summary

```go
SensorInsightsHealthScoreSummary(
    ctx context.Context) (
    models.ApiResponse[models.DtoHealthScoreSummary],
    error)
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoHealthScoreSummary](../../doc/models/dto-health-score-summary.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := sensorInsightsHealthScoreApi.SensorInsightsHealthScoreSummary(ctx)
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Get Network Health Score Response

```go
SensorInsightsGetNetworkHealthScoreResponse(
    ctx context.Context) (
    models.ApiResponse[models.DtoGetNetworkHealthScoreResponse],
    error)
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoGetNetworkHealthScoreResponse](../../doc/models/dto-get-network-health-score-response.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := sensorInsightsHealthScoreApi.SensorInsightsGetNetworkHealthScoreResponse(ctx)
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

