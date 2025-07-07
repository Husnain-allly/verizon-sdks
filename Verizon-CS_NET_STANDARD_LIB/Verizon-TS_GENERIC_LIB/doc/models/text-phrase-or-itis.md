
# Text Phrase or Itis

*This model accepts additional fields of type unknown.*

## Structure

`TextPhraseOrItis`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `item` | [`ItisItem`](../../doc/models/itis-item.md) | Required | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

