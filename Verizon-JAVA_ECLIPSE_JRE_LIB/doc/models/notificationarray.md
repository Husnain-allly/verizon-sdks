
# Notificationarray

*This model accepts additional fields of type Object.*

## Structure

`Notificationarray`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
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
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

