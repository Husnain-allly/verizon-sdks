
# Price Plan Trigger 2

*This model accepts additional fields of type array.*

## Structure

`PricePlanTrigger2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountShare` | [`?AccountShareFilterCriteria`](../../doc/models/account-share-filter-criteria.md) | Optional | - | getAccountShare(): ?AccountShareFilterCriteria | setAccountShare(?AccountShareFilterCriteria accountShare): void |
| `condition` | [`?Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - | getCondition(): ?Rateplantype2Condition | setCondition(?Rateplantype2Condition condition): void |
| `changePlan` | `?bool` | Optional | a flag to set if the trigger changes service plans, true, or not, false | getChangePlan(): ?bool | setChangePlan(?bool changePlan): void |
| `changePlanDetails` | [`?ChangePlanDetails`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to | getChangePlanDetails(): ?ChangePlanDetails | setChangePlanDetails(?ChangePlanDetails changePlanDetails): void |
| `payAsYouGo` | [`?PayAsYouGoFilterCriteria`](../../doc/models/pay-as-you-go-filter-criteria.md) | Optional | - | getPayAsYouGo(): ?PayAsYouGoFilterCriteria | setPayAsYouGo(?PayAsYouGoFilterCriteria payAsYouGo): void |
| `action` | [`?Actionobject`](../../doc/models/actionobject.md) | Optional | - | getAction(): ?Actionobject | setAction(?Actionobject action): void |
| `standAlone` | [`?FiltercriteriaObjectCall`](../../doc/models/filtercriteria-object-call.md) | Optional | - | getStandAlone(): ?FiltercriteriaObjectCall | setStandAlone(?FiltercriteriaObjectCall standAlone): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

