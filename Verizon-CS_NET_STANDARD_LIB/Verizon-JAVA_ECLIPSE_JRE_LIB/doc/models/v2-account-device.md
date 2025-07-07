
# V2 Account Device

Account device information.

*This model accepts additional fields of type Object.*

## Structure

`V2AccountDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Required | Device identifier. | String getDeviceId() | setDeviceId(String deviceId) |
| `Mdn` | `String` | Required | MDN. | String getMdn() | setMdn(String mdn) |
| `Model` | `String` | Required | Device model. | String getModel() | setModel(String model) |
| `Make` | `String` | Required | Device make. | String getMake() | setMake(String make) |
| `FotaEligible` | `boolean` | Required | Device FOTA capable. | boolean getFotaEligible() | setFotaEligible(boolean fotaEligible) |
| `AppFotaEligible` | `boolean` | Required | Device application FOTA capable. | boolean getAppFotaEligible() | setAppFotaEligible(boolean appFotaEligible) |
| `LicenseAssigned` | `boolean` | Required | License assigned device. | boolean getLicenseAssigned() | setLicenseAssigned(boolean licenseAssigned) |
| `DistributionType` | `String` | Required | LWM2M, OMD-DM or HTTP. | String getDistributionType() | setDistributionType(String distributionType) |
| `SoftwareList` | [`List<V2SoftwareInfo>`](../../doc/models/v2-software-info.md) | Required | List of sofware. | List<V2SoftwareInfo> getSoftwareList() | setSoftwareList(List<V2SoftwareInfo> softwareList) |
| `CreateTime` | `String` | Optional | The date and time of when the device is created. | String getCreateTime() | setCreateTime(String createTime) |
| `UpgradeTime` | `String` | Optional | The date and time of when the device firmware or software is upgraded. | String getUpgradeTime() | setUpgradeTime(String upgradeTime) |
| `UpdateTime` | `String` | Optional | The date and time of when the device is updated. | String getUpdateTime() | setUpdateTime(String updateTime) |
| `RefreshTime` | `String` | Optional | The date and time of when the device is refreshed. | String getRefreshTime() | setRefreshTime(String refreshTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

