
# Managed Acc Provisioned List

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccProvisionedList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | Account name | String getId() | setId(String id) |
| `Txid` | `String` | Optional | Transaction identifier | String getTxid() | setTxid(String txid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "2334445555-00001",
  "txid": "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

