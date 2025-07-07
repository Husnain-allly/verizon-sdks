
# Periodic Reporting

The units and values of the time interval for the sensor to send a report

*This model accepts additional fields of type array.*

## Structure

`PeriodicReporting`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `unit` | [`?string(Unit)`](../../doc/models/unit.md) | Optional | - | getUnit(): ?string | setUnit(?string unit): void |
| `hours` | `?int` | Optional | whole numbers from 0 to 24 | getHours(): ?int | setHours(?int hours): void |
| `minutes` | `?int` | Optional | whole numbers from 0 to 59 | getMinutes(): ?int | setMinutes(?int minutes): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "hours": 0,
  "minutes": 12,
  "unit": "minutes",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

