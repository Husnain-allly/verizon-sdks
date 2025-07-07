
# Rbstiltconfig

*This model accepts additional fields of type interface{}.*

## Structure

`Rbstiltconfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RbsHighPrecisionTiltConfig` | [`*models.RbsHighPrecisionTiltConfig`](../../doc/models/rbs-high-precision-tilt-config.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "RbsHighPrecisionTiltConfig": {
    "mode": "reportOnChange",
    "periodic-reporting": {
      "unit": "minutes",
      "hours": 250,
      "minutes": 232,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "hold-time": 62,
    "angle-away": 90,
    "angle-toward": 30,
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

