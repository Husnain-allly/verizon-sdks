
# Suspenddetailsobject

*This model accepts additional fields of type Object.*

## Structure

`Suspenddetailsobject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `SuspendFromAccounts` | `List<String>` | Optional | - | List<String> getSuspendFromAccounts() | setSuspendFromAccounts(List<String> suspendFromAccounts) |
| `SuspendDuration` | `Integer` | Optional | - | Integer getSuspendDuration() | setSuspendDuration(Integer suspendDuration) |
| `SuspendOption` | `String` | Optional | - | String getSuspendOption() | setSuspendOption(String suspendOption) |
| `Threshold` | `Integer` | Optional | The threshold value the trigger monitors for | Integer getThreshold() | setThreshold(Integer threshold) |
| `ThresholdUnit` | [`ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits | ThresholdUnit getThresholdUnit() | setThresholdUnit(ThresholdUnit thresholdUnit) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

