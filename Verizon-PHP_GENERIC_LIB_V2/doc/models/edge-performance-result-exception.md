
# Edge Performance Result Exception

Types of errors in response.

*This model accepts additional fields of type array.*

## Structure

`EdgePerformanceResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `status` | `?string` | Optional | HTTP status code. | getStatus(): ?string | setStatus(?string status): void |
| `message` | `?string` | Optional | Error details. | getMessage(): ?string | setMessage(?string message): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "status": "HTTP status code",
  "message": "Error details",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

