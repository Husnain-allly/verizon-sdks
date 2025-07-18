
# Device Firmware Version

Device and firmware information.

*This model accepts additional fields of type array.*

## Structure

`DeviceFirmwareVersion`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `status` | `?string` | Optional | - | getStatus(): ?string | setStatus(?string status): void |
| `reason` | `?string` | Optional | - | getReason(): ?string | setReason(?string reason): void |
| `deviceId` | `string` | Required | Device IMEI. | getDeviceId(): string | setDeviceId(string deviceId): void |
| `firmwareVersion` | `string` | Required | Device Firmware Version. | getFirmwareVersion(): string | setFirmwareVersion(string firmwareVersion): void |
| `firmwareVersionUpdateTime` | `?DateTime` | Optional | - | getFirmwareVersionUpdateTime(): ?\DateTime | setFirmwareVersionUpdateTime(?\DateTime firmwareVersionUpdateTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

