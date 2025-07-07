
# Text Phrase or Itis

*This model accepts additional fields of type object.*

## Structure

`TextPhraseOrItis`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Item` | [`ItisItem`](../../doc/models/itis-item.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

