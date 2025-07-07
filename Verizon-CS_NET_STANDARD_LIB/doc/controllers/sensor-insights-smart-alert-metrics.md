# Sensor Insights Smart Alert Metrics

```csharp
SensorInsightsSmartAlertMetricsApi sensorInsightsSmartAlertMetricsApi = client.SensorInsightsSmartAlertMetricsApi;
```

## Class Name

`SensorInsightsSmartAlertMetricsApi`


# Sensorinsightsmetricsquery

Get Device Alerts for the most recent daily period, up to 30 days.

```csharp
SensorinsightsmetricsqueryAsync(
    Models.DtoQueryMetrics body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoQueryMetrics`](../../doc/models/dto-query-metrics.md) | Body, Required | Daily period requested, up to 30 days. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoQueryMetricsResponse](../../doc/models/dto-query-metrics-response.md).

## Example Usage

```csharp
DtoQueryMetrics body = new DtoQueryMetrics
{
    Days = 30,
};

try
{
    ApiResponse<DtoQueryMetricsResponse> result = await sensorInsightsSmartAlertMetricsApi.SensorinsightsmetricsqueryAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

