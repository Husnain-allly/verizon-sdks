# Device Location Callbacks

```go
deviceLocationCallbacksApi := client.DeviceLocationCallbacksApi()
```

## Class Name

`DeviceLocationCallbacksApi`

## Methods

* [Cancel Async Report](../../doc/controllers/device-location-callbacks.md#cancel-async-report)
* [List Registered Callbacks](../../doc/controllers/device-location-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/device-location-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/device-location-callbacks.md#deregister-callback)


# Cancel Async Report

Cancel an asynchronous report request.

```go
CancelAsyncReport(
    ctx context.Context,
    accountName string,
    txid string) (
    models.ApiResponse[models.TransactionId],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | The `transactionId` value. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TransactionId](../../doc/models/transaction-id.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

txid := "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"

apiResponse, err := deviceLocationCallbacksApi.CancelAsyncReport(ctx, accountName, txid)
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Registered Callbacks

Returns a list of all registered callback URLs for the account.

```go
ListRegisteredCallbacks(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[[]models.DeviceLocationCallback],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DeviceLocationCallback](../../doc/models/device-location-callback.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

apiResponse, err := deviceLocationCallbacksApi.ListRegisteredCallbacks(ctx, accountName)
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
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/Location.asmx"
  },
  {
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/DeviceLocation.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Register Callback

Provide a URL to receive messages from a ThingSpace callback service.

```go
RegisterCallback(
    ctx context.Context,
    accountName string,
    body models.DeviceLocationCallback) (
    models.ApiResponse[models.CallbackRegistrationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |
| `body` | [`models.DeviceLocationCallback`](../../doc/models/device-location-callback.md) | Body, Required | Request to register a callback. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CallbackRegistrationResult](../../doc/models/callback-registration-result.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

body := models.DeviceLocationCallback{
    Name:                  models.CallbackServiceName_Location,
    Url:                   "http://10.120.102.183:50559/CallbackListener/LocationServiceMessages.asmx",
}

apiResponse, err := deviceLocationCallbacksApi.RegisterCallback(ctx, accountName, body)
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
  "account": "0212312345-00001",
  "name": "Location"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Deregister Callback

Deregister a URL to stop receiving callback messages.

```go
DeregisterCallback(
    ctx context.Context,
    accountName string,
    service models.CallbackServiceName) (
    models.ApiResponse[models.DeviceLocationSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |
| `service` | [`models.CallbackServiceName`](../../doc/models/callback-service-name.md) | Template, Required | Callback service name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceLocationSuccessResult](../../doc/models/device-location-success-result.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

service := models.CallbackServiceName_Location

apiResponse, err := deviceLocationCallbacksApi.DeregisterCallback(ctx, accountName, service)
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

