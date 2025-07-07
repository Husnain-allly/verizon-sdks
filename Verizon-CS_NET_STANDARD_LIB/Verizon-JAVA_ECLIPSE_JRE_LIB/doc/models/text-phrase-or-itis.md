
# Text Phrase or Itis

*This model accepts additional fields of type Object.*

## Structure

`TextPhraseOrItis`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Item` | [`ItisItem`](../../doc/models/itis-item.md) | Required | - | ItisItem getItem() | setItem(ItisItem item) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

