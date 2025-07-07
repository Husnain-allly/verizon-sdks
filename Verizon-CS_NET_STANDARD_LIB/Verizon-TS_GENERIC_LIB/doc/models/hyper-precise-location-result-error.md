
# Hyper Precise Location Result Error

Error response.

*This model accepts additional fields of type unknown.*

## Structure

`HyperPreciseLocationResultError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `responseCode` | [`ErrorResponseCode \| undefined`](../../doc/models/error-response-code.md) | Optional | Error Code. |
| `message` | `string \| undefined` | Optional | Error message. |
| `fault` | [`HyperPreciseLocationFault \| undefined`](../../doc/models/hyper-precise-location-fault.md) | Optional | Fault occurred while responding. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

