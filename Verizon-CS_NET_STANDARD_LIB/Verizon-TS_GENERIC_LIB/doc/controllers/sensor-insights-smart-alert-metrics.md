# Sensor Insights Smart Alert Metrics

```ts
const sensorInsightsSmartAlertMetricsApi = new SensorInsightsSmartAlertMetricsApi(client);
```

## Class Name

`SensorInsightsSmartAlertMetricsApi`


# Sensorinsightsmetricsquery

Get Device Alerts for the most recent daily period, up to 30 days.

```ts
async sensorinsightsmetricsquery(
  body: DtoQueryMetrics,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoQueryMetricsResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoQueryMetrics`](../../doc/models/dto-query-metrics.md) | Body, Required | Daily period requested, up to 30 days. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoQueryMetricsResponse](../../doc/models/dto-query-metrics-response.md).

## Example Usage

```ts
const body: DtoQueryMetrics = {
  days: 30,
};

try {
  const { result, ...httpResponse } = await sensorInsightsSmartAlertMetricsApi.sensorinsightsmetricsquery(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementError`](../../doc/models/m400-management-error.md) |
| 401 | UnAuthorized | [`ManagementError`](../../doc/models/management-error.md) |
| 403 | Forbidden | [`M403ManagementError`](../../doc/models/m403-management-error.md) |
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |

