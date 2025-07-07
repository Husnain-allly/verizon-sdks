
# I Error Message

Error message.

*This model accepts additional fields of type Object.*

## Structure

`IErrorMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | [`ErrorResponseCode`](../../doc/models/error-response-code.md) | Optional | Error Code. |
| `error_message` | `String` | Optional | Details and additional information about the error code. |
| `http_status_code` | [`HttpStatusCode`](../../doc/models/http-status-code.md) | Optional | HTML error code and description. |
| `detail_error_message` | `String` | Optional | More detail and information about the HTML error code. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

