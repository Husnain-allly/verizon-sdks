
# Rateplantype 2 Condition

*This model accepts additional fields of type unknown.*

## Structure

`Rateplantype2Condition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
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

