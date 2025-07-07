
# Campaign Software Upgrade

Software upgrade information.

*This model accepts additional fields of type Object.*

## Structure

`CampaignSoftwareUpgrade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CampaignName` | `String` | Optional | Campaign name. | String getCampaignName() | setCampaignName(String campaignName) |
| `SoftwareName` | `String` | Required | Software name to upgrade to. | String getSoftwareName() | setSoftwareName(String softwareName) |
| `SoftwareFrom` | `String` | Required | Old software name. | String getSoftwareFrom() | setSoftwareFrom(String softwareFrom) |
| `SoftwareTo` | `String` | Required | New software name. | String getSoftwareTo() | setSoftwareTo(String softwareTo) |
| `DistributionType` | `String` | Required | OMA or HTTP. | String getDistributionType() | setDistributionType(String distributionType) |
| `StartDate` | `LocalDate` | Required | Campaign start date. | LocalDate getStartDate() | setStartDate(LocalDate startDate) |
| `EndDate` | `LocalDate` | Required | Campaign end date. | LocalDate getEndDate() | setEndDate(LocalDate endDate) |
| `DownloadAfterDate` | `LocalDate` | Optional | Specifies starting date client should download package. If null, client will download as soon as possible. | LocalDate getDownloadAfterDate() | setDownloadAfterDate(LocalDate downloadAfterDate) |
| `DownloadTimeWindowList` | [`List<V2TimeWindow>`](../../doc/models/v2-time-window.md) | Optional | List of allowed download time windows. | List<V2TimeWindow> getDownloadTimeWindowList() | setDownloadTimeWindowList(List<V2TimeWindow> downloadTimeWindowList) |
| `InstallAfterDate` | `LocalDate` | Optional | Client will install package after date. If null, client will install as soon as possible. | LocalDate getInstallAfterDate() | setInstallAfterDate(LocalDate installAfterDate) |
| `InstallTimeWindowList` | [`List<V2TimeWindow>`](../../doc/models/v2-time-window.md) | Optional | List of allowed install time windows. | List<V2TimeWindow> getInstallTimeWindowList() | setInstallTimeWindowList(List<V2TimeWindow> installTimeWindowList) |
| `DeviceList` | `List<String>` | Required | Device IMEI list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": 20,
      "endTime": 21,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": 22,
      "endTime": 23,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "deviceList": [
    "990013907835573",
    "990013907884259"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

