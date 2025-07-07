
# Numerical Data

Describes value and unit of time.

*This model accepts additional fields of type Any.*

## Structure

`NumericalData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `value` | `int` | Optional | Numerical value. |
| `unit` | [`NumericalDataUnit`](../../doc/models/numerical-data-unit.md) | Optional | Unit of time. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

