
# Account Group Share Action

*This model accepts additional fields of type unknown.*

## Structure

`AccountGroupShareAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `notify` | [`Notify \| undefined`](../../doc/models/notify.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

