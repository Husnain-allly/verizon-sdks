
# Account Level Object

*This model accepts additional fields of type array.*

## Structure

`AccountLevelObject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `filterCriteria` | [`?AccountLevelFilter`](../../doc/models/account-level-filter.md) | Optional | - | getFilterCriteria(): ?AccountLevelFilter | setFilterCriteria(?AccountLevelFilter filterCriteria): void |
| `condition` | [`?Rateplantype2Condition`](../../doc/models/rateplantype-2-condition.md) | Optional | - | getCondition(): ?Rateplantype2Condition | setCondition(?Rateplantype2Condition condition): void |
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

