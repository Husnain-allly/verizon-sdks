
# V3 Change Campaign Dates Request

Campaign dates and time windows.

*This model accepts additional fields of type interface{}.*

## Structure

`V3ChangeCampaignDatesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `time.Time` | Required | Campaign start date. |
| `EndDate` | `time.Time` | Required | Campaign end date. |
| `CampaignTimeWindowList` | [`[]models.V3TimeWindow`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

