
# V3 Time Window

Time window.

*This model accepts additional fields of type unknown.*

## Structure

`V3TimeWindow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startTime` | `number` | Required | Start hour in range [0..23], current hour >= startTime. |
| `endTime` | `number` | Required | End hour in range [1..24], current hour < endTime. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

