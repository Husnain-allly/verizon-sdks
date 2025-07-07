
# Rest Error Response Exception

*This model accepts additional fields of type Object.*

## Structure

`RestErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Optional | **Constraints**: *Maximum Length*: `3`, *Pattern*: `^[0-9]{3}$` |
| `error_message` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "400",
  "errorMessage": "a description of the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

