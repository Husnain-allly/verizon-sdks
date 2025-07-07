# Server Logging

```php
$serverLoggingApi = $client->getServerLoggingApi();
```

## Class Name

`ServerLoggingApi`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```php
function getDeviceCheckInHistory(string $account, string $deviceId): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`CheckInHistoryItem[]`](../../doc/models/check-in-history-item.md).

## Example Usage

```php
$account = '0000123456-00001';

$deviceId = '990013907835573';

$apiResponse = $serverLoggingApi->getDeviceCheckInHistory(
    $account,
    $deviceId
);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

