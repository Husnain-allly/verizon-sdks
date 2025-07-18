# Device Diagnostics

```csharp
DeviceDiagnosticsApi deviceDiagnosticsApi = client.DeviceDiagnosticsApi;
```

## Class Name

`DeviceDiagnosticsApi`

## Methods

* [Device Reachability Status Using POST](../../doc/controllers/device-diagnostics.md#device-reachability-status-using-post)
* [Retrieve Active Monitors Using POST](../../doc/controllers/device-diagnostics.md#retrieve-active-monitors-using-post)


# Device Reachability Status Using POST

If the devices do not already exist in the account, this API resource adds them before activation.

```csharp
DeviceReachabilityStatusUsingPostAsync(
    Models.NotificationReportStatusRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`NotificationReportStatusRequest`](../../doc/models/notification-report-status-request.md) | Body, Required | Retrieve Reachability Report Status for a device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
NotificationReportStatusRequest body = new NotificationReportStatusRequest
{
    AccountName = "0868924207-00001",
    Device = new DeviceId
    {
        Id = "990013907835573",
        Kind = "imei",
    },
    RequestType = "requestType6",
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceDiagnosticsApi.DeviceReachabilityStatusUsingPostAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Retrieve Active Monitors Using POST

Retrieve all the active monitors.

```csharp
RetrieveActiveMonitorsUsingPostAsync(
    Models.RetrieveMonitorsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`RetrieveMonitorsRequest`](../../doc/models/retrieve-monitors-request.md) | Body, Required | Retrieve Monitor Request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```csharp
RetrieveMonitorsRequest body = new RetrieveMonitorsRequest
{
    AccountName = "0242123520-00001",
    Devices = new List<AccountDeviceList>
    {
        new AccountDeviceList
        {
            DeviceIds = new List<DeviceId>
            {
                new DeviceId
                {
                    Id = "12016560696",
                    Kind = "msisdn",
                },
            },
        },
    },
};

try
{
    ApiResponse<DeviceManagementResult> result = await deviceDiagnosticsApi.RetrieveActiveMonitorsUsingPostAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

