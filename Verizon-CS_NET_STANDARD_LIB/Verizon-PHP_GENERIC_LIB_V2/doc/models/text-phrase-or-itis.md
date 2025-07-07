
# Text Phrase or Itis

*This model accepts additional fields of type array.*

## Structure

`TextPhraseOrItis`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `item` | [`ItisItem`](../../doc/models/itis-item.md) | Required | - | getItem(): ItisItem | setItem(ItisItem item): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

