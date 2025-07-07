
# Numerical Data

Describes value and unit of time.

*This model accepts additional fields of type unknown.*

## Structure

`NumericalData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `value` | `number \| undefined` | Optional | Numerical value. |
| `unit` | [`NumericalDataUnit \| undefined`](../../doc/models/numerical-data-unit.md) | Optional | Unit of time. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

