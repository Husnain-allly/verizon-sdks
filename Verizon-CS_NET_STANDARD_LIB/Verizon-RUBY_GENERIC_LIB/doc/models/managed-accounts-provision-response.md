
# Managed Accounts Provision Response

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountsProvisionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `String` | Optional | Transaction identifier |
| `account_name` | `String` | Optional | Account identifier |
| `paccount_name` | `String` | Optional | Primary Account identifier |
| `service_name` | [`ServiceName`](../../doc/models/service-name.md) | Optional | Service name<br><br>**Default**: `ServiceName::LOCATION` |
| `status` | `String` | Optional | Provision status. Success or Fail |
| `reason` | `String` | Optional | Detailed reason |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

