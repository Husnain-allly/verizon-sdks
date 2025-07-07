
# Rateplantype 2

*This model accepts additional fields of type interface{}.*

## Structure

`Rateplantype2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `*string` | Optional | - |
| `SizeKb` | `*string` | Optional | - |
| `CarrierRatePlanCode` | `*string` | Optional | - |
| `ZeroDollarBilling` | `*bool` | Optional | - |
| `PromotionOffered` | `*bool` | Optional | - |
| `PromotionDays` | `*int` | Optional | - |
| `RatePlanType` | `*string` | Optional | - |
| `Account` | [`[]models.Accountid`](../../doc/models/accountid.md) | Optional | Account information |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

