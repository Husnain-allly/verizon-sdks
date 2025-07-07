
# Account Level Create Trigger Request

## Structure

`AccountLevelCreateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerName` | `string \| undefined` | Optional | The user defined name of the trigger |
| `ecpdId` | `string \| undefined` | Optional | The Enterprise Customer Profile Database ID |
| `triggerCategory` | [`TriggerCategory \| undefined`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `dataTrigger` | [`DataTrigger \| undefined`](../../doc/models/data-trigger.md) | Optional | - |
| `notification` | [`Notificationarray \| undefined`](../../doc/models/notificationarray.md) | Optional | - |
| `notificationType` | `string \| undefined` | Optional | - |
| `callback` | `boolean \| undefined` | Optional | - |
| `emailNotification` | `boolean \| undefined` | Optional | - |
| `notificationGroupName` | `string \| undefined` | Optional | - |
| `notificationFrequencyFactor` | `number \| undefined` | Optional | - |
| `notificationFrequencyInterval` | `string \| undefined` | Optional | - |
| `externalEmailRecipients` | `string \| undefined` | Optional | - |
| `smsNotification` | `boolean \| undefined` | Optional | - |
| `smsNumbers` | [`AccountLevelCreateTriggerRequestSmsNumbers[] \| undefined`](../../doc/models/containers/account-level-create-trigger-request-sms-numbers.md) | Optional | This is Array of a container for any-of cases. |
| `reminder` | `boolean \| undefined` | Optional | - |
| `severity` | `string \| undefined` | Optional | - |
| `active` | [`Active \| undefined`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

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
  "triggerCategory": "AccountUsage",
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
      "condition": "Individual",
      "action": "suspend",
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
  }
}
```

