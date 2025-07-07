
# Text Phrase or Itis 1

*This model accepts additional fields of type Object.*

## Structure

`TextPhraseOrItis1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Item` | [`Item2`](../../doc/models/item-2.md) | Required | - | Item2 getItem() | setItem(Item2 item) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

