
# Position Error

Position error.

*This model accepts additional fields of type Any.*

## Structure

`PositionError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `time` | `str` | Optional | Time location obtained. |
| `utcoffset` | `str` | Optional | UTC offset of time. |
| `mtype` | `str` | Optional | Error type returned from location server. |
| `info` | `str` | Optional | Additional information about the error. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

