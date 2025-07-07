
# V2 Triggers Request 1

*This model accepts additional fields of type Any.*

## Structure

`V2TriggersRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_id` | `str` | Optional | The system assigned UUID of the trigger |
| `trigger_name` | `str` | Optional | The user defined name of the trigger |
| `ecpd_id` | `str` | Optional | The Enterprise Customer Profile Database ID |
| `trigger_category` | [`TriggerCategory`](../../doc/models/trigger-category.md) | Optional | The type of trigger being created or modified |
| `data_trigger` | [`DataTrigger5`](../../doc/models/data-trigger-5.md) | Optional | - |
| `notification` | [`Notificationarray`](../../doc/models/notificationarray.md) | Optional | - |
| `notification_type` | `str` | Optional | - |
| `callback` | `bool` | Optional | - |
| `email_notification` | `bool` | Optional | - |
| `notification_group_name` | `str` | Optional | - |
| `notification_frequency_factor` | `int` | Optional | - |
| `notification_frequency_interval` | `str` | Optional | - |
| `external_email_recipients` | `str` | Optional | - |
| `sms_notification` | `bool` | Optional | - |
| `sms_numbers` | [`List[Cellphonenumber]`](../../doc/models/cellphonenumber.md) | Optional | - |
| `reminder` | `bool` | Optional | - |
| `severity` | `str` | Optional | - |
| `active` | [`Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `account_name` | `str` | Optional | The numeric name of the account and must include leading zeroes |
| `price_plan_trigger` | [`PricePlanTrigger2`](../../doc/models/price-plan-trigger-2.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

