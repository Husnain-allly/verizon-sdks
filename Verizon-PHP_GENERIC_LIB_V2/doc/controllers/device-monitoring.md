# Device Monitoring

```php
$deviceMonitoringApi = $client->getDeviceMonitoringApi();
```

## Class Name

`DeviceMonitoringApi`

## Methods

* [Device Reachability](../../doc/controllers/device-monitoring.md#device-reachability)
* [Stop Device Reachability](../../doc/controllers/device-monitoring.md#stop-device-reachability)


# Device Reachability

```php
function deviceReachability(NotificationReportRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`NotificationReportRequest`](../../doc/models/notification-report-request.md) | Body, Required | Create Reachability Report Request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```php
$body = NotificationReportRequestBuilder::init(
    '0000123456-00001',
    'REACHABLE_FOR_DATA',
    [
        DeviceListBuilder::init()
            ->deviceIds(
                [
                    DeviceIdBuilder::init(
                        '20-digit ICCID',
                        'iccid'
                    )->build(),
                    DeviceIdBuilder::init(
                        '20-digit ICCID',
                        'iccid'
                    )->build()
                ]
            )->build()
    ],
    '2019-12-02T15:00:00-08:00Z'
)->build();

$apiResponse = $deviceMonitoringApi->deviceReachability($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Stop Device Reachability

```php
function stopDeviceReachability(StopMonitorRequest $stopreachabilitypayload): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stopreachabilitypayload` | [`StopMonitorRequest`](../../doc/models/stop-monitor-request.md) | Query, Required | Payload for the Stop Device Reachability monitors request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```php
$stopreachabilitypayload = StopMonitorRequestBuilder::init(
    '0000123456-00001',
    [
        '35596ca6-eeee-ffff-gggg-42b4fc2da54c'
    ]
)->build();

$apiResponse = $deviceMonitoringApi->stopDeviceReachability($stopreachabilitypayload);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

