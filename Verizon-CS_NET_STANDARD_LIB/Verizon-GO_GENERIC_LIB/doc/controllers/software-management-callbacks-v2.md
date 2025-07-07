# Software Management Callbacks V2

```go
softwareManagementCallbacksV2Api := client.SoftwareManagementCallbacksV2Api()
```

## Class Name

`SoftwareManagementCallbacksV2Api`

## Methods

* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v2.md#list-registered-callbacks)
* [Update Callback](../../doc/controllers/software-management-callbacks-v2.md#update-callback)
* [Register Callback](../../doc/controllers/software-management-callbacks-v2.md#register-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v2.md#deregister-callback)


# List Registered Callbacks

This endpoint allows user to get the registered callback information.

```go
ListRegisteredCallbacks(
    ctx context.Context,
    account string) (
    models.ApiResponse[models.CallbackSummary],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CallbackSummary](../../doc/models/callback-summary.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

apiResponse, err := softwareManagementCallbacksV2Api.ListRegisteredCallbacks(ctx, account)
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
  "url": "http://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Callback

This endpoint allows user to update the HTTPS callback address.

```go
UpdateCallback(
    ctx context.Context,
    account string,
    body models.FotaV2CallbackRegistrationRequest) (
    models.ApiResponse[models.FotaV2CallbackRegistrationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`models.FotaV2CallbackRegistrationRequest`](../../doc/models/fota-v2-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV2CallbackRegistrationResult](../../doc/models/fota-v2-callback-registration-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

body := models.FotaV2CallbackRegistrationRequest{
    Url:                   models.ToPointer("https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx"),
}

apiResponse, err := softwareManagementCallbacksV2Api.UpdateCallback(ctx, account, body)
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
  "url": "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Register Callback

This endpoint allows user to create the HTTPS callback address.

```go
RegisterCallback(
    ctx context.Context,
    account string,
    body models.FotaV2CallbackRegistrationRequest) (
    models.ApiResponse[models.FotaV2CallbackRegistrationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`models.FotaV2CallbackRegistrationRequest`](../../doc/models/fota-v2-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV2CallbackRegistrationResult](../../doc/models/fota-v2-callback-registration-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

body := models.FotaV2CallbackRegistrationRequest{
    Url:                   models.ToPointer("https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"),
}

apiResponse, err := softwareManagementCallbacksV2Api.RegisterCallback(ctx, account, body)
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
  "url": "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Deregister Callback

This endpoint allows user to delete a previously registered callback URL.

```go
DeregisterCallback(
    ctx context.Context,
    account string) (
    models.ApiResponse[models.FotaV2SuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV2SuccessResult](../../doc/models/fota-v2-success-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

apiResponse, err := softwareManagementCallbacksV2Api.DeregisterCallback(ctx, account)
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
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

