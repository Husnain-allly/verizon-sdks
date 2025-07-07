
# Device Firmware Version Update Result

Device firmware version update response.

*This model accepts additional fields of type Any.*

## Structure

`DeviceFirmwareVersionUpdateResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | Account identifier. |
| `request_id` | `str` | Required | Request identifier. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "accountName4",
  "requestId": "requestId2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

