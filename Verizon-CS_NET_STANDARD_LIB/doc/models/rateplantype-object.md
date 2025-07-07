
# Rateplantype Object

*This model accepts additional fields of type object.*

## Structure

`RateplantypeObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RatePlanGroupDescription` | `string` | Optional | - |
| `RatePlanType` | `string` | Optional | - |
| `RatePlan` | [`List<Rateplantype2>`](../../doc/models/rateplantype-2.md) | Optional | An array of rateplan names |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

