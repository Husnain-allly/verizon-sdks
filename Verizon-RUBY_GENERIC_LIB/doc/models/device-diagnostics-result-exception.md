
# Device Diagnostics Result Exception

All error messages are returned in this format. Error codes and messages are listed on the Error Codes page, along with explanations and suggestions for corrective actions.

*This model accepts additional fields of type Object.*

## Structure

`DeviceDiagnosticsResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Required | Simple error code. |
| `error_message` | `String` | Required | Detailed error message. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

