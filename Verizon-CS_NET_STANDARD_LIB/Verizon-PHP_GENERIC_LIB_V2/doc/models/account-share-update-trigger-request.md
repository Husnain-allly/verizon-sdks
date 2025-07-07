
# Account Share Update Trigger Request

*This model accepts additional fields of type array.*

## Structure

`AccountShareUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerId` | `?string` | Optional | The system assigned UUID of the trigger | getTriggerId(): ?string | setTriggerId(?string triggerId): void |
| `triggerName` | `?string` | Optional | The user defined name of the trigger | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `ecpdId` | `?string` | Optional | The Enterprise Customer Profile Database ID | getEcpdId(): ?string | setEcpdId(?string ecpdId): void |
| `triggerCategory` | [`?string(TriggerCategory)`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `pricePlanTrigger` | [`?AccountSharePricePlanTrigger`](../../doc/models/account-share-price-plan-trigger.md) | Optional | - | getPricePlanTrigger(): ?AccountSharePricePlanTrigger | setPricePlanTrigger(?AccountSharePricePlanTrigger pricePlanTrigger): void |
| `notification` | [`?Notificationarray`](../../doc/models/notificationarray.md) | Optional | - | getNotification(): ?Notificationarray | setNotification(?Notificationarray notification): void |
| `active` | [`?string(Active)`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false | getActive(): ?string | setActive(?string active): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "active": "true",
  "triggerCategory": "DeviceGroupUsage",
  "pricePlanTrigger": {
    "accountShare": {
      "filterCriteria": {
        "carrierServicePlanCode": "carrierServicePlanCode4",
        "accountNameList": [
          "accountNameList7",
          "accountNameList8"
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
    "condition": "Aging",
    "changePlan": false,
    "changePlanDetails": {
      "toCarrierServicePlanCode": "toCarrierServicePlanCode2",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

