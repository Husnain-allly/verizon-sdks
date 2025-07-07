
# Device Level Update Trigger

## Structure

`DeviceLevelUpdateTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_id` | `String` | Optional | The system assigned UUID of the trigger |
| `trigger_name` | `String` | Optional | The user defined name of the trigger |
| `ecpd_id` | `String` | Optional | The Enterprise Customer Profile Database ID |
| `trigger_category` | [`TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `data_trigger` | [`DataTrigger2`](../../doc/models/data-trigger-2.md) | Optional | - |
| `notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "triggerName": "name of the trigger",
  "ecpdId": "Verizon profile ID",
  "triggerCategory": "AccountUsage",
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

