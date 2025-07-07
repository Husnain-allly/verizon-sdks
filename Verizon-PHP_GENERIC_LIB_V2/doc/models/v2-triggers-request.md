
# V2 Triggers Request

*This model accepts additional fields of type array.*

## Structure

`V2TriggersRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerName` | `?string` | Optional | The user defined name of the trigger | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `ecpdId` | `?string` | Optional | The Enterprise Customer Profile Database ID | getEcpdId(): ?string | setEcpdId(?string ecpdId): void |
| `triggerCategory` | [`?string(TriggerCategory)`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `dataTrigger` | [`?DataTrigger4`](../../doc/models/data-trigger-4.md) | Optional | - | getDataTrigger(): ?DataTrigger4 | setDataTrigger(?DataTrigger4 dataTrigger): void |
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
| `filterCriteria` | [`?AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - | getFilterCriteria(): ?AccountLevelFilter | setFilterCriteria(?AccountLevelFilter filterCriteria): void |
| `condition` | [`?Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - | getCondition(): ?Rateplantype2Condition | setCondition(?Rateplantype2Condition condition): void |
| `action` | [`?string(AccountLevelAction)`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met | getAction(): ?string | setAction(?string action): void |
| `accountName` | `?string` | Optional | The numeric name of the account and must include leading zeroes | getAccountName(): ?string | setAccountName(?string accountName): void |
| `pricePlanTrigger` | [`?PricePlanTrigger1`](../../doc/models/price-plan-trigger-1.md) | Optional | - | getPricePlanTrigger(): ?PricePlanTrigger1 | setPricePlanTrigger(?PricePlanTrigger1 pricePlanTrigger): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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
  "action": "notify",
  "accountName": "0000123456-00001",
  "triggerCategory": "DeviceGroupUsage",
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
      "action": "suspend",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "deviceGroup": {
      "filterCriteria": {
        "deviceGroupName": "deviceGroupName4",
        "IndividualOrCombined": "IndividualOrCombined4",
        "accountName": "accountName0",
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
    "conditionType": "Aging",
    "comparitor": "eq",
    "threshold": 222,
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

