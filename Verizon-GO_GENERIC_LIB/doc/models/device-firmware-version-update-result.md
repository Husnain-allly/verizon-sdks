
# Device Firmware Version Update Result

Device firmware version update response.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceFirmwareVersionUpdateResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier. |
| `RequestId` | `string` | Required | Request identifier. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

