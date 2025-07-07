
# V2 Campaign Meta Info

Campaign and campaign details.

*This model accepts additional fields of type Object.*

## Structure

`V2CampaignMetaInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `Id` | `String` | Required | Campaign identifier. | String getId() | setId(String id) |
| `CampaignName` | `String` | Optional | Campaign name. | String getCampaignName() | setCampaignName(String campaignName) |
| `SoftwareName` | `String` | Required | Software name. | String getSoftwareName() | setSoftwareName(String softwareName) |
| `DistributionType` | `String` | Required | LWM2M, OMD-DM or HTTP. | String getDistributionType() | setDistributionType(String distributionType) |
| `SoftwareFrom` | `String` | Required | Old software name. | String getSoftwareFrom() | setSoftwareFrom(String softwareFrom) |
| `SoftwareTo` | `String` | Required | New software name. | String getSoftwareTo() | setSoftwareTo(String softwareTo) |
| `Make` | `String` | Required | Applicable make. | String getMake() | setMake(String make) |
| `Model` | `String` | Required | Applicable model. | String getModel() | setModel(String model) |
| `StartDate` | `LocalDate` | Required | Campaign start date. | LocalDate getStartDate() | setStartDate(LocalDate startDate) |
| `EndDate` | `LocalDate` | Required | Campaign end date. | LocalDate getEndDate() | setEndDate(LocalDate endDate) |
| `DownloadAfterDate` | `LocalDate` | Optional | Specifies starting date client should download package. If null, client will download as soon as possible. | LocalDate getDownloadAfterDate() | setDownloadAfterDate(LocalDate downloadAfterDate) |
| `DownloadTimeWindowList` | [`List<V2TimeWindow>`](../../doc/models/v2-time-window.md) | Optional | List of allowed download time windows. | List<V2TimeWindow> getDownloadTimeWindowList() | setDownloadTimeWindowList(List<V2TimeWindow> downloadTimeWindowList) |
| `InstallAfterDate` | `LocalDate` | Optional | Client will install package after date. If null, client will install as soon as possible. | LocalDate getInstallAfterDate() | setInstallAfterDate(LocalDate installAfterDate) |
| `InstallTimeWindowList` | [`List<V2TimeWindow>`](../../doc/models/v2-time-window.md) | Optional | List of allowed install time windows. | List<V2TimeWindow> getInstallTimeWindowList() | setInstallTimeWindowList(List<V2TimeWindow> installTimeWindowList) |
| `Status` | `String` | Required | Software upgrade status. | String getStatus() | setStatus(String status) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0402196254-00001",
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "make": "Verizon",
  "model": "Model-A",
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
  "status": "CampaignEnded",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

