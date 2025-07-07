
# Rate Plan Group

*This model accepts additional fields of type interface{}.*

## Structure

`RatePlanGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RatePlanGroupDescription` | `*string` | Optional | - |
| `RatePlanType` | `*interface{}` | Optional | - |
| `RatePlan` | [`[]models.Rateplantype2`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names |
| `Description` | `*string` | Optional | - |
| `SizeKb` | `*string` | Optional | - |
| `CarrierRatePlanCode` | `*string` | Optional | - |
| `ZeroDollarBilling` | `*bool` | Optional | - |
| `PromotionOffered` | `*bool` | Optional | - |
| `PromotionDays` | `*int` | Optional | - |
| `Account` | [`[]models.Accountid`](../../doc/models/accountid.md) | Optional | Account information |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

