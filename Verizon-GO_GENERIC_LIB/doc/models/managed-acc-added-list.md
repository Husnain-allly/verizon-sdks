
# Managed Acc Added List

*This model accepts additional fields of type interface{}.*

## Structure

`ManagedAccAddedList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `*string` | Optional | Account name |
| `Txid` | `*string` | Optional | Transaction identifier |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "id": "1223334444-00001",
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

