
# Actionobject

*This model accepts additional fields of type object.*

## Structure

`Actionobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Suspend` | `bool?` | Optional | - |
| `SuspendDetails` | [`Suspenddetailsobject`](../../doc/models/suspenddetailsobject.md) | Optional | - |
| `ChangePlan` | `bool?` | Optional | a flag to set if the trigger changes service plans, true, or not, false |
| `ChangePlanDetails` | [`ChangePlanDetails`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

