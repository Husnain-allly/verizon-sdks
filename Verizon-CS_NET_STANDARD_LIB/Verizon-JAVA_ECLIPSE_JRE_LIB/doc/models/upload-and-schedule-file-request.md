
# Upload and Schedule File Request

*This model accepts additional fields of type Object.*

## Structure

`UploadAndScheduleFileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CampaignName` | `String` | Optional | The campaign name. | String getCampaignName() | setCampaignName(String campaignName) |
| `FileName` | `String` | Optional | The name of the file you are upgrading to. | String getFileName() | setFileName(String fileName) |
| `FileVersion` | `String` | Optional | The version of the file you are upgrading to. | String getFileVersion() | setFileVersion(String fileVersion) |
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
  "fileName": "configfile-Verizon_VZW1_hello-world.txt",
  "fileVersion": "1.0",
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

