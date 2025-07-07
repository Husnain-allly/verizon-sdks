
# Device Location Result Exception

Will be empty if there was no error.

*This model accepts additional fields of type array.*

## Structure

`DeviceLocationResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `errorCode` | `string` | Required | - | getErrorCode(): string | setErrorCode(string errorCode): void |
| `errorMessage` | `string` | Required | - | getErrorMessage(): string | setErrorMessage(string errorMessage): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "errorCode": "The type of error, such as INVALID_REQUEST.",
  "errorMessage": "Additional error information.",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

