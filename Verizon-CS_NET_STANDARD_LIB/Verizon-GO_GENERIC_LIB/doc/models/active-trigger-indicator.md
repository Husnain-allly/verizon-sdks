
# Active Trigger Indicator

Whether the trigger is active or not.

*This model accepts additional fields of type interface{}.*

## Structure

`ActiveTriggerIndicator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Active` | `*bool` | Optional | Indicates if the trigger is active<br />True - trigger is active<br />False - trigger is not active. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "active": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

