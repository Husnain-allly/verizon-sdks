# Device Actions

```go
deviceActionsApi := client.DeviceActionsApi()
```

## Class Name

`DeviceActionsApi`

## Methods

* [Aggregate Usage](../../doc/controllers/device-actions.md#aggregate-usage)
* [Daily Usage](../../doc/controllers/device-actions.md#daily-usage)
* [Service Plan List](../../doc/controllers/device-actions.md#service-plan-list)
* [Account Information](../../doc/controllers/device-actions.md#account-information)
* [Retrieve the Global Device List](../../doc/controllers/device-actions.md#retrieve-the-global-device-list)
* [Retrieve Device Provisioning History](../../doc/controllers/device-actions.md#retrieve-device-provisioning-history)
* [Get Asynchronous Request Status](../../doc/controllers/device-actions.md#get-asynchronous-request-status)


# Aggregate Usage

Retrieve the aggregate usage for a device or a number of devices.

```go
AggregateUsage(
    ctx context.Context,
    body models.AggregateUsage) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.AggregateUsage`](../../doc/models/aggregate-usage.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.AggregateUsage{
}

apiResponse, err := deviceActionsApi.AggregateUsage(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Daily Usage

Retrieve the daily usage for a device, for a specified period of time, segmented by day

```go
DailyUsage(
    ctx context.Context,
    body models.DailyUsage) (
    models.ApiResponse[models.DailyUsageResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DailyUsage`](../../doc/models/daily-usage.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DailyUsageResponse](../../doc/models/daily-usage-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DailyUsage{
}

apiResponse, err := deviceActionsApi.DailyUsage(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Service Plan List

Retrieve all of the service plans, features and carriers associated with the account specified.

```go
ServicePlanList(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.AccountDetails],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AccountDetails](../../doc/models/account-details.md).

## Example Usage

```go
ctx := context.Background()

accountName := "accountName4"

apiResponse, err := deviceActionsApi.ServicePlanList(ctx, accountName)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Account Information

Retrieve all of the service plans, features and carriers associated with the account specified.

```go
AccountInformation(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.AccountDetails],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AccountDetails](../../doc/models/account-details.md).

## Example Usage

```go
ctx := context.Background()

accountName := "accountName4"

apiResponse, err := deviceActionsApi.AccountInformation(ctx, accountName)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Retrieve the Global Device List

Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.

```go
RetrieveTheGlobalDeviceList(
    ctx context.Context,
    body models.GetDeviceListWithProfilesRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GetDeviceListWithProfilesRequest`](../../doc/models/get-device-list-with-profiles-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GetDeviceListWithProfilesRequest{
    AccountName:              "0000123456-00001",
    ProvisioningStatusFilter: models.ToPointer("ACTIVE"),
    ProfileStatusFilter:      models.ToPointer("UNKNOWN"),
}

apiResponse, err := deviceActionsApi.RetrieveTheGlobalDeviceList(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Retrieve Device Provisioning History

Retrieve the provisioning history of a specific device or devices.

```go
RetrieveDeviceProvisioningHistory(
    ctx context.Context,
    body models.ProvhistoryRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProvhistoryRequest`](../../doc/models/provhistory-request.md) | Body, Required | Device Provisioning History |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProvhistoryRequest{
    AccountName:  models.ToPointer("0000123456-00001"),
    Earliest:     models.ToPointer(parseTime(time.RFC3339, "10/15/2021 04:49:35", func(err error) { log.Fatalln(err) })),
    Latest:       models.ToPointer(parseTime(time.RFC3339, "10/15/2021 04:49:49", func(err error) { log.Fatalln(err) })),
}

apiResponse, err := deviceActionsApi.RetrieveDeviceProvisioningHistory(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Get Asynchronous Request Status

Get the status of an asynchronous request made with the Device Actions.

```go
GetAsynchronousRequestStatus(
    ctx context.Context,
    accountName string,
    requestId string) (
    models.ApiResponse[models.StatusResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `requestId` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9\-]{3,64}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.StatusResponse](../../doc/models/status-response.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

requestId := "d1f08526-5443-4054-9a29-4456490ea9f8"

apiResponse, err := deviceActionsApi.GetAsynchronousRequestStatus(ctx, accountName, requestId)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

