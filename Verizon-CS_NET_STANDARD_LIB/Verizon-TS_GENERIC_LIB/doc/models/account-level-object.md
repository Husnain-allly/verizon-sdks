
# Account Level Object

*This model accepts additional fields of type unknown.*

## Structure

`AccountLevelObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filterCriteria` | [`AccountLevelFilter \| undefined`](../../doc/models/account-level-filter.md) | Optional | - |
| `condition` | [`AccountLevelObjectCondition \| undefined`](../../doc/models/containers/account-level-object-condition.md) | Optional | This is a container for any-of cases. |
| `action` | [`AccountLevelAction \| undefined`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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
  "condition": "UsageAllowance",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

