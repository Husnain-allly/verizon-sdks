
# V2 Time Window

Allowed start and end time windows.

*This model accepts additional fields of type Object.*

## Structure

`V2TimeWindow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `start_time` | `Integer` | Required | Start hour in range [0..23], current hour >= startTime. |
| `end_time` | `Integer` | Required | End hour in range [1..24], current hour < endTime. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

