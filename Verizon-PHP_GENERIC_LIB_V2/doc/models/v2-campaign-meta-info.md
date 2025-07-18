
# V2 Campaign Meta Info

Campaign and campaign details.

*This model accepts additional fields of type array.*

## Structure

`V2CampaignMetaInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier. | getAccountName(): string | setAccountName(string accountName): void |
| `id` | `string` | Required | Campaign identifier. | getId(): string | setId(string id): void |
| `campaignName` | `?string` | Optional | Campaign name. | getCampaignName(): ?string | setCampaignName(?string campaignName): void |
| `softwareName` | `string` | Required | Software name. | getSoftwareName(): string | setSoftwareName(string softwareName): void |
| `distributionType` | `string` | Required | LWM2M, OMD-DM or HTTP. | getDistributionType(): string | setDistributionType(string distributionType): void |
| `softwareFrom` | `string` | Required | Old software name. | getSoftwareFrom(): string | setSoftwareFrom(string softwareFrom): void |
| `softwareTo` | `string` | Required | New software name. | getSoftwareTo(): string | setSoftwareTo(string softwareTo): void |
| `make` | `string` | Required | Applicable make. | getMake(): string | setMake(string make): void |
| `model` | `string` | Required | Applicable model. | getModel(): string | setModel(string model): void |
| `startDate` | `DateTime` | Required | Campaign start date. | getStartDate(): \DateTime | setStartDate(\DateTime startDate): void |
| `endDate` | `DateTime` | Required | Campaign end date. | getEndDate(): \DateTime | setEndDate(\DateTime endDate): void |
| `downloadAfterDate` | `?DateTime` | Optional | Specifies starting date client should download package. If null, client will download as soon as possible. | getDownloadAfterDate(): ?\DateTime | setDownloadAfterDate(?\DateTime downloadAfterDate): void |
| `downloadTimeWindowList` | [`?(V2TimeWindow[])`](../../doc/models/v2-time-window.md) | Optional | List of allowed download time windows. | getDownloadTimeWindowList(): ?array | setDownloadTimeWindowList(?array downloadTimeWindowList): void |
| `installAfterDate` | `?DateTime` | Optional | Client will install package after date. If null, client will install as soon as possible. | getInstallAfterDate(): ?\DateTime | setInstallAfterDate(?\DateTime installAfterDate): void |
| `installTimeWindowList` | [`?(V2TimeWindow[])`](../../doc/models/v2-time-window.md) | Optional | List of allowed install time windows. | getInstallTimeWindowList(): ?array | setInstallTimeWindowList(?array installTimeWindowList): void |
| `status` | `string` | Required | Software upgrade status. | getStatus(): string | setStatus(string status): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

