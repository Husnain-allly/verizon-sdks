# Server Logging

```java
ServerLoggingApi serverLoggingApi = client.getServerLoggingApi();
```

## Class Name

`ServerLoggingApi`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```java
CompletableFuture<ApiResponse<List<CheckInHistoryItem>>> getDeviceCheckInHistoryAsync(
    final String account,
    final String deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `deviceId` | `String` | Template, Required | Device IMEI identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<CheckInHistoryItem>`](../../doc/models/check-in-history-item.md).

## Example Usage

```java
String account = "0000123456-00001";
String deviceId = "990013907835573";

serverLoggingApi.getDeviceCheckInHistoryAsync(account, deviceId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

