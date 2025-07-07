# Connectivity Callbacks

```go
connectivityCallbacksApi := client.ConnectivityCallbacksApi()
```

## Class Name

`ConnectivityCallbacksApi`

## Methods

* [List Registered Callbacks](../../doc/controllers/connectivity-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/connectivity-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/connectivity-callbacks.md#deregister-callback)


# List Registered Callbacks

Returns the name and endpoint URL of the callback listening services registered for a given account.

```go
ListRegisteredCallbacks(
    ctx context.Context,
    aname string) (
    models.ApiResponse[[]models.ConnectivityManagementCallback],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.ConnectivityManagementCallback](../../doc/models/connectivity-management-callback.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"

apiResponse, err := connectivityCallbacksApi.ListRegisteredCallbacks(ctx, aname)
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
[
  {
    "accountName": "0252012345-00001",
    "serviceName": "CarrierService",
    "url": "http://10.120.102.147:50569/CallbackListener/Carrier.asmx"
  },
  {
    "accountName": "0252012345-00001",
    "password": "drowssap",
    "serviceName": "DeviceUsage",
    "url": "http://10.120.102.147:50569/CallbackListener/Usage.asmx",
    "username": "zaffod"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Register Callback

You are responsible for creating and running a listening process on your server at that URL.

```go
RegisterCallback(
    ctx context.Context,
    aname string,
    body models.RegisterCallbackRequest) (
    models.ApiResponse[models.CallbackActionResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `body` | [`models.RegisterCallbackRequest`](../../doc/models/register-callback-request.md) | Body, Required | Request to register a callback. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CallbackActionResult](../../doc/models/callback-action-result.md).

## Example Usage

```go
ctx := context.Background()

aname := "TestAccount-2"

body := models.RegisterCallbackRequest{
    Name:                  "CarrierService",
    Url:                   "https://mock.thingspace.verizon.com/webhook",
}

apiResponse, err := connectivityCallbacksApi.RegisterCallback(ctx, aname, body)
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
  "accountName": "122333444-00002",
  "serviceName": "CarrierService"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Deregister Callback

Stops ThingSpace from sending callback messages for the specified account and service.

```go
DeregisterCallback(
    ctx context.Context,
    aname string,
    sname string) (
    models.ApiResponse[models.CallbackActionResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `sname` | `string` | Template, Required | Service name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CallbackActionResult](../../doc/models/callback-action-result.md).

## Example Usage

```go
ctx := context.Background()

aname := "1223334444-00001"

sname := "CarrierService"

apiResponse, err := connectivityCallbacksApi.DeregisterCallback(ctx, aname, sname)
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
  "accountName": "1223334444-00001",
  "serviceName": "CarrierService"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

