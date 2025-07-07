
# Account Group Share Individual 1

*This model accepts additional fields of type array.*

## Structure

`AccountGroupShareIndividual1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountGroupShareIndividual` | [`?AccountGroupShareFilterCriteria`](../../doc/models/account-group-share-filter-criteria.md) | Optional | - | getAccountGroupShareIndividual(): ?AccountGroupShareFilterCriteria | setAccountGroupShareIndividual(?AccountGroupShareFilterCriteria accountGroupShareIndividual): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

