
# Text Phrase or Itis 1

*This model accepts additional fields of type Any.*

## Structure

`TextPhraseOrItis1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `item` | [`Item2`](../../doc/models/item-2.md) | Required | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

