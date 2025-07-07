
# Hyper Precise Location Fault

Fault occurred while responding.

*This model accepts additional fields of type Object.*

## Structure

`HyperPreciseLocationFault`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `code` | `String` | Optional | Hyper precise location fault code. |
| `message` | `String` | Optional | Hyper precise location fault message. |
| `description` | `String` | Optional | Hyper precise location fault description. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

