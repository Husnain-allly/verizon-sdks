
# Actionobject

*This model accepts additional fields of type array.*

## Structure

`Actionobject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `suspend` | `?bool` | Optional | - | getSuspend(): ?bool | setSuspend(?bool suspend): void |
| `suspendDetails` | [`?Suspenddetailsobject`](../../doc/models/suspenddetailsobject.md) | Optional | - | getSuspendDetails(): ?Suspenddetailsobject | setSuspendDetails(?Suspenddetailsobject suspendDetails): void |
| `changePlan` | `?bool` | Optional | a flag to set if the trigger changes service plans, true, or not, false | getChangePlan(): ?bool | setChangePlan(?bool changePlan): void |
| `changePlanDetails` | [`?ChangePlanDetails`](../../doc/models/change-plan-details.md) | Optional | The service plan code to switch to | getChangePlanDetails(): ?ChangePlanDetails | setChangePlanDetails(?ChangePlanDetails changePlanDetails): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

