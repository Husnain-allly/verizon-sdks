
# Account Group Share Condition

*This model accepts additional fields of type object.*

## Structure

`AccountGroupShareCondition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | [`ConditionAction?`](../../doc/models/condition-action.md) | Optional | The action taken when trigger conditions are met |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

