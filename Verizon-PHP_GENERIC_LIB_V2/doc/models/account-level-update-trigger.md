
# Account Level Update Trigger

## Structure

`AccountLevelUpdateTrigger`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerId` | `?string` | Optional | The system assigned UUID of the trigger | getTriggerId(): ?string | setTriggerId(?string triggerId): void |
| `triggerName` | `?string` | Optional | The user defined name of the trigger | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `ecpdId` | `?string` | Optional | The Enterprise Customer Profile Database ID | getEcpdId(): ?string | setEcpdId(?string ecpdId): void |
| `triggerCategory` | [`?string(TriggerCategory)`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `dataTrigger` | [`?DataTrigger1`](../../doc/models/data-trigger-1.md) | Optional | - | getDataTrigger(): ?DataTrigger1 | setDataTrigger(?DataTrigger1 dataTrigger): void |
| `notification` | [`?Notificationarray`](../../doc/models/notificationarray.md) | Optional | - | getNotification(): ?Notificationarray | setNotification(?Notificationarray notification): void |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
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

