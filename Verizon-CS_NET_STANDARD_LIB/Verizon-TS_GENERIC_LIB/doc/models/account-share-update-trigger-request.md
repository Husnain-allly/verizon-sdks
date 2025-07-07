
# Account Share Update Trigger Request

*This model accepts additional fields of type unknown.*

## Structure

`AccountShareUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string \| undefined` | Optional | The system assigned UUID of the trigger |
| `triggerName` | `string \| undefined` | Optional | The user defined name of the trigger |
| `ecpdId` | `string \| undefined` | Optional | The Enterprise Customer Profile Database ID |
| `triggerCategory` | [`TriggerCategory \| undefined`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `pricePlanTrigger` | [`AccountSharePricePlanTrigger \| undefined`](../../doc/models/account-share-price-plan-trigger.md) | Optional | - |
| `notification` | [`Notificationarray \| undefined`](../../doc/models/notificationarray.md) | Optional | - |
| `active` | [`Active \| undefined`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

