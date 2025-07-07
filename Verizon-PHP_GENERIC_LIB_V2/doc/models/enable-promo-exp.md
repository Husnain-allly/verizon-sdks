
# Enable Promo Exp

*This model accepts additional fields of type array.*

## Structure

`EnablePromoExp`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `enablePromoExp` | `?bool` | Optional | - | getEnablePromoExp(): ?bool | setEnablePromoExp(?bool enablePromoExp): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "enablePromoExp": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

