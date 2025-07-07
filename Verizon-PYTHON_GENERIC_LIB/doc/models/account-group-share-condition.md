
# Account Group Share Condition

*This model accepts additional fields of type Any.*

## Structure

`AccountGroupShareCondition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `action` | [`ConditionAction`](../../doc/models/condition-action.md) | Optional | The action taken when trigger conditions are met |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

