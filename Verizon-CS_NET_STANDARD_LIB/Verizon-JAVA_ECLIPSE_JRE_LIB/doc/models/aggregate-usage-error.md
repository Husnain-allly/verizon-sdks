
# Aggregate Usage Error

Error reported by a device.

*This model accepts additional fields of type Object.*

## Structure

`AggregateUsageError`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Imei` | `String` | Optional | International Mobile Equipment Identifier. This is the ID of the device reporting errors. | String getImei() | setImei(String imei) |
| `ErrorMessage` | `String` | Optional | A general error message. | String getErrorMessage() | setErrorMessage(String errorMessage) |
| `ErrorResponse` | [`IErrorMessage`](../../doc/models/i-error-message.md) | Optional | Error message. | IErrorMessage getErrorResponse() | setErrorResponse(IErrorMessage errorResponse) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "errorResponse": {
    "httpStatusCode": "200 OK",
    "errorCode": "INVALID_ACCESS",
    "errorMessage": "errorMessage4",
    "detailErrorMessage": "detailErrorMessage6",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "imei": "imei0",
  "errorMessage": "errorMessage4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

