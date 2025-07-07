
# Sms Trigger Request

## Structure

`SmsTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Comparator` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getComparator() | setComparator(String comparator) |
| `SmsType` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getSmsType() | setSmsType(String smsType) |
| `Threshold` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 100` | Integer getThreshold() | setThreshold(Integer threshold) |

## Example (as JSON)

```json
{
  "comparator": "comparator0",
  "smsType": "smsType6",
  "threshold": 100
}
```

