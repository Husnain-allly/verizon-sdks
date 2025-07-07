
# Device Diagnostics Result Exception

All error messages are returned in this format. Error codes and messages are listed on the Error Codes page, along with explanations and suggestions for corrective actions.

*This model accepts additional fields of type Object.*

## Structure

`DeviceDiagnosticsResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ErrorCode` | `String` | Required | Simple error code. | String getErrorCode() | setErrorCode(String errorCode) |
| `ErrorMessage` | `String` | Required | Detailed error message. | String getErrorMessage() | setErrorMessage(String errorMessage) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "errorCode": "INTERNAL_SYSTEM_ERROR",
  "errorMessage": "The system encountered an internal error.",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

