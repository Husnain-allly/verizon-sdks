
# No of Days B4 Promo Exp

*This model accepts additional fields of type array.*

## Structure

`NoOfDaysB4PromoExp`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `key` | `?string` | Optional | - | getKey(): ?string | setKey(?string key): void |
| `value` | `?int` | Optional | - | getValue(): ?int | setValue(?int value): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "key": "NoOfDaysB4PromoExp",
  "value": 5,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

