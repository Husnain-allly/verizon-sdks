
# Rateplan

*This model accepts additional fields of type Any.*

## Structure

`Rateplan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `rate_plan_group` | List[[rateplantypeObject](../../doc/models/rateplantype-object.md) \| [rateplantype2](../../doc/models/rateplantype-2.md)] \| None | Optional | This is List of a container for any-of cases. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

