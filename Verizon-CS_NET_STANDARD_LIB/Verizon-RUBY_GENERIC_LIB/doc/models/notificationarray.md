
# Notificationarray

*This model accepts additional fields of type Object.*

## Structure

`Notificationarray`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `notification_type` | `String` | Optional | - |
| `callback` | `TrueClass \| FalseClass` | Optional | - |
| `email_notification` | `TrueClass \| FalseClass` | Optional | - |
| `notification_group_name` | `String` | Optional | - |
| `notification_frequency_factor` | `Integer` | Optional | - |
| `notification_frequency_interval` | `String` | Optional | - |
| `external_email_recipients` | `String` | Optional | - |
| `sms_notification` | `TrueClass \| FalseClass` | Optional | - |
| `sms_numbers` | Array[[cellphonenumber](../../doc/models/cellphonenumber.md)] \| nil | Optional | This is Array of a container for any-of cases. |
| `reminder` | `TrueClass \| FalseClass` | Optional | - |
| `severity` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

