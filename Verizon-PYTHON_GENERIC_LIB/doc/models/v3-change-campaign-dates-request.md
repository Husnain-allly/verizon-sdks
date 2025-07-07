
# V3 Change Campaign Dates Request

Campaign dates and time windows.

*This model accepts additional fields of type Any.*

## Structure

`V3ChangeCampaignDatesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `start_date` | `date` | Required | Campaign start date. |
| `end_date` | `date` | Required | Campaign end date. |
| `campaign_time_window_list` | [`List[V3TimeWindow]`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

