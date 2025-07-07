
# Fota V1 Result Exception

Response in case of any errors.

*This model accepts additional fields of type Object.*

## Structure

`FotaV1ResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ErrorCode` | `String` | Required | Error response code. | String getErrorCode() | setErrorCode(String errorCode) |
| `ErrorMessage` | `String` | Required | Description of the error. | String getErrorMessage() | setErrorMessage(String errorMessage) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "errorCode": "error code string",
  "errorMessage": "error message string",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

