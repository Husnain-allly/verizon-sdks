# Device Monitoring

```csharp
DeviceMonitoringApi deviceMonitoringApi = client.DeviceMonitoringApi;
```

## Class Name

`DeviceMonitoringApi`

## Methods

* [Device Reachability](../../doc/controllers/device-monitoring.md#device-reachability)
* [Stop Device Reachability](../../doc/controllers/device-monitoring.md#stop-device-reachability)


# Device Reachability

```csharp
DeviceReachabilityAsync(
    Models.NotificationReportRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`NotificationReportRequest`](../../doc/models/notification-report-request.md) | Body, Required | Create Reachability Report Request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```csharp
NotificationReportRequest body = new NotificationReportRequest
{
    AccountName = "0000123456-00001",
    RequestType = "REACHABLE_FOR_DATA",
    Devices = new List<DeviceList>
    {
        new DeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
                new DeviceId
                {
                    Id = "20-digit ICCID",
                    Kind = "iccid",
                },
            },
        },
    },
    MonitorExpirationTime = "2019-12-02T15:00:00-08:00Z",
};

try
{
    ApiResponse<RequestResponse> result = await deviceMonitoringApi.DeviceReachabilityAsync(body);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Stop Device Reachability

```csharp
StopDeviceReachabilityAsync(
    Models.StopMonitorRequest stopreachabilitypayload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stopreachabilitypayload` | [`StopMonitorRequest`](../../doc/models/stop-monitor-request.md) | Query, Required | Payload for the Stop Device Reachability monitors request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```csharp
StopMonitorRequest stopreachabilitypayload = new StopMonitorRequest
{
    AccountName = "0000123456-00001",
    MonitorIds = new List<string>
    {
        "35596ca6-eeee-ffff-gggg-42b4fc2da54c",
    },
};

try
{
    ApiResponse<RequestResponse> result = await deviceMonitoringApi.StopDeviceReachabilityAsync(stopreachabilitypayload);
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

