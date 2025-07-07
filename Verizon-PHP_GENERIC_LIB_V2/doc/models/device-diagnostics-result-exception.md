
# Device Diagnostics Result Exception

All error messages are returned in this format. Error codes and messages are listed on the Error Codes page, along with explanations and suggestions for corrective actions.

*This model accepts additional fields of type array.*

## Structure

`DeviceDiagnosticsResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `errorCode` | `string` | Required | Simple error code. | getErrorCode(): string | setErrorCode(string errorCode): void |
| `errorMessage` | `string` | Required | Detailed error message. | getErrorMessage(): string | setErrorMessage(string errorMessage): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

