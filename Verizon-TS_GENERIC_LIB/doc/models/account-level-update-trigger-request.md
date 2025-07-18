
# Account Level Update Trigger Request

## Structure

`AccountLevelUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string \| undefined` | Optional | The system assigned UUID of the trigger |
| `triggerName` | `string \| undefined` | Optional | The user defined name of the trigger |
| `ecpdId` | `string \| undefined` | Optional | The Enterprise Customer Profile Database ID |
| `triggerCategory` | [`TriggerCategory \| undefined`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `dataTrigger` | [`DataTrigger1 \| undefined`](../../doc/models/data-trigger-1.md) | Optional | - |
| `notification` | [`Notificationarray \| undefined`](../../doc/models/notificationarray.md) | Optional | - |
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
| `active` | [`Active \| undefined`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

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

