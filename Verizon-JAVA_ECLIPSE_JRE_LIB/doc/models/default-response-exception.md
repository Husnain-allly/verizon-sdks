
# Default Response Exception

*This model accepts additional fields of type Object.*

## Structure

`DefaultResponseException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ErrorCode` | `String` | Optional | - | String getErrorCode() | setErrorCode(String errorCode) |
| `ErrorMessage` | `String` | Optional | - | String getErrorMessage() | setErrorMessage(String errorMessage) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "errorCode": "3 or 4 digit error code",
  "errorMessage": "A short description of the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

