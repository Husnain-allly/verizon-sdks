
# Advisory Item 1

*This model accepts additional fields of type array.*

## Structure

`AdvisoryItem1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `item` | [`Item1`](../../doc/models/item-1.md) | Required | - | getItem(): Item1 | setItem(Item1 item): void |
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

