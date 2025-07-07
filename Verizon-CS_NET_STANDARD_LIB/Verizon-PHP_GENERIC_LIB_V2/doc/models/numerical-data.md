
# Numerical Data

Describes value and unit of time.

*This model accepts additional fields of type array.*

## Structure

`NumericalData`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `value` | `?int` | Optional | Numerical value. | getValue(): ?int | setValue(?int value): void |
| `unit` | [`?string(NumericalDataUnit)`](../../doc/models/numerical-data-unit.md) | Optional | Unit of time. | getUnit(): ?string | setUnit(?string unit): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

