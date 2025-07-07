# Server Logging

```csharp
ServerLoggingApi serverLoggingApi = client.ServerLoggingApi;
```

## Class Name

`ServerLoggingApi`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```csharp
GetDeviceCheckInHistoryAsync(
    string account,
    string deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.CheckInHistoryItem>](../../doc/models/check-in-history-item.md).

## Example Usage

```csharp
string account = "0000123456-00001";
string deviceId = "990013907835573";
try
{
    ApiResponse<List<CheckInHistoryItem>> result = await serverLoggingApi.GetDeviceCheckInHistoryAsync(
        account,
        deviceId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

