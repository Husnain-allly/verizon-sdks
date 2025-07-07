
# Managed Acc Added List

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccAddedList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Optional | Account name |
| `txid` | `String` | Optional | Transaction identifier |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

