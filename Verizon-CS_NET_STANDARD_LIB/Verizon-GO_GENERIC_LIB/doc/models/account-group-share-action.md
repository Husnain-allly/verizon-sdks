
# Account Group Share Action

*This model accepts additional fields of type interface{}.*

## Structure

`AccountGroupShareAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Notify` | [`*models.Notify`](../../doc/models/notify.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "notify": {
    "alertType": "alertType8",
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

