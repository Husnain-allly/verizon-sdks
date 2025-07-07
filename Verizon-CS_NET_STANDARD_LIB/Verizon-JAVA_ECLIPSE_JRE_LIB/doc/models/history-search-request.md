
# History Search Request

Used to filter data by time period or number of devices.

*This model accepts additional fields of type Object.*

## Structure

`HistorySearchRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `MFilter` | [`HistorySearchFilter`](../../doc/models/history-search-filter.md) | Required | The selected device and attributes for which a request should retrieve data. | HistorySearchFilter getMFilter() | setMFilter(HistorySearchFilter mFilter) |
| `MLimitNumber` | `Integer` | Optional | The maximum number of historical attributes to include in the response. If the request matches more than this number of attributes, the response will contain an X-Next value in the header that can be used as the page value in the next request to retrieve the next page of events. | Integer getMLimitNumber() | setMLimitNumber(Integer mLimitNumber) |
| `MLimitTime` | [`HistorySearchLimitTime`](../../doc/models/history-search-limit-time.md) | Optional | The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration. | HistorySearchLimitTime getMLimitTime() | setMLimitTime(HistorySearchLimitTime mLimitTime) |
| `MPage` | `String` | Optional | Page number for pagination purposes. | String getMPage() | setMPage(String mPage) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "$filter": {
    "accountName": "0000123456-00001",
    "device": {
      "id": "15-digit IMEI",
      "kind": "IMEI",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "attributes": null,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "$limitNumber": 10,
  "$limitTime": null,
  "$page": "$page2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

