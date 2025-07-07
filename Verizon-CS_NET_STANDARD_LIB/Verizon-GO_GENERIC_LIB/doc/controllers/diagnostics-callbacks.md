# Diagnostics Callbacks

```go
diagnosticsCallbacksApi := client.DiagnosticsCallbacksApi()
```

## Class Name

`DiagnosticsCallbacksApi`

## Methods

* [Get Diagnostics Subscription Callback Info](../../doc/controllers/diagnostics-callbacks.md#get-diagnostics-subscription-callback-info)
* [Register Diagnostics Callback URL](../../doc/controllers/diagnostics-callbacks.md#register-diagnostics-callback-url)
* [Unregister Diagnostics Callback](../../doc/controllers/diagnostics-callbacks.md#unregister-diagnostics-callback)


# Get Diagnostics Subscription Callback Info

This endpoint allows user to get the registered callback information of an existing diagnostics subscription.

```go
GetDiagnosticsSubscriptionCallbackInfo(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[[]models.DeviceDiagnosticsCallback],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DeviceDiagnosticsCallback](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

apiResponse, err := diagnosticsCallbacksApi.GetDiagnosticsSubscriptionCallbackInfo(ctx, accountName)
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
    "accountName": "TestQAAccount",
    "serviceName": "string",
    "endpoint": "https://yourwebsite.com",
    "httpHeaders": {},
    "createdOn": "2019-09-07T23:57:53.292Z"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |


# Register Diagnostics Callback URL

This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.

```go
RegisterDiagnosticsCallbackUrl(
    ctx context.Context,
    body models.CallbackRegistrationRequest) (
    models.ApiResponse[models.DeviceDiagnosticsCallback],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.CallbackRegistrationRequest`](../../doc/models/callback-registration-request.md) | Body, Required | Callback URL registration request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceDiagnosticsCallback](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```go
ctx := context.Background()

body := models.CallbackRegistrationRequest{
    AccountName:           "TestQAAccount",
    ServiceName:           "Diagnostics",
    Endpoint:              "https://yourwebsite.com",
    HttpHeaders:           models.ToPointer(interface{}("")),
}

apiResponse, err := diagnosticsCallbacksApi.RegisterDiagnosticsCallbackUrl(ctx, body)
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
  "accountName": "TestQAAccount",
  "serviceName": "string",
  "endpoint": "https://yourwebsite.com",
  "httpHeaders": {},
  "createdOn": "2019-09-07T23:57:53.292Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |


# Unregister Diagnostics Callback

This endpoint allows user to delete a registered callback URL and credential.

```go
UnregisterDiagnosticsCallback(
    ctx context.Context,
    accountName string,
    serviceName string) (
    models.ApiResponse[models.DeviceDiagnosticsCallback],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier. |
| `serviceName` | `string` | Query, Required | Service name for callback notification. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceDiagnosticsCallback](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

serviceName := "string"

apiResponse, err := diagnosticsCallbacksApi.UnregisterDiagnosticsCallback(ctx, accountName, serviceName)
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
  "accountName": "TestQAAccount",
  "serviceName": "string",
  "endpoint": "https://yourwebsite.com",
  "httpHeaders": {},
  "createdOn": "2019-09-07T23:57:53.292Z"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceDiagnosticsResultException`](../../doc/models/device-diagnostics-result-exception.md) |

