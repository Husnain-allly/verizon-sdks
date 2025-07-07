
# V2 Device Status

Device with id in IMEI.

*This model accepts additional fields of type Any.*

## Structure

`V2DeviceStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `str` | Required | Device IMEI. |
| `status` | `str` | Required | Success or failure. |
| `result_reason` | `str` | Optional | Result reason. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

