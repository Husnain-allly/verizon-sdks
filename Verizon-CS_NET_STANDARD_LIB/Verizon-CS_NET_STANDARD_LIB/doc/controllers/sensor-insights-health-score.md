# Sensor Insights Health Score

```csharp
SensorInsightsHealthScoreApi sensorInsightsHealthScoreApi = client.SensorInsightsHealthScoreApi;
```

## Class Name

`SensorInsightsHealthScoreApi`

## Methods

* [Sensor Insights Health Score Summary](../../doc/controllers/sensor-insights-health-score.md#sensor-insights-health-score-summary)
* [Sensor Insights Get Network Health Score Response](../../doc/controllers/sensor-insights-health-score.md#sensor-insights-get-network-health-score-response)


# Sensor Insights Health Score Summary

```csharp
SensorInsightsHealthScoreSummaryAsync()
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoHealthScoreSummary](../../doc/models/dto-health-score-summary.md).

## Example Usage

```csharp
try
{
    ApiResponse<DtoHealthScoreSummary> result = await sensorInsightsHealthScoreApi.SensorInsightsHealthScoreSummaryAsync();
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Get Network Health Score Response

```csharp
SensorInsightsGetNetworkHealthScoreResponseAsync()
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DtoGetNetworkHealthScoreResponse](../../doc/models/dto-get-network-health-score-response.md).

## Example Usage

```csharp
try
{
    ApiResponse<DtoGetNetworkHealthScoreResponse> result = await sensorInsightsHealthScoreApi.SensorInsightsGetNetworkHealthScoreResponseAsync();
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

