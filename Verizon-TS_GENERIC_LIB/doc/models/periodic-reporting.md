
# Periodic Reporting

The units and values of the time interval for the sensor to send a report

*This model accepts additional fields of type unknown.*

## Structure

`PeriodicReporting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unit` | [`Unit \| undefined`](../../doc/models/unit.md) | Optional | - |
| `hours` | `number \| undefined` | Optional | whole numbers from 0 to 24 |
| `minutes` | `number \| undefined` | Optional | whole numbers from 0 to 59 |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

