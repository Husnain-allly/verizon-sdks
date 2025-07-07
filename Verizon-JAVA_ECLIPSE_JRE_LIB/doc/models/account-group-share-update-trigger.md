
# Account Group Share Update Trigger

## Structure

`AccountGroupShareUpdateTrigger`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerId` | `String` | Optional | The system assigned UUID of the trigger | String getTriggerId() | setTriggerId(String triggerId) |
| `TriggerName` | `String` | Optional | The user defined name of the trigger | String getTriggerName() | setTriggerName(String triggerName) |
| `AccountName` | `String` | Optional | The numeric name of the account and must include leading zeroes | String getAccountName() | setAccountName(String accountName) |
| `TriggerCategory` | [`TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | TriggerCategory getTriggerCategory() | setTriggerCategory(TriggerCategory triggerCategory) |
| `DataTrigger` | [`AccountGroupShareObject`](../../doc/models/account-group-share-object.md) | Optional | - | AccountGroupShareObject getDataTrigger() | setDataTrigger(AccountGroupShareObject dataTrigger) |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - | Notificationarray getNotification() | setNotification(Notificationarray notification) |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "accountName": "0000123456-00001",
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

