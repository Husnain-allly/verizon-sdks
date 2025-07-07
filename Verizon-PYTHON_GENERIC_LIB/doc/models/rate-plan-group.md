
# Rate Plan Group

*This model accepts additional fields of type Any.*

## Structure

`RatePlanGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `rate_plan_group_description` | `str` | Optional | - |
| `rate_plan_type` | `Any` | Optional | - |
| `rate_plan` | [`List[Rateplantype2]`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names |
| `description` | `str` | Optional | - |
| `size_kb` | `str` | Optional | - |
| `carrier_rate_plan_code` | `str` | Optional | - |
| `zero_dollar_billing` | `bool` | Optional | - |
| `promotion_offered` | `bool` | Optional | - |
| `promotion_days` | `int` | Optional | - |
| `account` | [`List[Accountid]`](../../doc/models/accountid.md) | Optional | Account information |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

