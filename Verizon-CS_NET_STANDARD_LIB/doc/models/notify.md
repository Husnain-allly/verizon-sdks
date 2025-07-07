
# Notify

*This model accepts additional fields of type object.*

## Structure

`Notify`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AlertType` | `string` | Optional | - |
| `Threshold` | [`List<Carriercode1>`](../../doc/models/carriercode-1.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "alertType": "individualpriceplan",
  "threshold": [
    {
      "carrierCode": "carrierCode4",
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
    },
    {
      "carrierCode": "carrierCode4",
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
    },
    {
      "carrierCode": "carrierCode4",
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

