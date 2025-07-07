
# V2 Time Window

Allowed start and end time windows.

*This model accepts additional fields of type Object.*

## Structure

`V2TimeWindow`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `StartTime` | `int` | Required | Start hour in range [0..23], current hour >= startTime. | int getStartTime() | setStartTime(int startTime) |
| `EndTime` | `int` | Required | End hour in range [1..24], current hour < endTime. | int getEndTime() | setEndTime(int endTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

