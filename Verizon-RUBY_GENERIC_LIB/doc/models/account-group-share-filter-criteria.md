
# Account Group Share Filter Criteria

*This model accepts additional fields of type Object.*

## Structure

`AccountGroupShareFilterCriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter_criteria` | [`AccountGroupShareFilter`](../../doc/models/account-group-share-filter.md) | Optional | - |
| `condition` | [`AccountGroupShareCondition`](../../doc/models/account-group-share-condition.md) | Optional | - |
| `action` | [`AccountGroupShareAction`](../../doc/models/account-group-share-action.md) | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "filterCriteria": {
    "ratePlanGroupId": 202,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "condition": {
    "action": "notify",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "action": {
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

