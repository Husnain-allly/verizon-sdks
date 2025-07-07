
# Advisory Item

*This model accepts additional fields of type Object.*

## Structure

`AdvisoryItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `item` | [`Item`](../../doc/models/item.md) | Required | - |
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

