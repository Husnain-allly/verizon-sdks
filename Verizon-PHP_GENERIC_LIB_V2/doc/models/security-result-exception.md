
# Security Result Exception

Error response.

*This model accepts additional fields of type array.*

## Structure

`SecurityResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `errorCode` | `?string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[0-9]{3,3}$` | getErrorCode(): ?string | setErrorCode(?string errorCode): void |
| `errorMessage` | `?string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getErrorMessage(): ?string | setErrorMessage(?string errorMessage): void |
| `errorUrl` | `?string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^https://[A-Za-z0-9].[A-Za-z]{3,64}$` | getErrorUrl(): ?string | setErrorUrl(?string errorUrl): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "errorCode": "errorCode8",
  "errorMessage": "errorMessage0",
  "errorUrl": "errorUrl8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

