
# Managed Account Cancel Response

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountCancelResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Txid` | `String` | Required | Transaction identifier | String getTxid() | setTxid(String txid) |
| `AccountName` | `String` | Required | Managed account identifier | String getAccountName() | setAccountName(String accountName) |
| `PaccountName` | `String` | Required | Primary account identifier | String getPaccountName() | setPaccountName(String paccountName) |
| `ServiceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.LOCATION` | ServiceName getServiceName() | setServiceName(ServiceName serviceName) |
| `Status` | `String` | Required | Deactivate/cancel status, Success or Fail | String getStatus() | setStatus(String status) |
| `Reason` | `String` | Required | Detailed reason | String getReason() | setReason(String reason) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "txid": "4fbff332-eeee-ffff-gggg-7e3bdc90bd28",
  "accountName": "1223334444-00001",
  "paccountName": "1223334444-00001",
  "serviceName": "Location",
  "status": "Success",
  "reason": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

