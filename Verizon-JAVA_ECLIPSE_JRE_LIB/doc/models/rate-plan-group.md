
# Rate Plan Group

*This model accepts additional fields of type Object.*

## Structure

`RatePlanGroup`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RatePlanGroupDescription` | `String` | Optional | - | String getRatePlanGroupDescription() | setRatePlanGroupDescription(String ratePlanGroupDescription) |
| `RatePlanType` | `Object` | Optional | - | Object getRatePlanType() | setRatePlanType(Object ratePlanType) |
| `RatePlan` | [`List<Rateplantype2>`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names | List<Rateplantype2> getRatePlan() | setRatePlan(List<Rateplantype2> ratePlan) |
| `Description` | `String` | Optional | - | String getDescription() | setDescription(String description) |
| `SizeKb` | `String` | Optional | - | String getSizeKb() | setSizeKb(String sizeKb) |
| `CarrierRatePlanCode` | `String` | Optional | - | String getCarrierRatePlanCode() | setCarrierRatePlanCode(String carrierRatePlanCode) |
| `ZeroDollarBilling` | `Boolean` | Optional | - | Boolean getZeroDollarBilling() | setZeroDollarBilling(Boolean zeroDollarBilling) |
| `PromotionOffered` | `Boolean` | Optional | - | Boolean getPromotionOffered() | setPromotionOffered(Boolean promotionOffered) |
| `PromotionDays` | `Integer` | Optional | - | Integer getPromotionDays() | setPromotionDays(Integer promotionDays) |
| `Account` | [`List<Accountid>`](../../doc/models/accountid.md) | Optional | Account information | List<Accountid> getAccount() | setAccount(List<Accountid> account) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

