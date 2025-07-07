
# Keyschunk 2

*This model accepts additional fields of type Object.*

## Structure

`Keyschunk2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DataPercentage50` | `Boolean` | Optional | - | Boolean getDataPercentage50() | setDataPercentage50(Boolean dataPercentage50) |
| `DataPercentage75` | `Boolean` | Optional | - | Boolean getDataPercentage75() | setDataPercentage75(Boolean dataPercentage75) |
| `DataPercentage90` | `Boolean` | Optional | - | Boolean getDataPercentage90() | setDataPercentage90(Boolean dataPercentage90) |
| `DataPercentage100` | `Boolean` | Optional | - | Boolean getDataPercentage100() | setDataPercentage100(Boolean dataPercentage100) |
| `SmsPercentage50` | `Boolean` | Optional | - | Boolean getSmsPercentage50() | setSmsPercentage50(Boolean smsPercentage50) |
| `SmsPercentage75` | `Boolean` | Optional | - | Boolean getSmsPercentage75() | setSmsPercentage75(Boolean smsPercentage75) |
| `SmsPercentage90` | `Boolean` | Optional | - | Boolean getSmsPercentage90() | setSmsPercentage90(Boolean smsPercentage90) |
| `SmsPercentage100` | `Boolean` | Optional | - | Boolean getSmsPercentage100() | setSmsPercentage100(Boolean smsPercentage100) |
| `NoOfDaysB4PromoExp` | `Integer` | Optional | - | Integer getNoOfDaysB4PromoExp() | setNoOfDaysB4PromoExp(Integer noOfDaysB4PromoExp) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "dataPercentage50": false,
  "dataPercentage75": false,
  "dataPercentage90": false,
  "dataPercentage100": false,
  "smsPercentage50": false,
  "smsPercentage75": false,
  "smsPercentage90": false,
  "smsPercentage100": true,
  "NoOfDaysB4PromoExp": 5,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

