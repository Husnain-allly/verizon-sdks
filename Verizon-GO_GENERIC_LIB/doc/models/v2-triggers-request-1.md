
# V2 Triggers Request 1

*This model accepts additional fields of type interface{}.*

## Structure

`V2TriggersRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `*string` | Optional | The system assigned UUID of the trigger |
| `TriggerName` | `*string` | Optional | The user defined name of the trigger |
| `EcpdId` | `*string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`*models.TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`*models.DataTrigger5`](../../doc/models/data-trigger-5.md) | Optional | - |
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
| `AccountName` | `*string` | Optional | The numeric name of the account and must include leading zeroes |
| `PricePlanTrigger` | [`*models.PricePlanTrigger2`](../../doc/models/price-plan-trigger-2.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
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
  "accountName": "0000123456-00001",
  "triggerCategory": "DeviceGroupUsage",
  "dataTrigger": {
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
    "action": "notify",
    "conditionType": "Aging",
    "comparitor": "eq",
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

