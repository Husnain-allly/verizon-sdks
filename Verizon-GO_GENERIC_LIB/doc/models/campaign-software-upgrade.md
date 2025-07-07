
# Campaign Software Upgrade

Software upgrade information.

*This model accepts additional fields of type interface{}.*

## Structure

`CampaignSoftwareUpgrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CampaignName` | `*string` | Optional | Campaign name. |
| `SoftwareName` | `string` | Required | Software name to upgrade to. |
| `SoftwareFrom` | `string` | Required | Old software name. |
| `SoftwareTo` | `string` | Required | New software name. |
| `DistributionType` | `string` | Required | OMA or HTTP. |
| `StartDate` | `time.Time` | Required | Campaign start date. |
| `EndDate` | `time.Time` | Required | Campaign end date. |
| `DownloadAfterDate` | `*time.Time` | Optional | Specifies starting date client should download package. If null, client will download as soon as possible. |
| `DownloadTimeWindowList` | [`[]models.V2TimeWindow`](../../doc/models/v2-time-window.md) | Optional | List of allowed download time windows. |
| `InstallAfterDate` | `*time.Time` | Optional | Client will install package after date. If null, client will install as soon as possible. |
| `InstallTimeWindowList` | [`[]models.V2TimeWindow`](../../doc/models/v2-time-window.md) | Optional | List of allowed install time windows. |
| `DeviceList` | `[]string` | Required | Device IMEI list. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

