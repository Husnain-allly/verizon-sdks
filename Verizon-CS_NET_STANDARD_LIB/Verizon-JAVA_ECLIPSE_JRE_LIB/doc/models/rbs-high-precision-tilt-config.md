
# Rbs High Precision Tilt Config

*This model accepts additional fields of type Object.*

## Structure

`RbsHighPrecisionTiltConfig`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Mode` | [`Mode`](../../doc/models/mode.md) | Optional | the reporting mode of the tilt sensor | Mode getMode() | setMode(Mode mode) |
| `PeriodicReporting` | [`PeriodicReporting`](../../doc/models/periodic-reporting.md) | Optional | The units and values of the time interval for the sensor to send a report | PeriodicReporting getPeriodicReporting() | setPeriodicReporting(PeriodicReporting periodicReporting) |
| `HoldTime` | `Integer` | Optional | The time the threshold condition exists, in milliseconds, to recognize an event | Integer getHoldTime() | setHoldTime(Integer holdTime) |
| `AngleAway` | `Integer` | Optional | the threshold value, from verticle, to recognize an event | Integer getAngleAway() | setAngleAway(Integer angleAway) |
| `AngleToward` | `Integer` | Optional | the threshold value, moving towards  verticle, to recognize an event | Integer getAngleToward() | setAngleToward(Integer angleToward) |
| `Tscore` | [`Tscore`](../../doc/models/tscore.md) | Optional | - | Tscore getTscore() | setTscore(Tscore tscore) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

