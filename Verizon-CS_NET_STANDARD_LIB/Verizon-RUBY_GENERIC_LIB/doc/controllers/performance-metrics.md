# Performance Metrics

```ruby
performance_metrics_api = client.performance_metrics
```

## Class Name

`PerformanceMetricsApi`


# Query MEC Performance Metrics

Query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.

```ruby
def query_mec_performance_metrics(body: nil)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`QueryMecPerformanceMetricsRequest`](../../doc/models/query-mec-performance-metrics-request.md) | Body, Optional | - |

## Server

`Server::PERFORMANCE`

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`MecPerformanceMetrics`](../../doc/models/mec-performance-metrics.md).

## Example Usage

```ruby
body = QueryMecPerformanceMetricsRequest.new(
  imei: '440246108109673',
  msisdn: '10691876598'
)

result = performance_metrics_api.query_mec_performance_metrics(body: body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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
| 400 | Bad Request. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 401 | Unauthorized request. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 403 | Request forbidden. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 404 | Resource Not Found. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 405 | Method Not Allowed. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |
| 503 | Service Unavailable. | [`EdgePerformanceResultException`](../../doc/models/edge-performance-result-exception.md) |

