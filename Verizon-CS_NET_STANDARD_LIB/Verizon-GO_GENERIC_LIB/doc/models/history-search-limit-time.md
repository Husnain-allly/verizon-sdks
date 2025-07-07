
# History Search Limit Time

The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.

*This model accepts additional fields of type interface{}.*

## Structure

`HistorySearchLimitTime`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartOn` | `*time.Time` | Optional | The starting date-time for this request. |
| `Duration` | [`*models.NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

