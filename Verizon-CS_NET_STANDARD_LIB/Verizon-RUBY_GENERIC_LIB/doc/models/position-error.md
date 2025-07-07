
# Position Error

Position error.

*This model accepts additional fields of type Object.*

## Structure

`PositionError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `time` | `String` | Optional | Time location obtained. |
| `utcoffset` | `String` | Optional | UTC offset of time. |
| `type` | `String` | Optional | Error type returned from location server. |
| `info` | `String` | Optional | Additional information about the error. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

