
# Updatetriggerchunk

*This model accepts additional fields of type interface{}.*

## Structure

`Updatetriggerchunk`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `*string` | Optional | The system assigned UUID of the trigger |
| `TriggerName` | `*string` | Optional | The user defined name of the trigger |
| `EcpdId` | `*string` | Optional | The Enterprise Customer Profile Database ID |
| `TriggerCategory` | [`*models.TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `PricePlanTrigger` | [`*models.PricePlanTrigger`](../../doc/models/price-plan-trigger.md) | Optional | - |
| `Notification` | [`*models.Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `Active` | [`*models.Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "active": "true",
  "triggerCategory": "DeviceGroupUsage",
  "pricePlanTrigger": {
    "standAlone": {
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

