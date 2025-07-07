
# Carriercode 1

*This model accepts additional fields of type Object.*

## Structure

`Carriercode1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CarrierCode` | `String` | Optional | - | String getCarrierCode() | setCarrierCode(String carrierCode) |
| `Percentage` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - | AllowanceThreshold getPercentage() | setPercentage(AllowanceThreshold percentage) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "carrierCode": "Carrier identifier code 1",
  "percentage": {
    "percentage50": false,
    "percentage75": false,
    "percentage90": false,
    "percentage100": false,
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

