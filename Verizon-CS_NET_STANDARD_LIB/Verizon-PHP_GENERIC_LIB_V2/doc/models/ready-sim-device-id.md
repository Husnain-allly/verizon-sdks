
# Ready Sim Device Id

*This model accepts additional fields of type array.*

## Structure

`ReadySimDeviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `kind` | `?string` | Optional | - | getKind(): ?string | setKind(?string kind): void |
| `id` | `?string` | Optional | - | getId(): ?string | setId(?string id): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "kind": "iccid",
  "id": "20-digit iccid",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

