
# Campaign Software Upgrade

Software upgrade information.

*This model accepts additional fields of type array.*

## Structure

`CampaignSoftwareUpgrade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `campaignName` | `?string` | Optional | Campaign name. | getCampaignName(): ?string | setCampaignName(?string campaignName): void |
| `softwareName` | `string` | Required | Software name to upgrade to. | getSoftwareName(): string | setSoftwareName(string softwareName): void |
| `softwareFrom` | `string` | Required | Old software name. | getSoftwareFrom(): string | setSoftwareFrom(string softwareFrom): void |
| `softwareTo` | `string` | Required | New software name. | getSoftwareTo(): string | setSoftwareTo(string softwareTo): void |
| `distributionType` | `string` | Required | OMA or HTTP. | getDistributionType(): string | setDistributionType(string distributionType): void |
| `startDate` | `DateTime` | Required | Campaign start date. | getStartDate(): \DateTime | setStartDate(\DateTime startDate): void |
| `endDate` | `DateTime` | Required | Campaign end date. | getEndDate(): \DateTime | setEndDate(\DateTime endDate): void |
| `downloadAfterDate` | `?DateTime` | Optional | Specifies starting date client should download package. If null, client will download as soon as possible. | getDownloadAfterDate(): ?\DateTime | setDownloadAfterDate(?\DateTime downloadAfterDate): void |
| `downloadTimeWindowList` | [`?(V2TimeWindow[])`](../../doc/models/v2-time-window.md) | Optional | List of allowed download time windows. | getDownloadTimeWindowList(): ?array | setDownloadTimeWindowList(?array downloadTimeWindowList): void |
| `installAfterDate` | `?DateTime` | Optional | Client will install package after date. If null, client will install as soon as possible. | getInstallAfterDate(): ?\DateTime | setInstallAfterDate(?\DateTime installAfterDate): void |
| `installTimeWindowList` | [`?(V2TimeWindow[])`](../../doc/models/v2-time-window.md) | Optional | List of allowed install time windows. | getInstallTimeWindowList(): ?array | setInstallTimeWindowList(?array installTimeWindowList): void |
| `deviceList` | `string[]` | Required | Device IMEI list. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

