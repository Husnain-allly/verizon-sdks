
# Device Firmware Version

Device and firmware information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceFirmwareVersion`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `String` | Optional | - |
| `reason` | `String` | Optional | - |
| `device_id` | `String` | Required | Device IMEI. |
| `firmware_version` | `String` | Required | Device Firmware Version. |
| `firmware_version_update_time` | `DateTime` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "status": "FirmwareVersionUpdateSuccess",
  "firmwareVersion": "SR1.2.0.0-10657",
  "reason": "reason6",
  "firmwareVersionUpdateTime": "2016-03-13T12:52:32.123Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

