# Sensor Insights Smart Alert Metrics

```python
sensor_insights_smart_alert_metrics_api = client.sensor_insights_smart_alert_metrics
```

## Class Name

`SensorInsightsSmartAlertMetricsApi`


# Sensorinsightsmetricsquery

Get Device Alerts for the most recent daily period, up to 30 days.

```python
def sensorinsightsmetricsquery(self,
                              body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoQueryMetrics`](../../doc/models/dto-query-metrics.md) | Body, Required | Daily period requested, up to 30 days. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`DtoQueryMetricsResponse`](../../doc/models/dto-query-metrics-response.md).

## Example Usage

```python
body = DtoQueryMetrics(
    days=30
)

result = sensor_insights_smart_alert_metrics_api.sensorinsightsmetricsquery(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

