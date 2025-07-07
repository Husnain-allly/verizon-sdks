
# V3 Account Device

Device information.

*This model accepts additional fields of type Object.*

## Structure

`V3AccountDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Required | Device identifier. | String getDeviceId() | setDeviceId(String deviceId) |
| `Mdn` | `String` | Required | MDN. | String getMdn() | setMdn(String mdn) |
| `Model` | `String` | Required | Device model. | String getModel() | setModel(String model) |
| `Make` | `String` | Required | Device make. | String getMake() | setMake(String make) |
| `Firmware` | `String` | Required | Device firmware version. | String getFirmware() | setFirmware(String firmware) |
| `FotaEligible` | `boolean` | Required | Value=true if the device software can be upgraded over the air using the Software Management Services API. | boolean getFotaEligible() | setFotaEligible(boolean fotaEligible) |
| `Status` | `String` | Required | Device status. | String getStatus() | setStatus(String status) |
| `LicenseAssigned` | `boolean` | Required | License assigned device. | boolean getLicenseAssigned() | setLicenseAssigned(boolean licenseAssigned) |
| `Protocol` | `String` | Required | Firmware protocol. Valid values include: LWM2M, OMADM, HTTP or NONE. | String getProtocol() | setProtocol(String protocol) |
| `SoftwareList` | [`List<V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Required | List of sofware. | List<V3SoftwareInfo> getSoftwareList() | setSoftwareList(List<V3SoftwareInfo> softwareList) |
| `FileList` | [`List<V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Optional | List of files. | List<V3SoftwareInfo> getFileList() | setFileList(List<V3SoftwareInfo> fileList) |
| `CreateTime` | `String` | Optional | The date and time of when the device is created. | String getCreateTime() | setCreateTime(String createTime) |
| `UpgradeTime` | `String` | Optional | The date and time of when the device firmware or software is updated. | String getUpgradeTime() | setUpgradeTime(String upgradeTime) |
| `UpdateTime` | `String` | Optional | The date and time of when the device is updated. | String getUpdateTime() | setUpdateTime(String updateTime) |
| `RefreshTime` | `String` | Optional | The date and time of when the device is refreshed. | String getRefreshTime() | setRefreshTime(String refreshTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "15-digit device ID",
  "mdn": "10-digit MDN",
  "model": "BG96",
  "make": "QUECTEL",
  "firmware": "BG96MAR04A04M1G",
  "fotaEligible": false,
  "status": "Active",
  "licenseAssigned": true,
  "protocol": "LWM2M",
  "softwareList": [
    {
      "name": "VZ_MDM_IOT",
      "version": "0.14",
      "upgradeTime": "2012-04-23T18:25:43.511Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "fileList": [
    {
      "name": "VZ_MDM_IOT",
      "version": "0.14",
      "upgradeTime": "2012-04-23T18:25:43.511Z",
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

