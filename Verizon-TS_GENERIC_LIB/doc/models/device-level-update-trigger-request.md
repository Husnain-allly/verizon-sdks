
# Device Level Update Trigger Request

## Structure

`DeviceLevelUpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string \| undefined` | Optional | The system assigned UUID of the trigger |
| `triggerName` | `string \| undefined` | Optional | The user defined name of the trigger |
| `ecpdId` | `string \| undefined` | Optional | The Enterprise Customer Profile Database ID |
| `triggerCategory` | [`TriggerCategory \| undefined`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `dataTrigger` | [`DataTrigger2 \| undefined`](../../doc/models/data-trigger-2.md) | Optional | - |
| `notification` | [`Notificationarray \| undefined`](../../doc/models/notificationarray.md) | Optional | - |
| `active` | [`Active \| undefined`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "active": "true",
  "triggerCategory": "PricePlanDataUsage",
  "dataTrigger": {
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
    "thresholdUnit": "MB",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

