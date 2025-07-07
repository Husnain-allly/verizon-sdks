
# Hyper Precise Location Fault

Fault occurred while responding.

*This model accepts additional fields of type object.*

## Structure

`HyperPreciseLocationFault`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Hyper precise location fault code. |
| `Message` | `string` | Optional | Hyper precise location fault message. |
| `Description` | `string` | Optional | Hyper precise location fault description. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "code": "900906",
  "message": "No matching resource found in the API for the given request",
  "description": "Access failure for API. Check the API documentation and add a proper REST resource path to the invocation URL.",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

