
# Pay as You Go Update Trigger Request

*This model accepts additional fields of type Object.*

## Structure

`PayAsYouGoUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerId` | `String` | Optional | The system assigned UUID of the trigger | String getTriggerId() | setTriggerId(String triggerId) |
| `TriggerName` | `String` | Optional | The user defined name of the trigger | String getTriggerName() | setTriggerName(String triggerName) |
| `EcpdId` | `String` | Optional | The Enterprise Customer Profile Database ID | String getEcpdId() | setEcpdId(String ecpdId) |
| `TriggerCategory` | [`TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified | TriggerCategory getTriggerCategory() | setTriggerCategory(TriggerCategory triggerCategory) |
| `PricePlanTrigger` | [`PayAsYouGoPricePlanTrigger`](../../doc/models/pay-as-you-go-price-plan-trigger.md) | Optional | - | PayAsYouGoPricePlanTrigger getPricePlanTrigger() | setPricePlanTrigger(PayAsYouGoPricePlanTrigger pricePlanTrigger) |
| `Notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - | Notificationarray getNotification() | setNotification(Notificationarray notification) |
| `Active` | [`Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false | Active getActive() | setActive(Active active) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "active": "true",
  "triggerCategory": "PricePlanDataUsage",
  "pricePlanTrigger": {
    "payAsYouGo": {
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
    "action": {
      "suspend": false,
      "suspendDetails": {
        "suspendFromAccounts": [
          "suspendFromAccounts7"
        ],
        "suspendDuration": 152,
        "suspendOption": "suspendOption2",
        "threshold": 166,
        "thresholdUnit": "GB",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

