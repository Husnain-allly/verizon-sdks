
# Hyper Precise Location Fault

Fault occurred while responding.

*This model accepts additional fields of type array.*

## Structure

`HyperPreciseLocationFault`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `code` | `?string` | Optional | Hyper precise location fault code. | getCode(): ?string | setCode(?string code): void |
| `message` | `?string` | Optional | Hyper precise location fault message. | getMessage(): ?string | setMessage(?string message): void |
| `description` | `?string` | Optional | Hyper precise location fault description. | getDescription(): ?string | setDescription(?string description): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

