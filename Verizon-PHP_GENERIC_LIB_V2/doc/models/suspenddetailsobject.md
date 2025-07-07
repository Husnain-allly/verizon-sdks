
# Suspenddetailsobject

*This model accepts additional fields of type array.*

## Structure

`Suspenddetailsobject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `suspendFromAccounts` | `?(string[])` | Optional | - | getSuspendFromAccounts(): ?array | setSuspendFromAccounts(?array suspendFromAccounts): void |
| `suspendDuration` | `?int` | Optional | - | getSuspendDuration(): ?int | setSuspendDuration(?int suspendDuration): void |
| `suspendOption` | `?string` | Optional | - | getSuspendOption(): ?string | setSuspendOption(?string suspendOption): void |
| `threshold` | `?int` | Optional | The threshold value the trigger monitors for | getThreshold(): ?int | setThreshold(?int threshold): void |
| `thresholdUnit` | [`?string(ThresholdUnit)`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits | getThresholdUnit(): ?string | setThresholdUnit(?string thresholdUnit): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

