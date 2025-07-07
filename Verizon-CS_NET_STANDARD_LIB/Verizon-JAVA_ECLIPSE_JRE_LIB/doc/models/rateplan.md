
# Rateplan

*This model accepts additional fields of type Object.*

## Structure

`Rateplan`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RatePlanGroup` | [`List<RateplanRatePlanGroup>`](../../doc/models/containers/rateplan-rate-plan-group.md) | Optional | This is List of a container for any-of cases. | List<RateplanRatePlanGroup> getRatePlanGroup() | setRatePlanGroup(List<RateplanRatePlanGroup> ratePlanGroup) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "ratePlanGroup": [
    {
      "ratePlanGroupDescription": "ratePlanGroupDescription4",
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
    },
    {
      "ratePlanGroupDescription": "ratePlanGroupDescription4",
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
    },
    {
      "ratePlanGroupDescription": "ratePlanGroupDescription4",
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

