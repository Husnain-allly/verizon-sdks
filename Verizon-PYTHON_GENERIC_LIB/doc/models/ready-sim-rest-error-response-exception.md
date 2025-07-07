
# Ready Sim Rest Error Response Exception

*This model accepts additional fields of type Any.*

## Structure

`ReadySimRestErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `str` | Optional | - |
| `error_message` | `str` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "The 3-digit HTML error code",
  "errorMessage": "More details about the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

