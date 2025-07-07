
# Data Trigger 4

*This model accepts additional fields of type interface{}.*

## Structure

`DataTrigger4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountLevel` | [`*models.AccountLevelObject`](../../doc/models/account-level-object.md) | Optional | - |
| `DeviceGroup` | [`*models.DeviceGroupFilterCriteria`](../../doc/models/device-group-filter-criteria.md) | Optional | - |
| `ConditionType` | [`*models.ConditionType`](../../doc/models/condition-type.md) | Optional | The condition type being monitored |
| `Comparitor` | [`*models.Comparitor`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To |
| `Threshold` | `*int` | Optional | The threshold value the trigger monitors for |
| `ThresholdUnit` | [`*models.ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `CycleType` | [`*models.RulesCycleType`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly |
| `AllowanceThreshold` | [`*models.AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - |
| `Action` | [`*models.Actionobject`](../../doc/models/actionobject.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "conditionType": "Aging",
  "comparitor": "gt",
  "threshold": 100,
  "thresholdUnit": "KB",
  "cycleType": "Daily",
  "accountLevel": {
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
    "action": "suspend",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "deviceGroup": {
    "filterCriteria": {
      "deviceGroupName": "deviceGroupName4",
      "IndividualOrCombined": "IndividualOrCombined4",
      "accountName": "accountName0",
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

