
# History Search Limit Time

The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.

*This model accepts additional fields of type Object.*

## Structure

`HistorySearchLimitTime`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `StartOn` | `LocalDateTime` | Optional | The starting date-time for this request. | LocalDateTime getStartOn() | setStartOn(LocalDateTime startOn) |
| `Duration` | [`NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. | NumericalData getDuration() | setDuration(NumericalData duration) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "startOn": "2019-08-29T00:47:59.240Z",
  "duration": {
    "value": 5,
    "unit": "SECOND",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

