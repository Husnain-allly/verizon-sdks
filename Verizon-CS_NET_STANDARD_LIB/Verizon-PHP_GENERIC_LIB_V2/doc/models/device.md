
# Device

Identifies a particular IoT device.

*This model accepts additional fields of type array.*

## Structure

`Device`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `string` | Required | Device identifier. | getId(): string | setId(string id): void |
| `kind` | `string` | Required | Device kind identifier. | getKind(): string | setKind(string kind): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "id": "864508030026238",
  "kind": "IMEI",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

