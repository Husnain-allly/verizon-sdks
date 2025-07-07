
# Promo Alert Trigger Request

## Structure

`PromoAlertTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DataPercentage50` | `Boolean` | Optional | - | Boolean getDataPercentage50() | setDataPercentage50(Boolean dataPercentage50) |
| `DataPercentage75` | `Boolean` | Optional | - | Boolean getDataPercentage75() | setDataPercentage75(Boolean dataPercentage75) |
| `DataPercentage90` | `Boolean` | Optional | - | Boolean getDataPercentage90() | setDataPercentage90(Boolean dataPercentage90) |
| `NoOfDaysB4PromoExp` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 180` | Integer getNoOfDaysB4PromoExp() | setNoOfDaysB4PromoExp(Integer noOfDaysB4PromoExp) |
| `SmsPercentage50` | `Boolean` | Optional | - | Boolean getSmsPercentage50() | setSmsPercentage50(Boolean smsPercentage50) |
| `SmsPercentage75` | `Boolean` | Optional | - | Boolean getSmsPercentage75() | setSmsPercentage75(Boolean smsPercentage75) |
| `SmsPercentage90` | `Boolean` | Optional | - | Boolean getSmsPercentage90() | setSmsPercentage90(Boolean smsPercentage90) |

## Example (as JSON)

```json
{
  "dataPercentage50": false,
  "dataPercentage75": false,
  "dataPercentage90": false,
  "noOfDaysB4PromoExp": 166,
  "smsPercentage50": false
}
```

