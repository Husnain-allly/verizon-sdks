
# Notify

*This model accepts additional fields of type Object.*

## Structure

`Notify`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AlertType` | `String` | Optional | - | String getAlertType() | setAlertType(String alertType) |
| `Threshold` | [`List<NotifyThreshold>`](../../doc/models/containers/notify-threshold.md) | Optional | This is List of a container for any-of cases. | List<NotifyThreshold> getThreshold() | setThreshold(List<NotifyThreshold> threshold) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

