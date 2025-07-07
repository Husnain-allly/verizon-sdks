
# Rateplantype Object

*This model accepts additional fields of type array.*

## Structure

`RateplantypeObject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ratePlanGroupDescription` | `?string` | Optional | - | getRatePlanGroupDescription(): ?string | setRatePlanGroupDescription(?string ratePlanGroupDescription): void |
| `ratePlanType` | `?string` | Optional | - | getRatePlanType(): ?string | setRatePlanType(?string ratePlanType): void |
| `ratePlan` | [`?(Rateplantype2[])`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names | getRatePlan(): ?array | setRatePlan(?array ratePlan): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "ratePlanGroupDescription": "AGS Description_73",
  "ratePlanType": "ratePlanType2",
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
    },
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

