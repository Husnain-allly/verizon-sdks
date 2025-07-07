
# Rateplantype 2

*This model accepts additional fields of type Object.*

## Structure

`Rateplantype2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `description` | `String` | Optional | - |
| `size_kb` | `String` | Optional | - |
| `carrier_rate_plan_code` | `String` | Optional | - |
| `zero_dollar_billing` | `TrueClass \| FalseClass` | Optional | - |
| `promotion_offered` | `TrueClass \| FalseClass` | Optional | - |
| `promotion_days` | `Integer` | Optional | - |
| `rate_plan_type` | `String` | Optional | - |
| `account` | [`Array<Accountid>`](../../doc/models/accountid.md) | Optional | Account information |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

