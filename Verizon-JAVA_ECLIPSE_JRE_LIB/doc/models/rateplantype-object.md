
# Rateplantype Object

*This model accepts additional fields of type Object.*

## Structure

`RateplantypeObject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RatePlanGroupDescription` | `String` | Optional | - | String getRatePlanGroupDescription() | setRatePlanGroupDescription(String ratePlanGroupDescription) |
| `RatePlanType` | `String` | Optional | - | String getRatePlanType() | setRatePlanType(String ratePlanType) |
| `RatePlan` | [`List<Rateplantype2>`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names | List<Rateplantype2> getRatePlan() | setRatePlan(List<Rateplantype2> ratePlan) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

