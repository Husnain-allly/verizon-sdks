
# Managed Account Cancel Request

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountCancelRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Managed account identifier | String getAccountName() | setAccountName(String accountName) |
| `PaccountName` | `String` | Required | Primary Account identifier | String getPaccountName() | setPaccountName(String paccountName) |
| `ServiceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.LOCATION` | ServiceName getServiceName() | setServiceName(ServiceName serviceName) |
| `Type` | `String` | Required | SKU name | String getType() | setType(String type) |
| `Txid` | `String` | Required | Transaction identifier returned by provision request | String getTxid() | setTxid(String txid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "paccountName": "1223334444-00001",
  "serviceName": "Location",
  "type": "TS-LOC-COARSE-CellID-5K",
  "txid": "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

