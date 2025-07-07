# Server Logging

```ruby
server_logging_api = client.server_logging
```

## Class Name

`ServerLoggingApi`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```ruby
def get_device_check_in_history(account,
                                device_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `device_id` | `String` | Template, Required | Device IMEI identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<CheckInHistoryItem>`](../../doc/models/check-in-history-item.md).

## Example Usage

```ruby
account = '0000123456-00001'

device_id = '990013907835573'

result = server_logging_api.get_device_check_in_history(
  account,
  device_id
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

