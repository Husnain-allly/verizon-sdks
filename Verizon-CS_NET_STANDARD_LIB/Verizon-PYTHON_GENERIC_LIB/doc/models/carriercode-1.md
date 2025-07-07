
# Carriercode 1

*This model accepts additional fields of type Any.*

## Structure

`Carriercode1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrier_code` | `str` | Optional | - |
| `percentage` | [`AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

