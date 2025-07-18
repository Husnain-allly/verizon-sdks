
# V2 Account Device

Account device information.

*This model accepts additional fields of type object.*

## Structure

`V2AccountDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device identifier. |
| `Mdn` | `string` | Required | MDN. |
| `Model` | `string` | Required | Device model. |
| `Make` | `string` | Required | Device make. |
| `FotaEligible` | `bool` | Required | Device FOTA capable. |
| `AppFotaEligible` | `bool` | Required | Device application FOTA capable. |
| `LicenseAssigned` | `bool` | Required | License assigned device. |
| `DistributionType` | `string` | Required | LWM2M, OMD-DM or HTTP. |
| `SoftwareList` | [`List<V2SoftwareInfo>`](../../doc/models/v2-software-info.md) | Required | List of sofware. |
| `CreateTime` | `string` | Optional | The date and time of when the device is created. |
| `UpgradeTime` | `string` | Optional | The date and time of when the device firmware or software is upgraded. |
| `UpdateTime` | `string` | Optional | The date and time of when the device is updated. |
| `RefreshTime` | `string` | Optional | The date and time of when the device is refreshed. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "mdn": "10-digit MDN",
  "model": "Model-A",
  "make": "Verizon",
  "fotaEligible": true,
  "appFotaEligible": true,
  "licenseAssigned": true,
  "distributionType": "HTTP",
  "softwareList": [
    {
      "name": "FOTA_Verizon_Model-A_02To03_HF",
      "version": "3",
      "upgradeTime": "2020-09-08T19:00:51.541Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

