
# Periodic Reporting

The units and values of the time interval for the sensor to send a report

*This model accepts additional fields of type Object.*

## Structure

`PeriodicReporting`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Unit` | [`Unit`](../../doc/models/unit.md) | Optional | - | Unit getUnit() | setUnit(Unit unit) |
| `Hours` | `Integer` | Optional | whole numbers from 0 to 24 | Integer getHours() | setHours(Integer hours) |
| `Minutes` | `Integer` | Optional | whole numbers from 0 to 59 | Integer getMinutes() | setMinutes(Integer minutes) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

