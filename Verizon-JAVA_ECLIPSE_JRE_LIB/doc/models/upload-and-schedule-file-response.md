
# Upload and Schedule File Response

*This model accepts additional fields of type Object.*

## Structure

`UploadAndScheduleFileResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | Updgrade identifier. | String getId() | setId(String id) |
| `AccountName` | `String` | Optional | Account identifer. | String getAccountName() | setAccountName(String accountName) |
| `CampaignName` | `String` | Optional | The campaign name. | String getCampaignName() | setCampaignName(String campaignName) |
| `SoftwareName` | `String` | Optional | Software name. | String getSoftwareName() | setSoftwareName(String softwareName) |
| `SoftwareFrom` | `String` | Optional | Old software name. | String getSoftwareFrom() | setSoftwareFrom(String softwareFrom) |
| `SoftwareTo` | `String` | Optional | New software name. | String getSoftwareTo() | setSoftwareTo(String softwareTo) |
| `FileName` | `String` | Optional | The name of the file you are upgrading to. | String getFileName() | setFileName(String fileName) |
| `FileVersion` | `String` | Optional | The version of the file you are upgrading to. | String getFileVersion() | setFileVersion(String fileVersion) |
| `DistributionType` | `String` | Optional | Valid values | String getDistributionType() | setDistributionType(String distributionType) |
| `Make` | `String` | Optional | Applicable make. | String getMake() | setMake(String make) |
| `Model` | `String` | Optional | Applicable model. | String getModel() | setModel(String model) |
| `StartDate` | `String` | Optional | Campaign start date. | String getStartDate() | setStartDate(String startDate) |
| `EndDate` | `String` | Optional | Campaign end date. | String getEndDate() | setEndDate(String endDate) |
| `DownloadAfterDate` | `String` | Optional | Specifies the starting date the client should download the package. If null, client downloads as soon as possible. | String getDownloadAfterDate() | setDownloadAfterDate(String downloadAfterDate) |
| `DownloadTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed download time windows. | List<DownloadTimeWindow> getDownloadTimeWindowList() | setDownloadTimeWindowList(List<DownloadTimeWindow> downloadTimeWindowList) |
| `InstallAfterDate` | `String` | Optional | The date after which you install the package. If null, install as soon as possible. | String getInstallAfterDate() | setInstallAfterDate(String installAfterDate) |
| `InstallTimeWindowList` | [`List<DownloadTimeWindow>`](../../doc/models/download-time-window.md) | Optional | List of allowed install time windows. | List<DownloadTimeWindow> getInstallTimeWindowList() | setInstallTimeWindowList(List<DownloadTimeWindow> installTimeWindowList) |
| `DeviceList` | `List<String>` | Optional | Device IMEI list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `Status` | `String` | Optional | Software update status. | String getStatus() | setStatus(String status) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0242078689-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "fileName": "configfile-Verizon_VZW1_hello-world.txt",
  "fileVersion": "1.0",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "startDate": "2021-02-08",
  "endDate": "2021-02-08",
  "downloadAfterDate": "2021-02-08",
  "status": "pending",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

