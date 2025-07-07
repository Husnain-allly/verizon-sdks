
# Rateplantype 2 Condition

*This model accepts additional fields of type Object.*

## Structure

`Rateplantype2Condition`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ConditionType` | [`ConditionType`](../../doc/models/condition-type.md) | Optional | The condition type being monitored | ConditionType getConditionType() | setConditionType(ConditionType conditionType) |
| `Comparitor` | [`Comparitor`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To | Comparitor getComparitor() | setComparitor(Comparitor comparitor) |
| `Threshold` | `Integer` | Optional | The threshold value the trigger monitors for | Integer getThreshold() | setThreshold(Integer threshold) |
| `ThresholdUnit` | [`ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits | ThresholdUnit getThresholdUnit() | setThresholdUnit(ThresholdUnit thresholdUnit) |
| `CycleType` | [`RulesCycleType`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly | RulesCycleType getCycleType() | setCycleType(RulesCycleType cycleType) |
| `AllowanceThreshold` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - | AllowanceThreshold getAllowanceThreshold() | setAllowanceThreshold(AllowanceThreshold allowanceThreshold) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

