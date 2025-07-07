
# Enable Promo Exp 1

*This model accepts additional fields of type array.*

## Structure

`EnablePromoExp1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `key` | `?string` | Optional | - | getKey(): ?string | setKey(?string key): void |
| `value` | `?bool` | Optional | - | getValue(): ?bool | setValue(?bool value): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "key": "EnablePromoExp",
  "value": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

