
# Text Phrase or Itis

*This model accepts additional fields of type interface{}.*

## Structure

`TextPhraseOrItis`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Item` | [`models.ItisItem`](../../doc/models/itis-item.md) | Required | - |
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

