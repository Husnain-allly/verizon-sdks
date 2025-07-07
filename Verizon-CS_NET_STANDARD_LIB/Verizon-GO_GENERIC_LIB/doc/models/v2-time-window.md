
# V2 Time Window

Allowed start and end time windows.

*This model accepts additional fields of type interface{}.*

## Structure

`V2TimeWindow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartTime` | `int` | Required | Start hour in range [0..23], current hour >= startTime. |
| `EndTime` | `int` | Required | End hour in range [1..24], current hour < endTime. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "startTime": 20,
  "endTime": 21,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

