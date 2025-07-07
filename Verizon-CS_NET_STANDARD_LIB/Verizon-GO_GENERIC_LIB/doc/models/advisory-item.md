
# Advisory Item

*This model accepts additional fields of type interface{}.*

## Structure

`AdvisoryItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Item` | [`models.Item`](../../doc/models/item.md) | Required | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "item": {
    "itis": 10
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

