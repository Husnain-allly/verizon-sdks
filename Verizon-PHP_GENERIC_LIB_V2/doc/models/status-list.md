
# Status List

*This model accepts additional fields of type array.*

## Structure

`StatusList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | Account name | getId(): ?string | setId(?string id): void |
| `status` | `?string` | Optional | Success or Fail | getStatus(): ?string | setStatus(?string status): void |
| `reason` | `?string` | Optional | detailed reason | getReason(): ?string | setReason(?string reason): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "id": "1223334444-00001",
  "status": "Success",
  "reason": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

