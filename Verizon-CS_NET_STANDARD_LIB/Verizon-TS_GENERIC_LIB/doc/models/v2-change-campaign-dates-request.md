
# V2 Change Campaign Dates Request

New dates and time windows.

*This model accepts additional fields of type unknown.*

## Structure

`V2ChangeCampaignDatesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `string` | Required | Campaign start date. |
| `endDate` | `string` | Required | Campaign end date. |
| `downloadAfterDate` | `string \| undefined` | Optional | Specifies starting date client should download package. If null, client will download as soon as possible. |
| `downloadTimeWindowList` | [`V2TimeWindow[] \| undefined`](../../doc/models/v2-time-window.md) | Optional | List of allowed download time windows. Removing of existing windows is not allowed. |
| `installAfterDate` | `string \| undefined` | Optional | Client will install package after date. If null, client will install as soon as possible. |
| `installTimeWindowList` | [`V2TimeWindow[] \| undefined`](../../doc/models/v2-time-window.md) | Optional | List of allowed install time windows. Removing of existing windows is not allowed. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": 3,
      "endTime": 4,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": 5,
      "endTime": 6,
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

