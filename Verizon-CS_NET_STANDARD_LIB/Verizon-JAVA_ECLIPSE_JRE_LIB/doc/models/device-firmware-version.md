
# Device Firmware Version

Device and firmware information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceFirmwareVersion`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Status` | `String` | Optional | - | String getStatus() | setStatus(String status) |
| `Reason` | `String` | Optional | - | String getReason() | setReason(String reason) |
| `DeviceId` | `String` | Required | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `FirmwareVersion` | `String` | Required | Device Firmware Version. | String getFirmwareVersion() | setFirmwareVersion(String firmwareVersion) |
| `FirmwareVersionUpdateTime` | `LocalDateTime` | Optional | - | LocalDateTime getFirmwareVersionUpdateTime() | setFirmwareVersionUpdateTime(LocalDateTime firmwareVersionUpdateTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

