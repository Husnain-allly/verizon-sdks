
# Advisory Item 1

*This model accepts additional fields of type object.*

## Structure

`AdvisoryItem1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Item` | [`Item1`](../../doc/models/item-1.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

