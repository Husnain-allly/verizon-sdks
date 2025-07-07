
# Account Group Share Condition

*This model accepts additional fields of type unknown.*

## Structure

`AccountGroupShareCondition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `action` | [`ConditionAction \| undefined`](../../doc/models/condition-action.md) | Optional | The action taken when trigger conditions are met |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

