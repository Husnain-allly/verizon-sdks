
# Data Trigger 5

*This model accepts additional fields of type Object.*

## Structure

`DataTrigger5`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | [`AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - | AccountLevelFilter getFilterCriteria() | setFilterCriteria(AccountLevelFilter filterCriteria) |
| `Condition` | [`Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - | Rateplantype2Condition getCondition() | setCondition(Rateplantype2Condition condition) |
| `Action` | [`AccountLevelAction`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met | AccountLevelAction getAction() | setAction(AccountLevelAction action) |
| `ConditionType` | [`ConditionType`](../../doc/models/condition-type.md) | Optional | The condition type being monitored | ConditionType getConditionType() | setConditionType(ConditionType conditionType) |
| `Comparitor` | [`Comparitor`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To | Comparitor getComparitor() | setComparitor(Comparitor comparitor) |
| `Threshold` | `Integer` | Optional | The threshold value the trigger monitors for | Integer getThreshold() | setThreshold(Integer threshold) |
| `ThresholdUnit` | [`ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits | ThresholdUnit getThresholdUnit() | setThresholdUnit(ThresholdUnit thresholdUnit) |
| `CycleType` | [`RulesCycleType`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly | RulesCycleType getCycleType() | setCycleType(RulesCycleType cycleType) |
| `AllowanceThreshold` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - | AllowanceThreshold getAllowanceThreshold() | setAllowanceThreshold(AllowanceThreshold allowanceThreshold) |
| `DeviceGroup` | [`DeviceGroupFilterCriteria`](../../doc/models/device-group-filter-criteria.md) | Optional | - | DeviceGroupFilterCriteria getDeviceGroup() | setDeviceGroup(DeviceGroupFilterCriteria deviceGroup) |
| `AccountGroupShare` | [`AccountGroupShareIndividual1`](../../doc/models/account-group-share-individual-1.md) | Optional | - | AccountGroupShareIndividual1 getAccountGroupShare() | setAccountGroupShare(AccountGroupShareIndividual1 accountGroupShare) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

