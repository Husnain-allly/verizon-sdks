
# Pay as You Go Price Plan Trigger

*This model accepts additional fields of type Object.*

## Structure

`PayAsYouGoPricePlanTrigger`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `PayAsYouGo` | [`PayAsYouGoFilterCriteria`](../../doc/models/pay-as-you-go-filter-criteria.md) | Optional | - | PayAsYouGoFilterCriteria getPayAsYouGo() | setPayAsYouGo(PayAsYouGoFilterCriteria payAsYouGo) |
| `Condition` | [`Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - | Rateplantype2Condition getCondition() | setCondition(Rateplantype2Condition condition) |
| `Action` | [`Actionobject`](../../doc/models/actionobject.md) | Optional | - | Actionobject getAction() | setAction(Actionobject action) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "payAsYouGo": {
    "filterCriteria": {
      "carrierServicePlanCode": "carrierServicePlanCode4",
      "accountNameList": [
        "accountNameList7",
        "accountNameList8"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "condition": {
    "conditionType": "Aging",
    "comparitor": "eq",
    "threshold": 98,
    "thresholdUnit": "MB",
    "cycleType": "Weekly",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "action": {
    "suspend": false,
    "suspendDetails": {
      "suspendFromAccounts": [
        "suspendFromAccounts7"
      ],
      "suspendDuration": 152,
      "suspendOption": "suspendOption2",
      "threshold": 166,
      "thresholdUnit": "GB",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "changePlan": false,
    "changePlanDetails": {
      "toCarrierServicePlanCode": "toCarrierServicePlanCode2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

