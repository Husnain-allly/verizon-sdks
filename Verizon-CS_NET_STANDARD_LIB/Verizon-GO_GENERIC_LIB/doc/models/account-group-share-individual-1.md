
# Account Group Share Individual 1

*This model accepts additional fields of type interface{}.*

## Structure

`AccountGroupShareIndividual1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountGroupShareIndividual` | [`*models.AccountGroupShareFilterCriteria`](../../doc/models/account-group-share-filter-criteria.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountGroupShareIndividual": {
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

