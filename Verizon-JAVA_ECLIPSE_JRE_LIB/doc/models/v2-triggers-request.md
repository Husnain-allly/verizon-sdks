
# V2 Triggers Request

*This model accepts additional fields of type Object.*

## Structure

`V2TriggersRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerName` | `String` | Optional | The user defined name of the trigger | String getTriggerName() | setTriggerName(String triggerName) |
| `EcpdId` | `String` | Optional | The Enterprise Customer Profile Database ID | String getEcpdId() | setEcpdId(String ecpdId) |
| `TriggerCategory` | [`TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | TriggerCategory getTriggerCategory() | setTriggerCategory(TriggerCategory triggerCategory) |
| `DataTrigger` | [`DataTrigger4`](../../doc/models/data-trigger-4.md) | Optional | - | DataTrigger4 getDataTrigger() | setDataTrigger(DataTrigger4 dataTrigger) |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - | Notificationarray getNotification() | setNotification(Notificationarray notification) |
| `NotificationType` | `String` | Optional | - | String getNotificationType() | setNotificationType(String notificationType) |
| `Callback` | `Boolean` | Optional | - | Boolean getCallback() | setCallback(Boolean callback) |
| `EmailNotification` | `Boolean` | Optional | - | Boolean getEmailNotification() | setEmailNotification(Boolean emailNotification) |
| `NotificationGroupName` | `String` | Optional | - | String getNotificationGroupName() | setNotificationGroupName(String notificationGroupName) |
| `NotificationFrequencyFactor` | `Integer` | Optional | - | Integer getNotificationFrequencyFactor() | setNotificationFrequencyFactor(Integer notificationFrequencyFactor) |
| `NotificationFrequencyInterval` | `String` | Optional | - | String getNotificationFrequencyInterval() | setNotificationFrequencyInterval(String notificationFrequencyInterval) |
| `ExternalEmailRecipients` | `String` | Optional | - | String getExternalEmailRecipients() | setExternalEmailRecipients(String externalEmailRecipients) |
| `SmsNotification` | `Boolean` | Optional | - | Boolean getSmsNotification() | setSmsNotification(Boolean smsNotification) |
| `SmsNumbers` | [`List<Cellphonenumber>`](../../doc/models/cellphonenumber.md) | Optional | - | List<Cellphonenumber> getSmsNumbers() | setSmsNumbers(List<Cellphonenumber> smsNumbers) |
| `Reminder` | `Boolean` | Optional | - | Boolean getReminder() | setReminder(Boolean reminder) |
| `Severity` | `String` | Optional | - | String getSeverity() | setSeverity(String severity) |
| `Active` | [`Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false | Active getActive() | setActive(Active active) |
| `FilterCriteria` | [`AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - | AccountLevelFilter getFilterCriteria() | setFilterCriteria(AccountLevelFilter filterCriteria) |
| `Condition` | [`Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - | Rateplantype2Condition getCondition() | setCondition(Rateplantype2Condition condition) |
| `Action` | [`AccountLevelAction`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met | AccountLevelAction getAction() | setAction(AccountLevelAction action) |
| `AccountName` | `String` | Optional | The numeric name of the account and must include leading zeroes | String getAccountName() | setAccountName(String accountName) |
| `PricePlanTrigger` | [`PricePlanTrigger1`](../../doc/models/price-plan-trigger-1.md) | Optional | - | PricePlanTrigger1 getPricePlanTrigger() | setPricePlanTrigger(PricePlanTrigger1 pricePlanTrigger) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

