
# Account Level Create Trigger Request

## Structure

`AccountLevelCreateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `*string` | Optional | The user defined name of the trigger |
| `EcpdId` | `*string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`*models.TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`*models.DataTrigger`](../../doc/models/data-trigger.md) | Optional | - |
| `Notification` | [`*models.Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `NotificationType` | `*string` | Optional | - |
| `Callback` | `*bool` | Optional | - |
| `EmailNotification` | `*bool` | Optional | - |
| `NotificationGroupName` | `*string` | Optional | - |
| `NotificationFrequencyFactor` | `*int` | Optional | - |
| `NotificationFrequencyInterval` | `*string` | Optional | - |
| `ExternalEmailRecipients` | `*string` | Optional | - |
| `SmsNotification` | `*bool` | Optional | - |
| `SmsNumbers` | [`[]models.Cellphonenumber`](../../doc/models/cellphonenumber.md) | Optional | - |
| `Reminder` | `*bool` | Optional | - |
| `Severity` | `*string` | Optional | - |
| `Active` | [`*models.Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

## Example (as JSON)

```json
{
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "notificationType": "PerEvent",
  "callback": true,
  "emailNotification": false,
  "notificationGroupName": "Notification Group Name (User defined)",
  "notificationFrequencyFactor": 3,
  "notificationFrequencyInterval": "Daily",
  "externalEmailRecipients": "Email addresses",
  "smsNotification": true,
  "reminder": true,
  "severity": "Notify",
  "active": "true",
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

