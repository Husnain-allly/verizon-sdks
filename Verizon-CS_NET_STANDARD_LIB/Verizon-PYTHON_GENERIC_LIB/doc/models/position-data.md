
# Position Data

Position data.

*This model accepts additional fields of type Any.*

## Structure

`PositionData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `time` | `str` | Optional | Time location obtained. |
| `utcoffset` | `str` | Optional | UTC offset of time. |
| `x` | `str` | Optional | X coordinate of location. |
| `y` | `str` | Optional | Y coordinate of location. |
| `radius` | `str` | Optional | Radius of the location in meters. |
| `qos` | `bool` | Optional | Whether requested accurary is met or not. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

