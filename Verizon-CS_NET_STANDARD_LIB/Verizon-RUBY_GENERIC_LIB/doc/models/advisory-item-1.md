
# Advisory Item 1

*This model accepts additional fields of type Object.*

## Structure

`AdvisoryItem1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `item` | [`Item1`](../../doc/models/item-1.md) | Required | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

