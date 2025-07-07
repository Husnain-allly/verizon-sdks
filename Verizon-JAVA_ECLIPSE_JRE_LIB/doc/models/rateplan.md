
# Rateplan

*This model accepts additional fields of type Object.*

## Structure

`Rateplan`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RatePlanGroup` | [`List<RatePlanGroup>`](../../doc/models/rate-plan-group.md) | Optional | An array of rate plan group names | List<RatePlanGroup> getRatePlanGroup() | setRatePlanGroup(List<RatePlanGroup> ratePlanGroup) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "ratePlanGroup": [
    {
      "ratePlanGroupDescription": "ratePlanGroupDescription2",
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
      "description": "description0",
      "sizeKb": "sizeKb0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "ratePlanGroupDescription": "ratePlanGroupDescription2",
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
      "description": "description0",
      "sizeKb": "sizeKb0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "ratePlanGroupDescription": "ratePlanGroupDescription2",
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
      "description": "description0",
      "sizeKb": "sizeKb0",
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

