
# Keyschunk 2

*This model accepts additional fields of type interface{}.*

## Structure

`Keyschunk2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DataPercentage50` | `*bool` | Optional | - |
| `DataPercentage75` | `*bool` | Optional | - |
| `DataPercentage90` | `*bool` | Optional | - |
| `DataPercentage100` | `*bool` | Optional | - |
| `SmsPercentage50` | `*bool` | Optional | - |
| `SmsPercentage75` | `*bool` | Optional | - |
| `SmsPercentage90` | `*bool` | Optional | - |
| `SmsPercentage100` | `*bool` | Optional | - |
| `NoOfDaysB4PromoExp` | `*int` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

