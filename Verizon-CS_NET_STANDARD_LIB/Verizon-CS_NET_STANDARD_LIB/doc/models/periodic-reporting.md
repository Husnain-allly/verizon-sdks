
# Periodic Reporting

The units and values of the time interval for the sensor to send a report

*This model accepts additional fields of type object.*

## Structure

`PeriodicReporting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Unit` | [`Unit?`](../../doc/models/unit.md) | Optional | - |
| `Hours` | `int?` | Optional | whole numbers from 0 to 24 |
| `Minutes` | `int?` | Optional | whole numbers from 0 to 59 |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

