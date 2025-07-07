
# Aggregate Usage Error

Error reported by a device.

*This model accepts additional fields of type Any.*

## Structure

`AggregateUsageError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imei` | `str` | Optional | International Mobile Equipment Identifier. This is the ID of the device reporting errors. |
| `error_message` | `str` | Optional | A general error message. |
| `error_response` | [`IErrorMessage`](../../doc/models/i-error-message.md) | Optional | Error message. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

