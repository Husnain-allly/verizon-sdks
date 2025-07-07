
# Text Phrase or Itis 1

*This model accepts additional fields of type interface{}.*

## Structure

`TextPhraseOrItis1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Item` | [`models.Item2`](../../doc/models/item-2.md) | Required | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "item": {
    "text": "text2"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

