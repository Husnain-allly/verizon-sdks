
# V2 Campaign History

Campaign history details.

*This model accepts additional fields of type array.*

## Structure

`V2CampaignHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `hasMoreData` | `bool` | Required | Has more report flag. | getHasMoreData(): bool | setHasMoreData(bool hasMoreData): void |
| `lastSeenCampaignId` | `?string` | Optional | Campaign identifier. | getLastSeenCampaignId(): ?string | setLastSeenCampaignId(?string lastSeenCampaignId): void |
| `campaignList` | [`?(V2CampaignMetaInfo[])`](../../doc/models/v2-campaign-meta-info.md) | Required | Software upgrade list. | getCampaignList(): ?array | setCampaignList(?array campaignList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "hasMoreData": true,
  "lastSeenCampaignId": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "campaignList": [
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

