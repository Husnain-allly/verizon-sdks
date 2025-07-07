
# Keyschunk 2

*This model accepts additional fields of type Object.*

## Structure

`Keyschunk2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `data_percentage_50` | `TrueClass \| FalseClass` | Optional | - |
| `data_percentage_75` | `TrueClass \| FalseClass` | Optional | - |
| `data_percentage_90` | `TrueClass \| FalseClass` | Optional | - |
| `data_percentage_100` | `TrueClass \| FalseClass` | Optional | - |
| `sms_percentage_50` | `TrueClass \| FalseClass` | Optional | - |
| `sms_percentage_75` | `TrueClass \| FalseClass` | Optional | - |
| `sms_percentage_90` | `TrueClass \| FalseClass` | Optional | - |
| `sms_percentage_100` | `TrueClass \| FalseClass` | Optional | - |
| `no_of_days_b_4_promo_exp` | `Integer` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

