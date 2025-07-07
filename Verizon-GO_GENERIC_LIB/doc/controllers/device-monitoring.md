# Device Monitoring

```go
deviceMonitoringApi := client.DeviceMonitoringApi()
```

## Class Name

`DeviceMonitoringApi`

## Methods

* [Device Reachability](../../doc/controllers/device-monitoring.md#device-reachability)
* [Stop Device Reachability](../../doc/controllers/device-monitoring.md#stop-device-reachability)


# Device Reachability

```go
DeviceReachability(
    ctx context.Context,
    body models.NotificationReportRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.NotificationReportRequest`](../../doc/models/notification-report-request.md) | Body, Required | Create Reachability Report Request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.NotificationReportRequest{
    AccountName:           "0000123456-00001",
    RequestType:           "REACHABLE_FOR_DATA",
    Devices:               []models.DeviceList{
        models.DeviceList{
            DeviceIds: []models.DeviceId{
                models.DeviceId{
                    Id:                    "20-digit ICCID",
                    Kind:                  "iccid",
                },
                models.DeviceId{
                    Id:                    "20-digit ICCID",
                    Kind:                  "iccid",
                },
            },
        },
    },
    MonitorExpirationTime: "2019-12-02T15:00:00-08:00Z",
}

apiResponse, err := deviceMonitoringApi.DeviceReachability(ctx, body)
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Stop Device Reachability

```go
StopDeviceReachability(
    ctx context.Context,
    stopreachabilitypayload models.StopMonitorRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stopreachabilitypayload` | [`models.StopMonitorRequest`](../../doc/models/stop-monitor-request.md) | Query, Required | Payload for the Stop Device Reachability monitors request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

stopreachabilitypayload := models.StopMonitorRequest{
    AccountName:           "0000123456-00001",
    MonitorIds:            []string{
        "35596ca6-eeee-ffff-gggg-42b4fc2da54c",
    },
}

apiResponse, err := deviceMonitoringApi.StopDeviceReachability(ctx, stopreachabilitypayload)
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

