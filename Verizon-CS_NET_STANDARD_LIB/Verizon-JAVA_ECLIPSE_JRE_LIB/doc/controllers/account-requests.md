# Account Requests

```java
AccountRequestsApi accountRequestsApi = client.getAccountRequestsApi();
```

## Class Name

`AccountRequestsApi`


# Get Current Asynchronous Request Status

Returns the current status of an asynchronous request that was made for a single device.

```java
CompletableFuture<ApiResponse<AsynchronousRequestResult>> getCurrentAsynchronousRequestStatusAsync(
    final String aname,
    final String requestId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |
| `requestId` | `String` | Template, Required | UUID from synchronous response. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`AsynchronousRequestResult`](../../doc/models/asynchronous-request-result.md).

## Example Usage

```java
String aname = "0252012345-00001";
String requestId = "86c83330-4bf5-4235-9c4e-a83f93aeae4c";

accountRequestsApi.getCurrentAsynchronousRequestStatusAsync(aname, requestId).thenAccept(result -> {
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
  "requestId": "86c83330-4bf5-4235-9c4e-a83f93aeae4c",
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

