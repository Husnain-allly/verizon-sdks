
# Account Group Share Filter Criteria

*This model accepts additional fields of type Object.*

## Structure

`AccountGroupShareFilterCriteria`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | [`AccountGroupShareFilter`](../../doc/models/account-group-share-filter.md) | Optional | - | AccountGroupShareFilter getFilterCriteria() | setFilterCriteria(AccountGroupShareFilter filterCriteria) |
| `Condition` | [`AccountGroupShareCondition`](../../doc/models/account-group-share-condition.md) | Optional | - | AccountGroupShareCondition getCondition() | setCondition(AccountGroupShareCondition condition) |
| `Action` | [`AccountGroupShareAction`](../../doc/models/account-group-share-action.md) | Optional | - | AccountGroupShareAction getAction() | setAction(AccountGroupShareAction action) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

