
# Connectivity Management Result Exception

Response to errors.

*This model accepts additional fields of type Object.*

## Structure

`ConnectivityManagementResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ErrorCode` | `String` | Optional | Code of the error. | String getErrorCode() | setErrorCode(String errorCode) |
| `ErrorMessage` | `String` | Optional | Details of the error. | String getErrorMessage() | setErrorMessage(String errorMessage) |
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

