
# Carriercode 1

*This model accepts additional fields of type object.*

## Structure

`Carriercode1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarrierCode` | `string` | Optional | - |
| `Percentage` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

