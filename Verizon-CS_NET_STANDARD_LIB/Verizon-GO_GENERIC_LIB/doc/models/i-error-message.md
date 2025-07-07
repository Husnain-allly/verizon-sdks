
# I Error Message

Error message.

*This model accepts additional fields of type interface{}.*

## Structure

`IErrorMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | [`*models.ErrorResponseCode`](../../doc/models/error-response-code.md) | Optional | Error Code. |
| `ErrorMessage` | `*string` | Optional | Details and additional information about the error code. |
| `HttpStatusCode` | [`*models.HttpStatusCode`](../../doc/models/http-status-code.md) | Optional | HTML error code and description. |
| `DetailErrorMessage` | `*string` | Optional | More detail and information about the HTML error code. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

