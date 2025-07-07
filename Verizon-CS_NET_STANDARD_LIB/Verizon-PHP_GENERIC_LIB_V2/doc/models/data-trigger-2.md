
# Data Trigger 2

*This model accepts additional fields of type array.*

## Structure

`DataTrigger2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceGroup` | [`?DeviceGroupFilterCriteria`](../../doc/models/device-group-filter-criteria.md) | Optional | - | getDeviceGroup(): ?DeviceGroupFilterCriteria | setDeviceGroup(?DeviceGroupFilterCriteria deviceGroup): void |
| `conditionType` | [`?string(ConditionType)`](../../doc/models/condition-type.md) | Optional | The condition type being monitored | getConditionType(): ?string | setConditionType(?string conditionType): void |
| `comparitor` | [`?string(Comparitor)`](../../doc/models/comparitor.md) | Optional | The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To | getComparitor(): ?string | setComparitor(?string comparitor): void |
| `threshold` | `?int` | Optional | The threshold value the trigger monitors for | getThreshold(): ?int | setThreshold(?int threshold): void |
| `thresholdUnit` | [`?string(ThresholdUnit)`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits | getThresholdUnit(): ?string | setThresholdUnit(?string thresholdUnit): void |
| `cycleType` | [`?string(RulesCycleType)`](../../doc/models/rules-cycle-type.md) | Optional | The interval to monitor for the threshold. This can be Daily, Weekly or Monthly | getCycleType(): ?string | setCycleType(?string cycleType): void |
| `allowanceThreshold` | [`?AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - | getAllowanceThreshold(): ?AllowanceThreshold | setAllowanceThreshold(?AllowanceThreshold allowanceThreshold): void |
| `action` | [`?Actionobject`](../../doc/models/actionobject.md) | Optional | - | getAction(): ?Actionobject | setAction(?Actionobject action): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "conditionType": "Aging",
  "comparitor": "gt",
  "threshold": 100,
  "thresholdUnit": "KB",
  "cycleType": "Daily",
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

