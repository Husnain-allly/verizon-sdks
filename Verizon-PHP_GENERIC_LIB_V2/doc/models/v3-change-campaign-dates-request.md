
# V3 Change Campaign Dates Request

Campaign dates and time windows.

*This model accepts additional fields of type array.*

## Structure

`V3ChangeCampaignDatesRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `startDate` | `DateTime` | Required | Campaign start date. | getStartDate(): \DateTime | setStartDate(\DateTime startDate): void |
| `endDate` | `DateTime` | Required | Campaign end date. | getEndDate(): \DateTime | setEndDate(\DateTime endDate): void |
| `campaignTimeWindowList` | [`?(V3TimeWindow[])`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. | getCampaignTimeWindowList(): ?array | setCampaignTimeWindowList(?array campaignTimeWindowList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "startDate": "2022-02-23",
  "endDate": "2022-02-24",
  "campaignTimeWindowList": [
    {
      "startTime": 14,
      "endTime": 18,
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

