# Device Monitoring

```ruby
device_monitoring_api = client.device_monitoring
```

## Class Name

`DeviceMonitoringApi`

## Methods

* [Device Reachability](../../doc/controllers/device-monitoring.md#device-reachability)
* [Stop Device Reachability](../../doc/controllers/device-monitoring.md#stop-device-reachability)


# Device Reachability

```ruby
def device_reachability(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`NotificationReportRequest`](../../doc/models/notification-report-request.md) | Body, Required | Create Reachability Report Request |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```ruby
body = NotificationReportRequest.new(
  account_name: '0000123456-00001',
  request_type: 'REACHABLE_FOR_DATA',
  devices: [
    DeviceList.new(
      device_ids: [
        DeviceId.new(
          id: '20-digit ICCID',
          kind: 'iccid'
        ),
        DeviceId.new(
          id: '20-digit ICCID',
          kind: 'iccid'
        )
      ]
    )
  ],
  monitor_expiration_time: '2019-12-02T15:00:00-08:00Z'
)

result = device_monitoring_api.device_reachability(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Stop Device Reachability

```ruby
def stop_device_reachability(stopreachabilitypayload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stopreachabilitypayload` | [`StopMonitorRequest`](../../doc/models/stop-monitor-request.md) | Query, Required | Payload for the Stop Device Reachability monitors request. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```ruby
stopreachabilitypayload = StopMonitorRequest.new(
  account_name: '0000123456-00001',
  monitor_ids: [
    '35596ca6-eeee-ffff-gggg-42b4fc2da54c'
  ]
)

result = device_monitoring_api.stop_device_reachability(stopreachabilitypayload)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

