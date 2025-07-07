
# Advisory Item 1

*This model accepts additional fields of type Object.*

## Structure

`AdvisoryItem1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Item` | [`Item1`](../../doc/models/item-1.md) | Required | - | Item1 getItem() | setItem(Item1 item) |
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

