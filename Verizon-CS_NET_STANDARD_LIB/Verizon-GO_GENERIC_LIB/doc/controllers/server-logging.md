# Server Logging

```go
serverLoggingApi := client.ServerLoggingApi()
```

## Class Name

`ServerLoggingApi`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```go
GetDeviceCheckInHistory(
    ctx context.Context,
    account string,
    deviceId string) (
    models.ApiResponse[[]models.CheckInHistoryItem],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.CheckInHistoryItem](../../doc/models/check-in-history-item.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

deviceId := "990013907835573"

apiResponse, err := serverLoggingApi.GetDeviceCheckInHistory(ctx, account, deviceId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

