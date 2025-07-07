
# Account Share Price Plan Trigger

*This model accepts additional fields of type interface{}.*

## Structure

`AccountSharePricePlanTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountShare` | [`*models.AccountShareFilterCriteria`](../../doc/models/account-share-filter-criteria.md) | Optional | - |
| `Condition` | [`*models.Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - |
| `ChangePlan` | `*bool` | Optional | a flag to set if the trigger changes service plans, true, or not, false |
| `ChangePlanDetails` | [`*models.ChangePlanDetails`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "changePlan": true,
  "accountShare": {
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
}
```

