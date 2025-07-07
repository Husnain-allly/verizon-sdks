
# Account Group Share Individual 1

*This model accepts additional fields of type Any.*

## Structure

`AccountGroupShareIndividual1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_group_share_individual` | [`AccountGroupShareFilterCriteria`](../../doc/models/account-group-share-filter-criteria.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

