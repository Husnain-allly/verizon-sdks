
# History Search Limit Time

The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.

*This model accepts additional fields of type array.*

## Structure

`HistorySearchLimitTime`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `startOn` | `?DateTime` | Optional | The starting date-time for this request. | getStartOn(): ?\DateTime | setStartOn(?\DateTime startOn): void |
| `duration` | [`?NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. | getDuration(): ?NumericalData | setDuration(?NumericalData duration): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

