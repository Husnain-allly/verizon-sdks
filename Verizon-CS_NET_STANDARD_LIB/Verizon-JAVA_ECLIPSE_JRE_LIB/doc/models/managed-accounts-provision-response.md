
# Managed Accounts Provision Response

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountsProvisionResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Txid` | `String` | Optional | Transaction identifier | String getTxid() | setTxid(String txid) |
| `AccountName` | `String` | Optional | Account identifier | String getAccountName() | setAccountName(String accountName) |
| `PaccountName` | `String` | Optional | Primary Account identifier | String getPaccountName() | setPaccountName(String paccountName) |
| `ServiceName` | [`ServiceName`](../../doc/models/service-name.md) | Optional | Service name<br><br>**Default**: `ServiceName.LOCATION` | ServiceName getServiceName() | setServiceName(ServiceName serviceName) |
| `Status` | `String` | Optional | Provision status. Success or Fail | String getStatus() | setStatus(String status) |
| `Reason` | `String` | Optional | Detailed reason | String getReason() | setReason(String reason) |
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

