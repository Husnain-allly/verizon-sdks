
# Notificationarray

*This model accepts additional fields of type array.*

## Structure

`Notificationarray`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `notificationType` | `?string` | Optional | - | getNotificationType(): ?string | setNotificationType(?string notificationType): void |
| `callback` | `?bool` | Optional | - | getCallback(): ?bool | setCallback(?bool callback): void |
| `emailNotification` | `?bool` | Optional | - | getEmailNotification(): ?bool | setEmailNotification(?bool emailNotification): void |
| `notificationGroupName` | `?string` | Optional | - | getNotificationGroupName(): ?string | setNotificationGroupName(?string notificationGroupName): void |
| `notificationFrequencyFactor` | `?int` | Optional | - | getNotificationFrequencyFactor(): ?int | setNotificationFrequencyFactor(?int notificationFrequencyFactor): void |
| `notificationFrequencyInterval` | `?string` | Optional | - | getNotificationFrequencyInterval(): ?string | setNotificationFrequencyInterval(?string notificationFrequencyInterval): void |
| `externalEmailRecipients` | `?string` | Optional | - | getExternalEmailRecipients(): ?string | setExternalEmailRecipients(?string externalEmailRecipients): void |
| `smsNotification` | `?bool` | Optional | - | getSmsNotification(): ?bool | setSmsNotification(?bool smsNotification): void |
| `smsNumbers` | [Cellphonenumber](../../doc/models/cellphonenumber.md)[]\|null | Optional | This is Array of a container for any-of cases. | getSmsNumbers(): ?array | setSmsNumbers(?array smsNumbers): void |
| `reminder` | `?bool` | Optional | - | getReminder(): ?bool | setReminder(?bool reminder): void |
| `severity` | `?string` | Optional | - | getSeverity(): ?string | setSeverity(?string severity): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

