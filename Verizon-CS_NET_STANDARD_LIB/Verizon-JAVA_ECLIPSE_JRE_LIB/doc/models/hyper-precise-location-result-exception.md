
# Hyper Precise Location Result Exception

Error response.

*This model accepts additional fields of type Object.*

## Structure

`HyperPreciseLocationResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ResponseCode` | [`ErrorResponseCode`](../../doc/models/error-response-code.md) | Optional | Error Code. | ErrorResponseCode getResponseCodeField() | setResponseCodeField(ErrorResponseCode responseCodeField) |
| `Message` | `String` | Optional | Error message. | String getMessageField() | setMessageField(String messageField) |
| `Fault` | [`HyperPreciseLocationFault`](../../doc/models/hyper-precise-location-fault.md) | Optional | Fault occurred while responding. | HyperPreciseLocationFault getFault() | setFault(HyperPreciseLocationFault fault) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "responseCode": "INVALID_ACCESS",
  "fault": {
    "code": "900906",
    "message": "No matching resource found in the API for the given request",
    "description": "Access failure for API. Check the API documentation and add a proper REST resource path to the invocation URL.",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "message": "message4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

