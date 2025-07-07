
# Rateplantype 2

*This model accepts additional fields of type array.*

## Structure

`Rateplantype2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `description` | `?string` | Optional | - | getDescription(): ?string | setDescription(?string description): void |
| `sizeKb` | `?string` | Optional | - | getSizeKb(): ?string | setSizeKb(?string sizeKb): void |
| `carrierRatePlanCode` | `?string` | Optional | - | getCarrierRatePlanCode(): ?string | setCarrierRatePlanCode(?string carrierRatePlanCode): void |
| `zeroDollarBilling` | `?bool` | Optional | - | getZeroDollarBilling(): ?bool | setZeroDollarBilling(?bool zeroDollarBilling): void |
| `promotionOffered` | `?bool` | Optional | - | getPromotionOffered(): ?bool | setPromotionOffered(?bool promotionOffered): void |
| `promotionDays` | `?int` | Optional | - | getPromotionDays(): ?int | setPromotionDays(?int promotionDays): void |
| `ratePlanType` | `?string` | Optional | - | getRatePlanType(): ?string | setRatePlanType(?string ratePlanType): void |
| `account` | [`?(Accountid[])`](../../doc/models/accountid.md) | Optional | Account information | getAccount(): ?array | setAccount(?array account): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "description": "PlanDescription 2",
  "sizeKb": "1048576",
  "carrierRatePlanCode": "Service plan code value",
  "zeroDollarBilling": false,
  "promotionOffered": false,
  "promotionDays": -2147483648,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

