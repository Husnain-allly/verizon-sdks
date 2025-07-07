
# V3 Time Window

Time window.

*This model accepts additional fields of type Any.*

## Structure

`V3TimeWindow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `start_time` | `int` | Required | Start hour in range [0..23], current hour >= startTime. |
| `end_time` | `int` | Required | End hour in range [1..24], current hour < endTime. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "startTime": 18,
  "endTime": 22,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

