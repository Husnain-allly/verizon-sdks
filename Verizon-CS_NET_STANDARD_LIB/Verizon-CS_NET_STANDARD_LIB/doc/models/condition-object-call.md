
# Condition Object Call

*This model accepts additional fields of type object.*

## Structure

`ConditionObjectCall`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConditionType` | [`ConditionType?`](../../doc/models/condition-type.md) | Optional | The condition type being monitored |
| `Comparitor` | [`Comparitor?`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To |
| `Threshold` | `int?` | Optional | The threshold value the trigger monitors for |
| `ThresholdUnit` | [`ThresholdUnit?`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `CycleType` | [`RulesCycleType?`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly |
| `AllowanceThreshold` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "conditionType": "Aging",
  "comparitor": "gt",
  "threshold": 100,
  "thresholdUnit": "KB",
  "cycleType": "Daily",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

