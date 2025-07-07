
# Numerical Data

Describes value and unit of time.

*This model accepts additional fields of type interface{}.*

## Structure

`NumericalData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Value` | `*int` | Optional | Numerical value. |
| `Unit` | [`*models.NumericalDataUnit`](../../doc/models/numerical-data-unit.md) | Optional | Unit of time. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "value": 5,
  "unit": "SECOND",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

