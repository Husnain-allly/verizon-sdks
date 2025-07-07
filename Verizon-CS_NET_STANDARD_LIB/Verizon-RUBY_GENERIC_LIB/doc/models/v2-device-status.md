
# V2 Device Status

Device with id in IMEI.

*This model accepts additional fields of type Object.*

## Structure

`V2DeviceStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `String` | Required | Device IMEI. |
| `status` | `String` | Required | Success or failure. |
| `result_reason` | `String` | Optional | Result reason. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "990000473475967",
  "status": "Failure",
  "resultReason": "Device does not exist.",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

