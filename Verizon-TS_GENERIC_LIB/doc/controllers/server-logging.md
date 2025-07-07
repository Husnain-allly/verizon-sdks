# Server Logging

```ts
const serverLoggingApi = new ServerLoggingApi(client);
```

## Class Name

`ServerLoggingApi`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```ts
async getDeviceCheckInHistory(
  account: string,
  deviceId: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<CheckInHistoryItem[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [CheckInHistoryItem[]](../../doc/models/check-in-history-item.md).

## Example Usage

```ts
const account = '0000123456-00001';

const deviceId = '990013907835573';

try {
  const { result, ...httpResponse } = await serverLoggingApi.getDeviceCheckInHistory(
  account,
  deviceId
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultError`](../../doc/models/fota-v2-result-error.md) |

