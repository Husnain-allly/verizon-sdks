
# Activeindicator

*This model accepts additional fields of type interface{}.*

## Structure

`Activeindicator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Active` | [`*models.Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

