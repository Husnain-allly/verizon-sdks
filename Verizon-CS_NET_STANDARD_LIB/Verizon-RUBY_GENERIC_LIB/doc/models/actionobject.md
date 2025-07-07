
# Actionobject

*This model accepts additional fields of type Object.*

## Structure

`Actionobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `suspend` | `TrueClass \| FalseClass` | Optional | - |
| `suspend_details` | [`Suspenddetailsobject`](../../doc/models/suspenddetailsobject.md) | Optional | - |
| `change_plan` | `TrueClass \| FalseClass` | Optional | a flag to set if the trigger changes service plans, true, or not, false |
| `change_plan_details` | [`ChangePlanDetails`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "suspend": true,
  "changePlan": true,
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
}
```

