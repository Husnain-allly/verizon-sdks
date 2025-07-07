
# Device List Query Item

The list of devices in the account.

*This model accepts additional fields of type Object.*

## Structure

`DeviceListQueryItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Optional | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `Mdn` | `String` | Optional | The MDN (phone number) of the device. | String getMdn() | setMdn(String mdn) |
| `Model` | `String` | Optional | The device model name. | String getModel() | setModel(String model) |
| `Make` | `String` | Optional | The device make. | String getMake() | setMake(String make) |
| `Firmware` | `String` | Optional | The name of the firmware image currently installed on the device. | String getFirmware() | setFirmware(String firmware) |
| `FotaEligible` | `Boolean` | Optional | True if the device firmware can be upgraded over the air using the Software Management Services API. | Boolean getFotaEligible() | setFotaEligible(Boolean fotaEligible) |
| `LicenseAssigned` | `Boolean` | Optional | True if an MRC license has been assigned to this device. | Boolean getLicenseAssigned() | setLicenseAssigned(Boolean licenseAssigned) |
| `UpgradeTime` | `String` | Optional | The date and time that the device firmware was last upgraded. If a device has never been upgraded, the upgradeTime will be 01/01/1900 0:0:0. | String getUpgradeTime() | setUpgradeTime(String upgradeTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "900000000000001",
  "mdn": "0000040881",
  "model": "Model-A",
  "make": "Verizon",
  "firmware": "VerizonFirmwareVersion-01",
  "fotaEligible": true,
  "licenseAssigned": true,
  "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

