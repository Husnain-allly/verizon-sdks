
# Periodic Reporting

The units and values of the time interval for the sensor to send a report

*This model accepts additional fields of type Any.*

## Structure

`PeriodicReporting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unit` | [`Unit`](../../doc/models/unit.md) | Optional | - |
| `hours` | `int` | Optional | whole numbers from 0 to 24 |
| `minutes` | `int` | Optional | whole numbers from 0 to 59 |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

