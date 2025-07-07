
# Position Error

Position error.

*This model accepts additional fields of type Object.*

## Structure

`PositionError`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Time` | `String` | Optional | Time location obtained. | String getTime() | setTime(String time) |
| `Utcoffset` | `String` | Optional | UTC offset of time. | String getUtcoffset() | setUtcoffset(String utcoffset) |
| `Type` | `String` | Optional | Error type returned from location server. | String getType() | setType(String type) |
| `Info` | `String` | Optional | Additional information about the error. | String getInfo() | setInfo(String info) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "time": "20170525214342",
  "type": "POSITION METHOD FAILURE",
  "info": "Exception code=ABSENT SUBSCRIBER",
  "utcoffset": "utcoffset0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

