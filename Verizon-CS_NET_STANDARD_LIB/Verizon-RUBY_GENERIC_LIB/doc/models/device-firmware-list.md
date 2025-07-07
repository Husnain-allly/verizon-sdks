
# Device Firmware List

Device Firmware Information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceFirmwareList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | Account name. |
| `device_firmwar_version_list` | [`Array<DeviceFirmwareVersion>`](../../doc/models/device-firmware-version.md) | Optional | List of device & firmware. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "deviceFirmwarVersionList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "FirmwareVersionUpdateSuccess",
      "firmwareVersion": "SR1.2.0.0-10657",
      "reason": "reason8",
      "firmwareVersionUpdateTime": "2016-03-13T12:52:32.123Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

