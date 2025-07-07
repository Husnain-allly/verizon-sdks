
# Enable Promo Exp 1

*This model accepts additional fields of type object.*

## Structure

`EnablePromoExp1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Optional | - |
| `MValue` | `bool?` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "key": "EnablePromoExp",
  "value": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

