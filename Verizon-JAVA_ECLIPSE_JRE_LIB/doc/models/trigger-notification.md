
# Trigger Notification

The notification details of the trigger.

## Structure

`TriggerNotification`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `NotificationType` | `String` | Optional | The type of notification, i.e. 'DailySummary'. | String getNotificationType() | setNotificationType(String notificationType) |
| `Callback` | `Boolean` | Optional | Whether or not the notification should be sent via callback.<br />true<br />false. | Boolean getCallback() | setCallback(Boolean callback) |
| `EmailNotification` | `Boolean` | Optional | Whether or not the notification should be sent via e-mail.<br />true<br />false. | Boolean getEmailNotification() | setEmailNotification(Boolean emailNotification) |
| `NotificationGroupName` | `String` | Optional | Name for the notification group. | String getNotificationGroupName() | setNotificationGroupName(String notificationGroupName) |
| `NotificationFrequencyFactor` | `Integer` | Optional | Frequency factor for notification. | Integer getNotificationFrequencyFactor() | setNotificationFrequencyFactor(Integer notificationFrequencyFactor) |
| `NotificationFrequencyInterval` | `String` | Optional | Frequency interval for notification. | String getNotificationFrequencyInterval() | setNotificationFrequencyInterval(String notificationFrequencyInterval) |
| `ExternalEmailRecipients` | `String` | Optional | E-mail address(es) where the notification should be delivered. | String getExternalEmailRecipients() | setExternalEmailRecipients(String externalEmailRecipients) |
| `SmsNotification` | `Boolean` | Optional | SMS notification. | Boolean getSmsNotification() | setSmsNotification(Boolean smsNotification) |
| `SmsNumbers` | [`List<SmsNumber>`](../../doc/models/sms-number.md) | Optional | List of SMS numbers.<br><br>**Constraints**: *Maximum Items*: `10` | List<SmsNumber> getSmsNumbers() | setSmsNumbers(List<SmsNumber> smsNumbers) |
| `Reminder` | `Boolean` | Optional | - | Boolean getReminder() | setReminder(Boolean reminder) |
| `Severity` | `String` | Optional | Severity level associated with the notification. Examples would be:<br />Major<br />Minor<br />Critical<br />NotApplicable. | String getSeverity() | setSeverity(String severity) |

## Example (as JSON)

```json
{
  "notificationType": "DailySummary",
  "callback": true,
  "emailNotification": false,
  "notificationGroupName": "Anomaly Test API",
  "notificationFrequencyFactor": 3,
  "notificationFrequencyInterval": "Hourly",
  "externalEmailRecipients": "placeholder@verizon.com",
  "smsNotification": true,
  "smsNumbers": [
    {
      "carrier": "US Cellular",
      "number": "9299280711"
    }
  ],
  "reminder": true,
  "severity": "Critical"
}
```

