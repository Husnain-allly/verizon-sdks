
# V2 Triggers Request 1

*This model accepts additional fields of type array.*

## Structure

`V2TriggersRequest1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerId` | `?string` | Optional | The system assigned UUID of the trigger | getTriggerId(): ?string | setTriggerId(?string triggerId): void |
| `triggerName` | `?string` | Optional | The user defined name of the trigger | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `ecpdId` | `?string` | Optional | The Enterprise Customer Profile Database ID | getEcpdId(): ?string | setEcpdId(?string ecpdId): void |
| `triggerCategory` | [`?string(TriggerCategory)`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `dataTrigger` | [`?DataTrigger5`](../../doc/models/data-trigger-5.md) | Optional | - | getDataTrigger(): ?DataTrigger5 | setDataTrigger(?DataTrigger5 dataTrigger): void |
| `notification` | [`?Notificationarray`](../../doc/models/notificationarray.md) | Optional | - | getNotification(): ?Notificationarray | setNotification(?Notificationarray notification): void |
| `notificationType` | `?string` | Optional | - | getNotificationType(): ?string | setNotificationType(?string notificationType): void |
| `callback` | `?bool` | Optional | - | getCallback(): ?bool | setCallback(?bool callback): void |
| `emailNotification` | `?bool` | Optional | - | getEmailNotification(): ?bool | setEmailNotification(?bool emailNotification): void |
| `notificationGroupName` | `?string` | Optional | - | getNotificationGroupName(): ?string | setNotificationGroupName(?string notificationGroupName): void |
| `notificationFrequencyFactor` | `?int` | Optional | - | getNotificationFrequencyFactor(): ?int | setNotificationFrequencyFactor(?int notificationFrequencyFactor): void |
| `notificationFrequencyInterval` | `?string` | Optional | - | getNotificationFrequencyInterval(): ?string | setNotificationFrequencyInterval(?string notificationFrequencyInterval): void |
| `externalEmailRecipients` | `?string` | Optional | - | getExternalEmailRecipients(): ?string | setExternalEmailRecipients(?string externalEmailRecipients): void |
| `smsNotification` | `?bool` | Optional | - | getSmsNotification(): ?bool | setSmsNotification(?bool smsNotification): void |
| `smsNumbers` | [`?(Cellphonenumber[])`](../../doc/models/cellphonenumber.md) | Optional | - | getSmsNumbers(): ?array | setSmsNumbers(?array smsNumbers): void |
| `reminder` | `?bool` | Optional | - | getReminder(): ?bool | setReminder(?bool reminder): void |
| `severity` | `?string` | Optional | - | getSeverity(): ?string | setSeverity(?string severity): void |
| `active` | [`?string(Active)`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false | getActive(): ?string | setActive(?string active): void |
| `accountName` | `?string` | Optional | The numeric name of the account and must include leading zeroes | getAccountName(): ?string | setAccountName(?string accountName): void |
| `pricePlanTrigger` | [`?PricePlanTrigger2`](../../doc/models/price-plan-trigger-2.md) | Optional | - | getPricePlanTrigger(): ?PricePlanTrigger2 | setPricePlanTrigger(?PricePlanTrigger2 pricePlanTrigger): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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
  "accountName": "0000123456-00001",
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

