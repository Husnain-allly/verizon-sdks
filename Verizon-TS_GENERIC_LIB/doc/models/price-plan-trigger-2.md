
# Price Plan Trigger 2

*This model accepts additional fields of type unknown.*

## Structure

`PricePlanTrigger2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountShare` | [`AccountShareFilterCriteria \| undefined`](../../doc/models/account-share-filter-criteria.md) | Optional | - |
| `condition` | [`Rateplantype2Condition \| undefined`](../../doc/models/rateplantype-2-condition.md) | Optional | - |
| `changePlan` | `boolean \| undefined` | Optional | a flag to set if the trigger changes service plans, true, or not, false |
| `changePlanDetails` | [`ChangePlanDetails \| undefined`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to |
| `payAsYouGo` | [`PayAsYouGoFilterCriteria \| undefined`](../../doc/models/pay-as-you-go-filter-criteria.md) | Optional | - |
| `action` | [`Actionobject \| undefined`](../../doc/models/actionobject.md) | Optional | - |
| `standAlone` | [`FiltercriteriaObjectCall \| undefined`](../../doc/models/filtercriteria-object-call.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

