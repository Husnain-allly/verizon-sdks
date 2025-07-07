
# Activeindicator

*This model accepts additional fields of type object.*

## Structure

`Activeindicator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Active` | [`Active?`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "active": "true",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

