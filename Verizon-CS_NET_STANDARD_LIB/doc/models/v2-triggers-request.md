
# V2 Triggers Request

*This model accepts additional fields of type object.*

## Structure

`V2TriggersRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerName` | `string` | Optional | The user defined name of the trigger |
| `EcpdId` | `string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`TriggerCategory?`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `DataTrigger` | [`DataTrigger4`](../../doc/models/data-trigger-4.md) | Optional | - |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `NotificationType` | `string` | Optional | - |
| `Callback` | `bool?` | Optional | - |
| `EmailNotification` | `bool?` | Optional | - |
| `NotificationGroupName` | `string` | Optional | - |
| `NotificationFrequencyFactor` | `int?` | Optional | - |
| `NotificationFrequencyInterval` | `string` | Optional | - |
| `ExternalEmailRecipients` | `string` | Optional | - |
| `SmsNotification` | `bool?` | Optional | - |
| `SmsNumbers` | [`List<Cellphonenumber>`](../../doc/models/cellphonenumber.md) | Optional | - |
| `Reminder` | `bool?` | Optional | - |
| `Severity` | `string` | Optional | - |
| `Active` | [`Active?`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `FilterCriteria` | [`AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - |
| `Condition` | [`Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - |
| `Action` | [`AccountLevelAction?`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met |
| `AccountName` | `string` | Optional | The numeric name of the account and must include leading zeroes |
| `PricePlanTrigger` | [`PricePlanTrigger1`](../../doc/models/price-plan-trigger-1.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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
  "action": "notify",
  "accountName": "0000123456-00001",
  "triggerCategory": "DeviceGroupUsage",
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
    "deviceGroup": {
      "filterCriteria": {
        "deviceGroupName": "deviceGroupName4",
        "IndividualOrCombined": "IndividualOrCombined4",
        "accountName": "accountName0",
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
    "conditionType": "Aging",
    "comparitor": "eq",
    "threshold": 222,
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

