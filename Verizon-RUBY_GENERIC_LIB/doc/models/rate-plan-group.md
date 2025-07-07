
# Rate Plan Group

*This model accepts additional fields of type Object.*

## Structure

`RatePlanGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `rate_plan_group_description` | `String` | Optional | - |
| `rate_plan_type` | `Object` | Optional | - |
| `rate_plan` | [`Array<Rateplantype2>`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names |
| `description` | `String` | Optional | - |
| `size_kb` | `String` | Optional | - |
| `carrier_rate_plan_code` | `String` | Optional | - |
| `zero_dollar_billing` | `TrueClass \| FalseClass` | Optional | - |
| `promotion_offered` | `TrueClass \| FalseClass` | Optional | - |
| `promotion_days` | `Integer` | Optional | - |
| `account` | [`Array<Accountid>`](../../doc/models/accountid.md) | Optional | Account information |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

