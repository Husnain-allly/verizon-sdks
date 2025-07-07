
# Account Level Create Trigger

## Structure

`AccountLevelCreateTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `*string` | Optional | The user defined name of the trigger |
| `EcpdId` | `*string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`*models.TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`*models.DataTrigger`](../../doc/models/data-trigger.md) | Optional | - |
| `Notification` | [`*models.Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |

## Example (as JSON)

```json
{
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "triggerCategory": "AccountUsage",
  "dataTrigger": {
    "accountLevel": {
      "filterCriteria": {
        "separateOrCombined": "separateOrCombined4",
        "accountNames": {
          "accountNameList": [
            "accountNameList7",
            "accountNameList8",
            "accountNameList9"
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
      "condition": {
        "conditionType": "Aging",
        "comparitor": "eq",
        "threshold": 98,
        "thresholdUnit": "MB",
        "cycleType": "Weekly",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "action": "suspend",
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
  "notification": {
    "notificationType": "notificationType8",
    "callback": false,
    "emailNotification": false,
    "notificationGroupName": "notificationGroupName6",
    "notificationFrequencyFactor": 22,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

