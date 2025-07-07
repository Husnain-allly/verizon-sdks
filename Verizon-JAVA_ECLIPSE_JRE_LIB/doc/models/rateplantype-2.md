
# Rateplantype 2

*This model accepts additional fields of type Object.*

## Structure

`Rateplantype2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Description` | `String` | Optional | - | String getDescription() | setDescription(String description) |
| `SizeKb` | `String` | Optional | - | String getSizeKb() | setSizeKb(String sizeKb) |
| `CarrierRatePlanCode` | `String` | Optional | - | String getCarrierRatePlanCode() | setCarrierRatePlanCode(String carrierRatePlanCode) |
| `ZeroDollarBilling` | `Boolean` | Optional | - | Boolean getZeroDollarBilling() | setZeroDollarBilling(Boolean zeroDollarBilling) |
| `PromotionOffered` | `Boolean` | Optional | - | Boolean getPromotionOffered() | setPromotionOffered(Boolean promotionOffered) |
| `PromotionDays` | `Integer` | Optional | - | Integer getPromotionDays() | setPromotionDays(Integer promotionDays) |
| `RatePlanType` | `String` | Optional | - | String getRatePlanType() | setRatePlanType(String ratePlanType) |
| `Account` | [`List<Accountid>`](../../doc/models/accountid.md) | Optional | Account information | List<Accountid> getAccount() | setAccount(List<Accountid> account) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

