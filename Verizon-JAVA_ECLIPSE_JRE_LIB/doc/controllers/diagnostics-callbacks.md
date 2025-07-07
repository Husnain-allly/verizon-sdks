# Diagnostics Callbacks

```java
DiagnosticsCallbacksApi diagnosticsCallbacksApi = client.getDiagnosticsCallbacksApi();
```

## Class Name

`DiagnosticsCallbacksApi`

## Methods

* [Get Diagnostics Subscription Callback Info](../../doc/controllers/diagnostics-callbacks.md#get-diagnostics-subscription-callback-info)
* [Register Diagnostics Callback URL](../../doc/controllers/diagnostics-callbacks.md#register-diagnostics-callback-url)
* [Unregister Diagnostics Callback](../../doc/controllers/diagnostics-callbacks.md#unregister-diagnostics-callback)


# Get Diagnostics Subscription Callback Info

This endpoint allows user to get the registered callback information of an existing diagnostics subscription.

```java
CompletableFuture<ApiResponse<List<DeviceDiagnosticsCallback>>> getDiagnosticsSubscriptionCallbackInfoAsync(
    final String accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Query, Required | Account identifier. |

## Server

`Server.DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DeviceDiagnosticsCallback>`](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```java
String accountName = "0000123456-00001";

diagnosticsCallbacksApi.getDiagnosticsSubscriptionCallbackInfoAsync(accountName).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<DeviceDiagnosticsCallback>> registerDiagnosticsCallbackUrlAsync(
    final CallbackRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CallbackRegistrationRequest`](../../doc/models/callback-registration-request.md) | Body, Required | Callback URL registration request. |

## Server

`Server.DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceDiagnosticsCallback`](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```java
CallbackRegistrationRequest body = new CallbackRegistrationRequest.Builder(
    "TestQAAccount",
    "Diagnostics",
    "https://yourwebsite.com"
)
.httpHeaders(ApiHelper.deserialize("{}"))
.build();

diagnosticsCallbacksApi.registerDiagnosticsCallbackUrlAsync(body).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<DeviceDiagnosticsCallback>> unregisterDiagnosticsCallbackAsync(
    final String accountName,
    final String serviceName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Query, Required | Account identifier. |
| `serviceName` | `String` | Query, Required | Service name for callback notification. |

## Server

`Server.DEVICE_DIAGNOSTICS`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceDiagnosticsCallback`](../../doc/models/device-diagnostics-callback.md).

## Example Usage

```java
String accountName = "0000123456-00001";
String serviceName = "string";

diagnosticsCallbacksApi.unregisterDiagnosticsCallbackAsync(accountName, serviceName).thenAccept(result -> {
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

