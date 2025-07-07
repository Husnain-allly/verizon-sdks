
# Account Group Share Action

*This model accepts additional fields of type Object.*

## Structure

`AccountGroupShareAction`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Notify` | [`Notify`](../../doc/models/notify.md) | Optional | - | Notify getNotify() | setNotify(Notify notify) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

