
# Numerical Data

Describes value and unit of time.

*This model accepts additional fields of type object.*

## Structure

`NumericalData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `int?` | Optional | Numerical value. |
| `Unit` | [`NumericalDataUnit?`](../../doc/models/numerical-data-unit.md) | Optional | Unit of time. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

