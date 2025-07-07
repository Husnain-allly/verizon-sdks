
# Hyper Precise Location Result Exception

Error response.

*This model accepts additional fields of type object.*

## Structure

`HyperPreciseLocationResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResponseCode` | [`ErrorResponseCode?`](../../doc/models/error-response-code.md) | Optional | Error Code. |
| `Message` | `string` | Optional | Error message. |
| `Fault` | [`HyperPreciseLocationFault`](../../doc/models/hyper-precise-location-fault.md) | Optional | Fault occurred while responding. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

