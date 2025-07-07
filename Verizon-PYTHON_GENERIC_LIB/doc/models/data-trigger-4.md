
# Data Trigger 4

*This model accepts additional fields of type Any.*

## Structure

`DataTrigger4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_level` | [`AccountLevelObject`](../../doc/models/account-level-object.md) | Optional | - |
| `device_group` | [`DeviceGroupFilterCriteria`](../../doc/models/device-group-filter-criteria.md) | Optional | - |
| `condition_type` | [`ConditionType`](../../doc/models/condition-type.md) | Optional | The condition type being monitored |
| `comparitor` | [`Comparitor`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To |
| `threshold` | `int` | Optional | The threshold value the trigger monitors for |
| `threshold_unit` | [`ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `cycle_type` | [`RulesCycleType`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly |
| `allowance_threshold` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - |
| `action` | [`Actionobject`](../../doc/models/actionobject.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

