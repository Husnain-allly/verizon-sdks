
# Schedules Software Upgrade Request

*This model accepts additional fields of type Object.*

## Structure

`SchedulesSoftwareUpgradeRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CampaignName` | `String` | Optional | The campaign name. | String getCampaignName() | setCampaignName(String campaignName) |
| `SoftwareName` | `String` | Optional | Software name. | String getSoftwareName() | setSoftwareName(String softwareName) |
| `SoftwareFrom` | `String` | Optional | Old software name. | String getSoftwareFrom() | setSoftwareFrom(String softwareFrom) |
| `SoftwareTo` | `String` | Optional | New software name. | String getSoftwareTo() | setSoftwareTo(String softwareTo) |
| `DistributionType` | `String` | Optional | Valid values | String getDistributionType() | setDistributionType(String distributionType) |
| `StartDate` | `String` | Optional | Campaign start date. | String getStartDate() | setStartDate(String startDate) |
| `EndDate` | `String` | Optional | Campaign end date. | String getEndDate() | setEndDate(String endDate) |
| `DownloadAfterDate` | `String` | Optional | Specifies the starting date the client should download the package. If null, client downloads as soon as possible. | String getDownloadAfterDate() | setDownloadAfterDate(String downloadAfterDate) |
| `DownloadTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed download time windows. | List<DownloadTimeWindow> getDownloadTimeWindowList() | setDownloadTimeWindowList(List<DownloadTimeWindow> downloadTimeWindowList) |
| `InstallAfterDate` | `String` | Optional | The date after which you install the package. If null, install as soon as possible. | String getInstallAfterDate() | setInstallAfterDate(String installAfterDate) |
| `InstallTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed install time windows. | List<DownloadTimeWindow> getInstallTimeWindowList() | setInstallTimeWindowList(List<DownloadTimeWindow> installTimeWindowList) |
| `DeviceList` | `List<String>` | Optional | Device IMEI list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "startDate": "2021-02-08",
  "endDate": "2021-02-08",
  "downloadAfterDate": "2021-02-08",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

