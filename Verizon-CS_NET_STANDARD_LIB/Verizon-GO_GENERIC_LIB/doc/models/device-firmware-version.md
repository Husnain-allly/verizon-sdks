
# Device Firmware Version

Device and firmware information.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceFirmwareVersion`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `*string` | Optional | - |
| `Reason` | `*string` | Optional | - |
| `DeviceId` | `string` | Required | Device IMEI. |
| `FirmwareVersion` | `string` | Required | Device Firmware Version. |
| `FirmwareVersionUpdateTime` | `*time.Time` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

