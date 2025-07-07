
# Location

Device location information.

*This model accepts additional fields of type interface{}.*

## Structure

`Location`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Msid` | `*string` | Optional | MDN. |
| `Pd` | [`*models.PositionData`](../../doc/models/position-data.md) | Optional | Position data. |
| `Error` | [`*models.PositionError`](../../doc/models/position-error.md) | Optional | Position error. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

