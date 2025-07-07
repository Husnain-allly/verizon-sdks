
# Account Level Object

*This model accepts additional fields of type interface{}.*

## Structure

`AccountLevelObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`*models.AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - |
| `Condition` | [`*models.Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - |
| `Action` | [`*models.AccountLevelAction`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "action": "notify",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

