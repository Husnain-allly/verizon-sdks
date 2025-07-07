
# Sms Number

Notification SMS details.

*This model accepts additional fields of type Object.*

## Structure

`SmsNumber`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Carrier` | `String` | Optional | - | String getCarrier() | setCarrier(String carrier) |
| `Number` | `String` | Optional | - | String getNumber() | setNumber(String number) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "carrier": "US Cellular",
  "number": "9299280711",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

