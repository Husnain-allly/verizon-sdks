
# History Search Limit Time

The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.

*This model accepts additional fields of type unknown.*

## Structure

`HistorySearchLimitTime`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startOn` | `string \| undefined` | Optional | The starting date-time for this request. |
| `duration` | [`NumericalData \| undefined`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

