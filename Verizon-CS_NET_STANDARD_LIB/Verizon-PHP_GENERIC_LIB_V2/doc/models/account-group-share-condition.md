
# Account Group Share Condition

*This model accepts additional fields of type array.*

## Structure

`AccountGroupShareCondition`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `action` | [`?string(ConditionAction)`](../../doc/models/condition-action.md) | Optional | The action taken when trigger conditions are met | getAction(): ?string | setAction(?string action): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "action": "notify",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

