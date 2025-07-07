
# Text Phrase or Itis 1

*This model accepts additional fields of type array.*

## Structure

`TextPhraseOrItis1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `item` | [`Item2`](../../doc/models/item-2.md) | Required | - | getItem(): Item2 | setItem(Item2 item): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

