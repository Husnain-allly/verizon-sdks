
# Notificationarray

*This model accepts additional fields of type interface{}.*

## Structure

`Notificationarray`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NotificationType` | `*string` | Optional | - |
| `Callback` | `*bool` | Optional | - |
| `EmailNotification` | `*bool` | Optional | - |
| `NotificationGroupName` | `*string` | Optional | - |
| `NotificationFrequencyFactor` | `*int` | Optional | - |
| `NotificationFrequencyInterval` | `*string` | Optional | - |
| `ExternalEmailRecipients` | `*string` | Optional | - |
| `SmsNotification` | `*bool` | Optional | - |
| `SmsNumbers` | [`[]models.NotificationarraySmsNumbers`](../../doc/models/containers/notificationarray-sms-numbers.md) | Optional | This is Array of a container for any-of cases. |
| `Reminder` | `*bool` | Optional | - |
| `Severity` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

