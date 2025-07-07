
# Suspenddetailsobject

*This model accepts additional fields of type unknown.*

## Structure

`Suspenddetailsobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `suspendFromAccounts` | `string[] \| undefined` | Optional | - |
| `suspendDuration` | `number \| undefined` | Optional | - |
| `suspendOption` | `string \| undefined` | Optional | - |
| `threshold` | `number \| undefined` | Optional | The threshold value the trigger monitors for |
| `thresholdUnit` | [`ThresholdUnit \| undefined`](../../doc/models/threshold-unit.md) | Optional | The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "suspendDuration": 90,
  "suspendOption": "withBilling",
  "threshold": 100,
  "thresholdUnit": "KB",
  "suspendFromAccounts": [
    "suspendFromAccounts7",
    "suspendFromAccounts8",
    "suspendFromAccounts9"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

