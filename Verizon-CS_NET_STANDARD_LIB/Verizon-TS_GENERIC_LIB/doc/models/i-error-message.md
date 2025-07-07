
# I Error Message

Error message.

*This model accepts additional fields of type unknown.*

## Structure

`IErrorMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `errorCode` | [`ErrorResponseCode \| undefined`](../../doc/models/error-response-code.md) | Optional | Error Code. |
| `errorMessage` | `string \| undefined` | Optional | Details and additional information about the error code. |
| `httpStatusCode` | [`HttpStatusCode \| undefined`](../../doc/models/http-status-code.md) | Optional | HTML error code and description. |
| `detailErrorMessage` | `string \| undefined` | Optional | More detail and information about the HTML error code. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

