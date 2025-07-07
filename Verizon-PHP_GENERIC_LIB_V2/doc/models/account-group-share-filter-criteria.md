
# Account Group Share Filter Criteria

*This model accepts additional fields of type array.*

## Structure

`AccountGroupShareFilterCriteria`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `filterCriteria` | [`?AccountGroupShareFilter`](../../doc/models/account-group-share-filter.md) | Optional | - | getFilterCriteria(): ?AccountGroupShareFilter | setFilterCriteria(?AccountGroupShareFilter filterCriteria): void |
| `condition` | [`?AccountGroupShareCondition`](../../doc/models/account-group-share-condition.md) | Optional | - | getCondition(): ?AccountGroupShareCondition | setCondition(?AccountGroupShareCondition condition): void |
| `action` | [`?AccountGroupShareAction`](../../doc/models/account-group-share-action.md) | Optional | - | getAction(): ?AccountGroupShareAction | setAction(?AccountGroupShareAction action): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

