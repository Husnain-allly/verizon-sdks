
# Rate Plan Group

*This model accepts additional fields of type array.*

## Structure

`RatePlanGroup`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ratePlanGroupDescription` | `?string` | Optional | - | getRatePlanGroupDescription(): ?string | setRatePlanGroupDescription(?string ratePlanGroupDescription): void |
| `ratePlanType` | `?array` | Optional | - | getRatePlanType(): ?array | setRatePlanType(?array ratePlanType): void |
| `ratePlan` | [`?(Rateplantype2[])`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names | getRatePlan(): ?array | setRatePlan(?array ratePlan): void |
| `description` | `?string` | Optional | - | getDescription(): ?string | setDescription(?string description): void |
| `sizeKb` | `?string` | Optional | - | getSizeKb(): ?string | setSizeKb(?string sizeKb): void |
| `carrierRatePlanCode` | `?string` | Optional | - | getCarrierRatePlanCode(): ?string | setCarrierRatePlanCode(?string carrierRatePlanCode): void |
| `zeroDollarBilling` | `?bool` | Optional | - | getZeroDollarBilling(): ?bool | setZeroDollarBilling(?bool zeroDollarBilling): void |
| `promotionOffered` | `?bool` | Optional | - | getPromotionOffered(): ?bool | setPromotionOffered(?bool promotionOffered): void |
| `promotionDays` | `?int` | Optional | - | getPromotionDays(): ?int | setPromotionDays(?int promotionDays): void |
| `account` | [`?(Accountid[])`](../../doc/models/accountid.md) | Optional | Account information | getAccount(): ?array | setAccount(?array account): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "ratePlanGroupDescription": "AGS Description_73",
  "description": "PlanDescription 2",
  "sizeKb": "1048576",
  "carrierRatePlanCode": "Service plan code value",
  "zeroDollarBilling": false,
  "promotionOffered": false,
  "promotionDays": -2147483648,
  "ratePlanType": {
    "key1": "val1",
    "key2": "val2"
  },
  "ratePlan": [
    {
      "description": "description2",
      "sizeKb": "sizeKb2",
      "carrierRatePlanCode": "carrierRatePlanCode8",
      "zeroDollarBilling": false,
      "promotionOffered": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

