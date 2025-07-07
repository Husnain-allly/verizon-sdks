
# Data Trigger Request

## Structure

`DataTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Comparator` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getComparator() | setComparator(String comparator) |
| `Threshold` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 100` | Integer getThreshold() | setThreshold(Integer threshold) |
| `ThresholdUnit` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getThresholdUnit() | setThresholdUnit(String thresholdUnit) |

## Example (as JSON)

```json
{
  "comparator": "comparator0",
  "threshold": 22,
  "thresholdUnit": "thresholdUnit8"
}
```

