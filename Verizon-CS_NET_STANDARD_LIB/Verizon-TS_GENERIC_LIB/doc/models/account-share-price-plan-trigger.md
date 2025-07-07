
# Account Share Price Plan Trigger

*This model accepts additional fields of type unknown.*

## Structure

`AccountSharePricePlanTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountShare` | [`AccountShareFilterCriteria \| undefined`](../../doc/models/account-share-filter-criteria.md) | Optional | - |
| `condition` | [`AccountSharePricePlanTriggerCondition \| undefined`](../../doc/models/containers/account-share-price-plan-trigger-condition.md) | Optional | This is a container for any-of cases. |
| `changePlan` | `boolean \| undefined` | Optional | a flag to set if the trigger changes service plans, true, or not, false |
| `changePlanDetails` | [`ChangePlanDetails \| undefined`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to |
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
  "condition": "UsageAllowance",
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

