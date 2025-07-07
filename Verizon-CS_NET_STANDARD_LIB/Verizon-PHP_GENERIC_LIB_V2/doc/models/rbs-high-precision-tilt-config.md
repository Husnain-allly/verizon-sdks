
# Rbs High Precision Tilt Config

*This model accepts additional fields of type array.*

## Structure

`RbsHighPrecisionTiltConfig`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `mode` | [`?string(Mode)`](../../doc/models/mode.md) | Optional | the reporting mode of the tilt sensor | getMode(): ?string | setMode(?string mode): void |
| `periodicReporting` | [`?PeriodicReporting`](../../doc/models/periodic-reporting.md) | Optional | The units and values of the time interval for the sensor to send a report | getPeriodicReporting(): ?PeriodicReporting | setPeriodicReporting(?PeriodicReporting periodicReporting): void |
| `holdTime` | `?int` | Optional | The time the threshold condition exists, in milliseconds, to recognize an event | getHoldTime(): ?int | setHoldTime(?int holdTime): void |
| `angleAway` | `?int` | Optional | the threshold value, from verticle, to recognize an event | getAngleAway(): ?int | setAngleAway(?int angleAway): void |
| `angleToward` | `?int` | Optional | the threshold value, moving towards  verticle, to recognize an event | getAngleToward(): ?int | setAngleToward(?int angleToward): void |
| `tscore` | [`?Tscore`](../../doc/models/tscore.md) | Optional | - | getTscore(): ?Tscore | setTscore(?Tscore tscore): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

