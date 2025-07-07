
# Check in History Item

Check-in history for a device.

*This model accepts additional fields of type unknown.*

## Structure

`CheckInHistoryItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `string` | Required | Device IMEI. |
| `clientType` | `string` | Required | Type of client. |
| `result` | `string` | Required | - |
| `failureType` | `string` | Required | - |
| `timeCompleted` | `string` | Required | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "clientType": "clientType6",
  "result": "result8",
  "failureType": "failureType8",
  "timeCompleted": "10/22/2020 19:35:07",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

