# Device Diagnostics

```go
deviceDiagnosticsApi := client.DeviceDiagnosticsApi()
```

## Class Name

`DeviceDiagnosticsApi`

## Methods

* [Device Reachability Status Using POST](../../doc/controllers/device-diagnostics.md#device-reachability-status-using-post)
* [Retrieve Active Monitors Using POST](../../doc/controllers/device-diagnostics.md#retrieve-active-monitors-using-post)


# Device Reachability Status Using POST

If the devices do not already exist in the account, this API resource adds them before activation.

```go
DeviceReachabilityStatusUsingPost(
    ctx context.Context,
    body models.NotificationReportStatusRequest) (
    models.ApiResponse[models.DeviceManagementResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.NotificationReportStatusRequest`](../../doc/models/notification-report-status-request.md) | Body, Required | Retrieve Reachability Report Status for a device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.NotificationReportStatusRequest{
    AccountName:           "0868924207-00001",
    Device:                models.DeviceId{
        Id:                    "990013907835573",
        Kind:                  "imei",
    },
    RequestType:           "requestType6",
}

apiResponse, err := deviceDiagnosticsApi.DeviceReachabilityStatusUsingPost(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

```go
RetrieveActiveMonitorsUsingPost(
    ctx context.Context,
    body models.RetrieveMonitorsRequest) (
    models.ApiResponse[models.DeviceManagementResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.RetrieveMonitorsRequest`](../../doc/models/retrieve-monitors-request.md) | Body, Required | Retrieve Monitor Request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.RetrieveMonitorsRequest{
    AccountName: "0242123520-00001",
    Devices:     []models.AccountDeviceList{
        models.AccountDeviceList{
            DeviceIds:             []models.DeviceId{
                models.DeviceId{
                    Id:                    "12016560696",
                    Kind:                  "msisdn",
                },
            },
        },
    },
}

apiResponse, err := deviceDiagnosticsApi.RetrieveActiveMonitorsUsingPost(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

