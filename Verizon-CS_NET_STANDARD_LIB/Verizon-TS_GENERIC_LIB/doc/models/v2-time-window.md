
# V2 Time Window

Allowed start and end time windows.

*This model accepts additional fields of type unknown.*

## Structure

`V2TimeWindow`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startTime` | `number` | Required | Start hour in range [0..23], current hour >= startTime. |
| `endTime` | `number` | Required | End hour in range [1..24], current hour < endTime. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

