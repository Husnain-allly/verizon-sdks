
# Device Firmware Version Update Result

Device firmware version update response.

*This model accepts additional fields of type Object.*

## Structure

`DeviceFirmwareVersionUpdateResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | Account identifier. |
| `request_id` | `String` | Required | Request identifier. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

