
# Notificationarray

*This model accepts additional fields of type unknown.*

## Structure

`Notificationarray`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `notificationType` | `string \| undefined` | Optional | - |
| `callback` | `boolean \| undefined` | Optional | - |
| `emailNotification` | `boolean \| undefined` | Optional | - |
| `notificationGroupName` | `string \| undefined` | Optional | - |
| `notificationFrequencyFactor` | `number \| undefined` | Optional | - |
| `notificationFrequencyInterval` | `string \| undefined` | Optional | - |
| `externalEmailRecipients` | `string \| undefined` | Optional | - |
| `smsNotification` | `boolean \| undefined` | Optional | - |
| `smsNumbers` | [`Cellphonenumber[] \| undefined`](../../doc/models/cellphonenumber.md) | Optional | - |
| `reminder` | `boolean \| undefined` | Optional | - |
| `severity` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

