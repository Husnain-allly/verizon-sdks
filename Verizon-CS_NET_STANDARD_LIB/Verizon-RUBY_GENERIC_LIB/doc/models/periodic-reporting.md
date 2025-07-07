
# Periodic Reporting

The units and values of the time interval for the sensor to send a report

*This model accepts additional fields of type Object.*

## Structure

`PeriodicReporting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unit` | [`Unit`](../../doc/models/unit.md) | Optional | - |
| `hours` | `Integer` | Optional | whole numbers from 0 to 24 |
| `minutes` | `Integer` | Optional | whole numbers from 0 to 59 |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

