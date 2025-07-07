# Software Management Callbacks V1

```java
SoftwareManagementCallbacksV1Api softwareManagementCallbacksV1Api = client.getSoftwareManagementCallbacksV1Api();
```

## Class Name

`SoftwareManagementCallbacksV1Api`

## Methods

* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v1.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/software-management-callbacks-v1.md#register-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v1.md#deregister-callback)


# List Registered Callbacks

Returns the name and endpoint URL of the callback listening services registered for a given account.

```java
CompletableFuture<ApiResponse<List<RegisteredCallbacks>>> listRegisteredCallbacksAsync(
    final String account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<RegisteredCallbacks>`](../../doc/models/registered-callbacks.md).

## Example Usage

```java
String account = "0242078689-00001";

softwareManagementCallbacksV1Api.listRegisteredCallbacksAsync(account).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<FotaV1CallbackRegistrationResult>> registerCallbackAsync(
    final String account,
    final FotaV1CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`FotaV1CallbackRegistrationRequest`](../../doc/models/fota-v1-callback-registration-request.md) | Body, Required | Callback details. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV1CallbackRegistrationResult`](../../doc/models/fota-v1-callback-registration-result.md).

## Example Usage

```java
String account = "0242078689-00001";
FotaV1CallbackRegistrationRequest body = new FotaV1CallbackRegistrationRequest.Builder(
    "Fota",
    "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
)
.build();

softwareManagementCallbacksV1Api.registerCallbackAsync(account, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<FotaV1SuccessResult>> deregisterCallbackAsync(
    final String account,
    final CallbackService service)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `service` | [`CallbackService`](../../doc/models/callback-service.md) | Template, Required | Callback type. Must be 'Fota' for Software Management Services API. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV1SuccessResult`](../../doc/models/fota-v1-success-result.md).

## Example Usage

```java
String account = "0242078689-00001";
CallbackService service = CallbackService.FOTA;

softwareManagementCallbacksV1Api.deregisterCallbackAsync(account, service).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

