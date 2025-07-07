
# Rbs High Precision Tilt Config

*This model accepts additional fields of type unknown.*

## Structure

`RbsHighPrecisionTiltConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mode` | [`Mode \| undefined`](../../doc/models/mode.md) | Optional | the reporting mode of the tilt sensor |
| `periodicReporting` | [`PeriodicReporting \| undefined`](../../doc/models/periodic-reporting.md) | Optional | The units and values of the time interval for the sensor to send a report |
| `holdTime` | `number \| undefined` | Optional | The time the threshold condition exists, in milliseconds, to recognize an event |
| `angleAway` | `number \| undefined` | Optional | the threshold value, from verticle, to recognize an event |
| `angleToward` | `number \| undefined` | Optional | the threshold value, moving towards  verticle, to recognize an event |
| `tscore` | [`Tscore \| undefined`](../../doc/models/tscore.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "hold-time": 5000,
  "angle-away": 5,
  "angle-toward": 5,
  "mode": "reportOnChange",
  "periodic-reporting": {
    "unit": "minutes",
    "hours": 250,
    "minutes": 232,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

