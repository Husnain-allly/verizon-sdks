
# Account Level Update Trigger Request

## Structure

`AccountLevelUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerId` | `String` | Optional | The system assigned UUID of the trigger | String getTriggerId() | setTriggerId(String triggerId) |
| `TriggerName` | `String` | Optional | The user defined name of the trigger | String getTriggerName() | setTriggerName(String triggerName) |
| `EcpdId` | `String` | Optional | The Enterprise Customer Profile Database ID | String getEcpdId() | setEcpdId(String ecpdId) |
| `TriggerCategory` | [`TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | TriggerCategory getTriggerCategory() | setTriggerCategory(TriggerCategory triggerCategory) |
| `DataTrigger` | [`DataTrigger1`](../../doc/models/data-trigger-1.md) | Optional | - | DataTrigger1 getDataTrigger() | setDataTrigger(DataTrigger1 dataTrigger) |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - | Notificationarray getNotification() | setNotification(Notificationarray notification) |
| `NotificationType` | `String` | Optional | - | String getNotificationType() | setNotificationType(String notificationType) |
| `Callback` | `Boolean` | Optional | - | Boolean getCallback() | setCallback(Boolean callback) |
| `EmailNotification` | `Boolean` | Optional | - | Boolean getEmailNotification() | setEmailNotification(Boolean emailNotification) |
| `NotificationGroupName` | `String` | Optional | - | String getNotificationGroupName() | setNotificationGroupName(String notificationGroupName) |
| `NotificationFrequencyFactor` | `Integer` | Optional | - | Integer getNotificationFrequencyFactor() | setNotificationFrequencyFactor(Integer notificationFrequencyFactor) |
| `NotificationFrequencyInterval` | `String` | Optional | - | String getNotificationFrequencyInterval() | setNotificationFrequencyInterval(String notificationFrequencyInterval) |
| `ExternalEmailRecipients` | `String` | Optional | - | String getExternalEmailRecipients() | setExternalEmailRecipients(String externalEmailRecipients) |
| `SmsNotification` | `Boolean` | Optional | - | Boolean getSmsNotification() | setSmsNotification(Boolean smsNotification) |
| `SmsNumbers` | [`List<AccountLevelUpdateTriggerRequestSmsNumbers>`](../../doc/models/containers/account-level-update-trigger-request-sms-numbers.md) | Optional | This is List of a container for any-of cases. | List<AccountLevelUpdateTriggerRequestSmsNumbers> getSmsNumbers() | setSmsNumbers(List<AccountLevelUpdateTriggerRequestSmsNumbers> smsNumbers) |
| `Reminder` | `Boolean` | Optional | - | Boolean getReminder() | setReminder(Boolean reminder) |
| `Severity` | `String` | Optional | - | String getSeverity() | setSeverity(String severity) |
| `Active` | [`Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false | Active getActive() | setActive(Active active) |

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
    "condition": "UsageAllowance",
    "action": "notify",
    "conditionType": "Aging",
    "comparitor": "eq",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

