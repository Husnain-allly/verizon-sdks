# Sensor Insights Smart Alert Metrics

```go
sensorInsightsSmartAlertMetricsApi := client.SensorInsightsSmartAlertMetricsApi()
```

## Class Name

`SensorInsightsSmartAlertMetricsApi`


# Sensorinsightsmetricsquery

Get Device Alerts for the most recent daily period, up to 30 days.

```go
Sensorinsightsmetricsquery(
    ctx context.Context,
    body models.DtoQueryMetrics) (
    models.ApiResponse[models.DtoQueryMetricsResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoQueryMetrics`](../../doc/models/dto-query-metrics.md) | Body, Required | Daily period requested, up to 30 days. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoQueryMetricsResponse](../../doc/models/dto-query-metrics-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoQueryMetrics{
    Days: models.ToPointer(30),
}

apiResponse, err := sensorInsightsSmartAlertMetricsApi.Sensorinsightsmetricsquery(ctx, body)
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

