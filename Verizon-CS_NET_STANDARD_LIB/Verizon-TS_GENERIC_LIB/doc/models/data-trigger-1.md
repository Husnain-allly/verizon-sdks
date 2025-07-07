
# Data Trigger 1

*This model accepts additional fields of type unknown.*

## Structure

`DataTrigger1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filterCriteria` | [`AccountLevelFilter \| undefined`](../../doc/models/account-level-filter.md) | Optional | - |
| `condition` | [`DataTrigger1Condition \| undefined`](../../doc/models/containers/data-trigger-1-condition.md) | Optional | This is a container for any-of cases. |
| `action` | [`AccountLevelAction \| undefined`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met |
| `conditionType` | [`ConditionType \| undefined`](../../doc/models/condition-type.md) | Optional | The condition type being monitored |
| `comparitor` | [`Comparitor \| undefined`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To |
| `threshold` | `number \| undefined` | Optional | The threshold value the trigger monitors for |
| `thresholdUnit` | [`ThresholdUnit \| undefined`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `cycleType` | [`RulesCycleType \| undefined`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly |
| `allowanceThreshold` | [`AllowanceThreshold \| undefined`](../../doc/models/allowance-threshold.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "action": "notify",
  "conditionType": "Aging",
  "comparitor": "gt",
  "threshold": 100,
  "thresholdUnit": "KB",
  "cycleType": "Daily",
  "filterCriteria": {
    "separateOrCombined": "separateOrCombined4",
    "accountNames": {
      "accountNameList": [
        "accountNameList7",
        "accountNameList8",
        "accountNameList9"
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
  "condition": "Aging",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

