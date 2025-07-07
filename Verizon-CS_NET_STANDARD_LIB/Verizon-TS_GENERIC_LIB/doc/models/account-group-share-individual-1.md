
# Account Group Share Individual 1

*This model accepts additional fields of type unknown.*

## Structure

`AccountGroupShareIndividual1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountGroupShareIndividual` | [`AccountGroupShareFilterCriteria \| undefined`](../../doc/models/account-group-share-filter-criteria.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

