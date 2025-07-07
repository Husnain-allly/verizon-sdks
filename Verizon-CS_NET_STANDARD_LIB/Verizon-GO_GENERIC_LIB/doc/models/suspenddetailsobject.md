
# Suspenddetailsobject

*This model accepts additional fields of type interface{}.*

## Structure

`Suspenddetailsobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuspendFromAccounts` | `[]string` | Optional | - |
| `SuspendDuration` | `*int` | Optional | - |
| `SuspendOption` | `*string` | Optional | - |
| `Threshold` | `*int` | Optional | The threshold value the trigger monitors for |
| `ThresholdUnit` | [`*models.ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "suspendDuration": 90,
  "suspendOption": "withBilling",
  "threshold": 100,
  "thresholdUnit": "KB",
  "suspendFromAccounts": [
    "suspendFromAccounts7",
    "suspendFromAccounts8",
    "suspendFromAccounts9"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

