
# V3 Device

Device information.

*This model accepts additional fields of type Object.*

## Structure

`V3Device`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Required | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `RequestStatus` | `String` | Optional | Success or failure. | String getRequestStatus() | setRequestStatus(String requestStatus) |
| `ResultReason` | `String` | Optional | - | String getResultReason() | setResultReason(String resultReason) |
| `Mdn` | `String` | Optional | MDN. | String getMdn() | setMdn(String mdn) |
| `Model` | `String` | Optional | Device model. | String getModel() | setModel(String model) |
| `Make` | `String` | Optional | Device make. | String getMake() | setMake(String make) |
| `Firmware` | `String` | Optional | Device firmware version. | String getFirmware() | setFirmware(String firmware) |
| `FotaEligible` | `Boolean` | Optional | Value=true if the device software can be upgraded over the air using the Software Management Services API. | Boolean getFotaEligible() | setFotaEligible(Boolean fotaEligible) |
| `Status` | `String` | Optional | Device status. | String getStatus() | setStatus(String status) |
| `LicenseAssigned` | `Boolean` | Optional | License assigned device. | Boolean getLicenseAssigned() | setLicenseAssigned(Boolean licenseAssigned) |
| `Protocol` | `String` | Optional | Firmware protocol. Valid values include: LWM2M, OMADM, HTTP or NONE. | String getProtocol() | setProtocol(String protocol) |
| `SoftwareList` | [`List<V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Optional | List of sofware.<br><br>**Constraints**: *Maximum Items*: `1000` | List<V3SoftwareInfo> getSoftwareList() | setSoftwareList(List<V3SoftwareInfo> softwareList) |
| `FileList` | [`List<V3SoftwareInfo>`](../../doc/models/v3-software-info.md) | Optional | List of files.<br><br>**Constraints**: *Maximum Items*: `1000` | List<V3SoftwareInfo> getFileList() | setFileList(List<V3SoftwareInfo> fileList) |
| `CreateTime` | `String` | Optional | The date and time of when the device is created. | String getCreateTime() | setCreateTime(String createTime) |
| `StatusTime` | `String` | Optional | The date and time of when the device firmware or software is updated. | String getStatusTime() | setStatusTime(String statusTime) |
| `UpdateTime` | `String` | Optional | The date and time of when the device is updated. | String getUpdateTime() | setUpdateTime(String updateTime) |
| `RefreshTime` | `String` | Optional | The date and time of when the device is refreshed. | String getRefreshTime() | setRefreshTime(String refreshTime) |
| `LastConnectionTime` | `LocalDateTime` | Optional | The date and time of when the device reachability is checked. | LocalDateTime getLastConnectionTime() | setLastConnectionTime(LocalDateTime lastConnectionTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "mdn": "10-digit MDN",
  "model": "GM01Q",
  "make": "SEQUANS COMMUNICATIONS",
  "firmware": "SR1.2.0.0-10657",
  "fotaEligible": true,
  "licenseAssigned": true,
  "status": "Active",
  "protocol": "LWM2M",
  "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "statusTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
  "lastConnectionTime": "2012-04-23T18:25:43.511Z",
  "requestStatus": "requestStatus6",
  "resultReason": "resultReason6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

