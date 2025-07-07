
# I Error Message

Error message.

*This model accepts additional fields of type Object.*

## Structure

`IErrorMessage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ErrorCode` | [`ErrorResponseCode`](../../doc/models/error-response-code.md) | Optional | Error Code. | ErrorResponseCode getErrorCode() | setErrorCode(ErrorResponseCode errorCode) |
| `ErrorMessage` | `String` | Optional | Details and additional information about the error code. | String getErrorMessage() | setErrorMessage(String errorMessage) |
| `HttpStatusCode` | [`HttpStatusCode`](../../doc/models/http-status-code.md) | Optional | HTML error code and description. | HttpStatusCode getHttpStatusCode() | setHttpStatusCode(HttpStatusCode httpStatusCode) |
| `DetailErrorMessage` | `String` | Optional | More detail and information about the HTML error code. | String getDetailErrorMessage() | setDetailErrorMessage(String detailErrorMessage) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

