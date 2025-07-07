
# Position Data

Position data.

*This model accepts additional fields of type Object.*

## Structure

`PositionData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `time` | `String` | Optional | Time location obtained. |
| `utcoffset` | `String` | Optional | UTC offset of time. |
| `x` | `String` | Optional | X coordinate of location. |
| `y` | `String` | Optional | Y coordinate of location. |
| `radius` | `String` | Optional | Radius of the location in meters. |
| `qos` | `TrueClass \| FalseClass` | Optional | Whether requested accurary is met or not. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "qos": false,
  "radius": "5571",
  "time": "20170520004421",
  "x": "33.45324",
  "y": "-84.59621",
  "utcoffset": "utcoffset0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

