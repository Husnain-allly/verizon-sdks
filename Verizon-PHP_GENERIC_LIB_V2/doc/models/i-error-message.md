
# I Error Message

Error message.

*This model accepts additional fields of type array.*

## Structure

`IErrorMessage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `errorCode` | [`?string(ErrorResponseCode)`](../../doc/models/error-response-code.md) | Optional | Error Code. | getErrorCode(): ?string | setErrorCode(?string errorCode): void |
| `errorMessage` | `?string` | Optional | Details and additional information about the error code. | getErrorMessage(): ?string | setErrorMessage(?string errorMessage): void |
| `httpStatusCode` | [`?string(HttpStatusCode)`](../../doc/models/http-status-code.md) | Optional | HTML error code and description. | getHttpStatusCode(): ?string | setHttpStatusCode(?string httpStatusCode): void |
| `detailErrorMessage` | `?string` | Optional | More detail and information about the HTML error code. | getDetailErrorMessage(): ?string | setDetailErrorMessage(?string detailErrorMessage): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "httpStatusCode": "200 OK",
  "errorCode": "INVALID_ACCESS",
  "errorMessage": "errorMessage4",
  "detailErrorMessage": "detailErrorMessage6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

