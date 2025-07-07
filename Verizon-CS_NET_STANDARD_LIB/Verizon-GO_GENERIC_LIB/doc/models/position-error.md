
# Position Error

Position error.

*This model accepts additional fields of type interface{}.*

## Structure

`PositionError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `*string` | Optional | Time location obtained. |
| `Utcoffset` | `*string` | Optional | UTC offset of time. |
| `Type` | `*string` | Optional | Error type returned from location server. |
| `Info` | `*string` | Optional | Additional information about the error. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

