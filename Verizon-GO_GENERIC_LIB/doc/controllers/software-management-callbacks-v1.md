# Software Management Callbacks V1

```go
softwareManagementCallbacksV1Api := client.SoftwareManagementCallbacksV1Api()
```

## Class Name

`SoftwareManagementCallbacksV1Api`

## Methods

* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v1.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/software-management-callbacks-v1.md#register-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v1.md#deregister-callback)


# List Registered Callbacks

Returns the name and endpoint URL of the callback listening services registered for a given account.

```go
ListRegisteredCallbacks(
    ctx context.Context,
    account string) (
    models.ApiResponse[[]models.RegisteredCallbacks],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.RegisteredCallbacks](../../doc/models/registered-callbacks.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

apiResponse, err := softwareManagementCallbacksV1Api.ListRegisteredCallbacks(ctx, account)
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
    "aname": "0252012345-00001",
    "name": "Fota",
    "url": "http://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Register Callback

Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.

```go
RegisterCallback(
    ctx context.Context,
    account string,
    body models.FotaV1CallbackRegistrationRequest) (
    models.ApiResponse[models.FotaV1CallbackRegistrationResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`models.FotaV1CallbackRegistrationRequest`](../../doc/models/fota-v1-callback-registration-request.md) | Body, Required | Callback details. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV1CallbackRegistrationResult](../../doc/models/fota-v1-callback-registration-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

body := models.FotaV1CallbackRegistrationRequest{
    Name:                  "Fota",
    Url:                   "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
}

apiResponse, err := softwareManagementCallbacksV1Api.RegisterCallback(ctx, account, body)
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
  "accountName": "0204563412-00001",
  "serviceName": "Fota"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Deregister Callback

Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.

```go
DeregisterCallback(
    ctx context.Context,
    account string,
    service models.CallbackService) (
    models.ApiResponse[models.FotaV1SuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `service` | [`models.CallbackService`](../../doc/models/callback-service.md) | Template, Required | Callback type. Must be 'Fota' for Software Management Services API. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV1SuccessResult](../../doc/models/fota-v1-success-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

service := models.CallbackService_Fota

apiResponse, err := softwareManagementCallbacksV1Api.DeregisterCallback(ctx, account, service)
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
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |

