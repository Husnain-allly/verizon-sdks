
# Check in History Item

Check-in history for a device.

*This model accepts additional fields of type Object.*

## Structure

`CheckInHistoryItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `String` | Required | Device IMEI. |
| `client_type` | `String` | Required | Type of client. |
| `result` | `String` | Required | - |
| `failure_type` | `String` | Required | - |
| `time_completed` | `DateTime` | Required | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

