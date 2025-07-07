
# Location

Device location information.

*This model accepts additional fields of type Object.*

## Structure

`Location`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Msid` | `String` | Optional | MDN. | String getMsid() | setMsid(String msid) |
| `Pd` | [`PositionData`](../../doc/models/position-data.md) | Optional | Position data. | PositionData getPd() | setPd(PositionData pd) |
| `Error` | [`PositionError`](../../doc/models/position-error.md) | Optional | Position error. | PositionError getError() | setError(PositionError error) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "msid": "7892345678",
  "pd": {
    "time": "20170520004421",
    "x": "33.45324",
    "y": "-84.59621",
    "radius": "5571",
    "qos": false,
    "utcoffset": "utcoffset2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "error": {
    "time": "time4",
    "utcoffset": "utcoffset4",
    "type": "type6",
    "info": "info4",
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

