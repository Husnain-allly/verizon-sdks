
# Managed Accounts Add Response

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountsAddResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TxId` | `String` | Optional | Transaction identifier | String getTxId() | setTxId(String txId) |
| `StatusList` | [`List<StatusList>`](../../doc/models/status-list.md) | Optional | - | List<StatusList> getStatusList() | setStatusList(List<StatusList> statusList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "TxId": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "statusList": [
    {
      "id": "id6",
      "status": "status8",
      "reason": "reason8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

