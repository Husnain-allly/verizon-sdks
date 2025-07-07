
# Managed Acc Added List

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccAddedList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | Account name | String getId() | setId(String id) |
| `Txid` | `String` | Optional | Transaction identifier | String getTxid() | setTxid(String txid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

