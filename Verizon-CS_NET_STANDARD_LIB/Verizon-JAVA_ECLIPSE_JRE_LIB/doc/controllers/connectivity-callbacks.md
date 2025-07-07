# Connectivity Callbacks

```java
ConnectivityCallbacksApi connectivityCallbacksApi = client.getConnectivityCallbacksApi();
```

## Class Name

`ConnectivityCallbacksApi`

## Methods

* [List Registered Callbacks](../../doc/controllers/connectivity-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/connectivity-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/connectivity-callbacks.md#deregister-callback)


# List Registered Callbacks

Returns the name and endpoint URL of the callback listening services registered for a given account.

```java
CompletableFuture<ApiResponse<List<ConnectivityManagementCallback>>> listRegisteredCallbacksAsync(
    final String aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<ConnectivityManagementCallback>`](../../doc/models/connectivity-management-callback.md).

## Example Usage

```java
String aname = "0252012345-00001";

connectivityCallbacksApi.listRegisteredCallbacksAsync(aname).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<CallbackActionResult>> registerCallbackAsync(
    final String aname,
    final RegisterCallbackRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |
| `body` | [`RegisterCallbackRequest`](../../doc/models/register-callback-request.md) | Body, Required | Request to register a callback. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`CallbackActionResult`](../../doc/models/callback-action-result.md).

## Example Usage

```java
String aname = "TestAccount-2";
RegisterCallbackRequest body = new RegisterCallbackRequest.Builder(
    "CarrierService",
    "https://mock.thingspace.verizon.com/webhook"
)
.build();

connectivityCallbacksApi.registerCallbackAsync(aname, body).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<CallbackActionResult>> deregisterCallbackAsync(
    final String aname,
    final String sname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |
| `sname` | `String` | Template, Required | Service name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`CallbackActionResult`](../../doc/models/callback-action-result.md).

## Example Usage

```java
String aname = "1223334444-00001";
String sname = "CarrierService";

connectivityCallbacksApi.deregisterCallbackAsync(aname, sname).thenAccept(result -> {
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
  "accountName": "1223334444-00001",
  "serviceName": "CarrierService"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

