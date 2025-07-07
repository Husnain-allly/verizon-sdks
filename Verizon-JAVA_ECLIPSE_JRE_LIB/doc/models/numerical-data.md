
# Numerical Data

Describes value and unit of time.

*This model accepts additional fields of type Object.*

## Structure

`NumericalData`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Value` | `Integer` | Optional | Numerical value. | Integer getValue() | setValue(Integer value) |
| `Unit` | [`NumericalDataUnit`](../../doc/models/numerical-data-unit.md) | Optional | Unit of time. | NumericalDataUnit getUnit() | setUnit(NumericalDataUnit unit) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

