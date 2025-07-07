
# M 5G Bidevice Id 1

*This model accepts additional fields of type array.*

## Structure

`M5GBideviceId1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | - | getId(): ?string | setId(?string id): void |
| `kind` | `?string` | Optional | - | getKind(): ?string | setKind(?string kind): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "id": "15-digit IMSI",
  "kind": "imsi",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

