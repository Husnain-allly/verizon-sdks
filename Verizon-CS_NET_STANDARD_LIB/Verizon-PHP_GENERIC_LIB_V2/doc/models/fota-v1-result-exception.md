
# Fota V1 Result Exception

Response in case of any errors.

*This model accepts additional fields of type array.*

## Structure

`FotaV1ResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `errorCode` | `string` | Required | Error response code. | getErrorCode(): string | setErrorCode(string errorCode): void |
| `errorMessage` | `string` | Required | Description of the error. | getErrorMessage(): string | setErrorMessage(string errorMessage): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

