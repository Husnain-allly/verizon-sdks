
# Account Level Object

*This model accepts additional fields of type array.*

## Structure

`AccountLevelObject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `filterCriteria` | [`?AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - | getFilterCriteria(): ?AccountLevelFilter | setFilterCriteria(?AccountLevelFilter filterCriteria): void |
| `condition` | string([ConditionType](../../doc/models/condition-type.md))\|[ConditionObjectCall](../../doc/models/condition-object-call.md)\|null | Optional | This is a container for any-of cases. | getCondition(): | setCondition( condition): void |
| `action` | [`?string(AccountLevelAction)`](../../doc/models/account-level-action.md) | Optional | The action taken when trigger conditions are met | getAction(): ?string | setAction(?string action): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

