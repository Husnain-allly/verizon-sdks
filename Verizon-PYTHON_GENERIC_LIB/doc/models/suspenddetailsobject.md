
# Suspenddetailsobject

*This model accepts additional fields of type Any.*

## Structure

`Suspenddetailsobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `suspend_from_accounts` | `List[str]` | Optional | - |
| `suspend_duration` | `int` | Optional | - |
| `suspend_option` | `str` | Optional | - |
| `threshold` | `int` | Optional | The threshold value the trigger monitors for |
| `threshold_unit` | [`ThresholdUnit`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

