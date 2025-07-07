
# Upload and Schedule File Request

*This model accepts additional fields of type interface{}.*

## Structure

`UploadAndScheduleFileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CampaignName` | `*string` | Optional | The campaign name. |
| `FileName` | `*string` | Optional | The name of the file you are upgrading to. |
| `FileVersion` | `*string` | Optional | The version of the file you are upgrading to. |
| `DistributionType` | `*string` | Optional | Valid values |
| `StartDate` | `*string` | Optional | Campaign start date. |
| `EndDate` | `*string` | Optional | Campaign end date. |
| `DownloadAfterDate` | `*string` | Optional | Specifies the starting date the client should download the package. If null, client downloads as soon as possible. |
| `DownloadTimeWindowList` | [`[]models.DownloadTimeWindow`](../../doc/models/download-time-window.md) | Optional | List of allowed download time windows. |
| `InstallAfterDate` | `*string` | Optional | The date after which you install the package. If null, install as soon as possible. |
| `InstallTimeWindowList` | [`[]models.DownloadTimeWindow`](../../doc/models/download-time-window.md) | Optional | List of allowed install time windows. |
| `DeviceList` | `[]string` | Optional | Device IMEI list. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

