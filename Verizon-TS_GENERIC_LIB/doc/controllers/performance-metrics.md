# Performance Metrics

```ts
const performanceMetricsApi = new PerformanceMetricsApi(client);
```

## Class Name

`PerformanceMetricsApi`


# Query MEC Performance Metrics

Query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.

```ts
async queryMecPerformanceMetrics(
  body?: QueryMecPerformanceMetricsRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<MecPerformanceMetrics>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`QueryMecPerformanceMetricsRequest \| undefined`](../../doc/models/query-mec-performance-metrics-request.md) | Body, Optional | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [MecPerformanceMetrics](../../doc/models/mec-performance-metrics.md).

## Example Usage

```ts
const body: QueryMecPerformanceMetricsRequest = {
  imei: '440246108109673',
  msisdn: '10691876598',
};

try {
  const { result, ...httpResponse } = await performanceMetricsApi.queryMecPerformanceMetrics(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Example Response *(as JSON)*

```json
{
  "QueryStatus": "Success",
  "Start": "1/28/2021 12:00:00",
  "End": "1/28/2021 12:15:00",
  "QueryResult": [
    {
      "name": "NetworkAvailability",
      "data": [
        "100",
        "percent",
        "high"
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. | [`EdgePerformanceResultError`](../../doc/models/edge-performance-result-error.md) |
| 401 | Unauthorized request. | [`EdgePerformanceResultError`](../../doc/models/edge-performance-result-error.md) |
| 403 | Request forbidden. | [`EdgePerformanceResultError`](../../doc/models/edge-performance-result-error.md) |
| 404 | Resource Not Found. | [`EdgePerformanceResultError`](../../doc/models/edge-performance-result-error.md) |
| 405 | Method Not Allowed. | [`EdgePerformanceResultError`](../../doc/models/edge-performance-result-error.md) |
| 503 | Service Unavailable. | [`EdgePerformanceResultError`](../../doc/models/edge-performance-result-error.md) |

