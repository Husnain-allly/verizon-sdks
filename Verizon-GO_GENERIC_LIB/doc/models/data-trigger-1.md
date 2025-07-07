
# Data Trigger 1

*This model accepts additional fields of type interface{}.*

## Structure

`DataTrigger1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`*models.AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - |
| `Condition` | [`*models.Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - |
| `Action` | [`*models.AccountLevelAction`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met |
| `ConditionType` | [`*models.ConditionType`](../../doc/models/condition-type.md) | Optional | The condition type being monitored |
| `Comparitor` | [`*models.Comparitor`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To |
| `Threshold` | `*int` | Optional | The threshold value the trigger monitors for |
| `ThresholdUnit` | [`*models.ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `CycleType` | [`*models.RulesCycleType`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly |
| `AllowanceThreshold` | [`*models.AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

