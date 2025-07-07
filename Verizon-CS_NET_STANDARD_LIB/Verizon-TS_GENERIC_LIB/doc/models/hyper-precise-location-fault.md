
# Hyper Precise Location Fault

Fault occurred while responding.

*This model accepts additional fields of type unknown.*

## Structure

`HyperPreciseLocationFault`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `code` | `string \| undefined` | Optional | Hyper precise location fault code. |
| `message` | `string \| undefined` | Optional | Hyper precise location fault message. |
| `description` | `string \| undefined` | Optional | Hyper precise location fault description. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

