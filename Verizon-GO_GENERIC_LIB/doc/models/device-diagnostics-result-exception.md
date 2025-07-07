
# Device Diagnostics Result Exception

All error messages are returned in this format. Error codes and messages are listed on the Error Codes page, along with explanations and suggestions for corrective actions.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceDiagnosticsResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Required | Simple error code. |
| `ErrorMessage` | `string` | Required | Detailed error message. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

