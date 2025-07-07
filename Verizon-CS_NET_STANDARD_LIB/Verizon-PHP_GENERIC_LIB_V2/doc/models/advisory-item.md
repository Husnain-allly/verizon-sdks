
# Advisory Item

*This model accepts additional fields of type array.*

## Structure

`AdvisoryItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `item` | [`Item`](../../doc/models/item.md) | Required | - | getItem(): Item | setItem(Item item): void |
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

