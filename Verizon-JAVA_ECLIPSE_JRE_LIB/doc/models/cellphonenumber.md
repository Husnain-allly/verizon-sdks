
# Cellphonenumber

*This model accepts additional fields of type Object.*

## Structure

`Cellphonenumber`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Number` | `String` | Optional | - | String getNumber() | setNumber(String number) |
| `Carrier` | `String` | Optional | - | String getCarrier() | setCarrier(String carrier) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "number": "10-digit mobile number",
  "carrier": "mobile service provider",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

