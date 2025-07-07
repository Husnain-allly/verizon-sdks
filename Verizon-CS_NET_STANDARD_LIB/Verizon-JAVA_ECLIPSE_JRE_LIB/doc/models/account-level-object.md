
# Account Level Object

*This model accepts additional fields of type Object.*

## Structure

`AccountLevelObject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | [`AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - | AccountLevelFilter getFilterCriteria() | setFilterCriteria(AccountLevelFilter filterCriteria) |
| `Condition` | [`AccountLevelObjectCondition`](../../doc/models/containers/account-level-object-condition.md) | Optional | This is a container for any-of cases. | AccountLevelObjectCondition getCondition() | setCondition(AccountLevelObjectCondition condition) |
| `Action` | [`AccountLevelAction`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met | AccountLevelAction getAction() | setAction(AccountLevelAction action) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

