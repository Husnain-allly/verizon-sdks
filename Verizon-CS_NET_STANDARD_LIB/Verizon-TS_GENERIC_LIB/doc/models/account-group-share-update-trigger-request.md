
# Account Group Share Update Trigger Request

## Structure

`AccountGroupShareUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string \| undefined` | Optional | The system assigned UUID of the trigger |
| `triggerName` | `string \| undefined` | Optional | The user defined name of the trigger |
| `accountName` | `string \| undefined` | Optional | The numeric name of the account and must include leading zeroes |
| `triggerCategory` | [`TriggerCategory \| undefined`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `dataTrigger` | [`AccountGroupShareObject \| undefined`](../../doc/models/account-group-share-object.md) | Optional | - |
| `notification` | [`Notificationarray \| undefined`](../../doc/models/notificationarray.md) | Optional | - |
| `active` | [`Active \| undefined`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "accountName": "0000123456-00001",
  "active": "true",
  "triggerCategory": "AccountUsage",
  "dataTrigger": {
    "accountGroupShare": {
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
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

