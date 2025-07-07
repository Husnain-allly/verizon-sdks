# Software Management Callbacks V3

```go
softwareManagementCallbacksV3Api := client.SoftwareManagementCallbacksV3Api()
```

## Class Name

`SoftwareManagementCallbacksV3Api`

## Methods

* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v3.md#list-registered-callbacks)
* [Update Callback](../../doc/controllers/software-management-callbacks-v3.md#update-callback)
* [Register Callback](../../doc/controllers/software-management-callbacks-v3.md#register-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v3.md#deregister-callback)


# List Registered Callbacks

This endpoint allows user to get the registered callback information.

```go
ListRegisteredCallbacks(
    ctx context.Context,
    acc string) (
    models.ApiResponse[models.FotaV3CallbackSummary],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV3CallbackSummary](../../doc/models/fota-v3-callback-summary.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

apiResponse, err := softwareManagementCallbacksV3Api.ListRegisteredCallbacks(ctx, acc)
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Update Callback

This endpoint allows the user to update the HTTPS callback address.

```go
UpdateCallback(
    ctx context.Context,
    acc string,
    body models.FotaV3CallbackRegistrationRequest) (
    models.ApiResponse[models.FotaV3CallbackRegistrationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.FotaV3CallbackRegistrationRequest`](../../doc/models/fota-v3-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV3CallbackRegistrationResult](../../doc/models/fota-v3-callback-registration-result.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

body := models.FotaV3CallbackRegistrationRequest{
    Url:                   models.ToPointer("https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx"),
}

apiResponse, err := softwareManagementCallbacksV3Api.UpdateCallback(ctx, acc, body)
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Register Callback

This endpoint allows the user to create the HTTPS callback address.

```go
RegisterCallback(
    ctx context.Context,
    acc string,
    body models.FotaV3CallbackRegistrationRequest) (
    models.ApiResponse[models.FotaV3CallbackRegistrationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.FotaV3CallbackRegistrationRequest`](../../doc/models/fota-v3-callback-registration-request.md) | Body, Required | Callback URL registration. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV3CallbackRegistrationResult](../../doc/models/fota-v3-callback-registration-result.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

body := models.FotaV3CallbackRegistrationRequest{
    Url:                   models.ToPointer("https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx"),
}

apiResponse, err := softwareManagementCallbacksV3Api.RegisterCallback(ctx, acc, body)
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Deregister Callback

This endpoint allows user to delete a previously registered callback URL.

```go
DeregisterCallback(
    ctx context.Context,
    acc string) (
    models.ApiResponse[models.FotaV3SuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV3SuccessResult](../../doc/models/fota-v3-success-result.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

apiResponse, err := softwareManagementCallbacksV3Api.DeregisterCallback(ctx, acc)
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

