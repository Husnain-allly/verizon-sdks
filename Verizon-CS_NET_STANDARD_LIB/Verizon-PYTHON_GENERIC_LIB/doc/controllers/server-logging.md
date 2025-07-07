# Server Logging

```python
server_logging_api = client.server_logging
```

## Class Name

`ServerLoggingApi`


# Get Device Check in History

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

```python
def get_device_check_in_history(self,
                               account,
                               device_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `str` | Template, Required | Account identifier. |
| `device_id` | `str` | Template, Required | Device IMEI identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[CheckInHistoryItem]`](../../doc/models/check-in-history-item.md).

## Example Usage

```python
account = '0000123456-00001'

device_id = '990013907835573'

result = server_logging_api.get_device_check_in_history(
    account,
    device_id
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

