
# Text Phrase or Itis

*This model accepts additional fields of type Object.*

## Structure

`TextPhraseOrItis`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `item` | [`ItisItem`](../../doc/models/itis-item.md) | Required | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

