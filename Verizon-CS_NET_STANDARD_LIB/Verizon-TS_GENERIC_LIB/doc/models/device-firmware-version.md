
# Device Firmware Version

Device and firmware information.

*This model accepts additional fields of type unknown.*

## Structure

`DeviceFirmwareVersion`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `string \| undefined` | Optional | - |
| `reason` | `string \| undefined` | Optional | - |
| `deviceId` | `string` | Required | Device IMEI. |
| `firmwareVersion` | `string` | Required | Device Firmware Version. |
| `firmwareVersionUpdateTime` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

