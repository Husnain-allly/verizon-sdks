
# Managed Accounts Provision Response

*This model accepts additional fields of type Any.*

## Structure

`ManagedAccountsProvisionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `str` | Optional | Transaction identifier |
| `account_name` | `str` | Optional | Account identifier |
| `paccount_name` | `str` | Optional | Primary Account identifier |
| `service_name` | [`ServiceName`](../../doc/models/service-name.md) | Optional | Service name<br><br>**Default**: `'Location'` |
| `status` | `str` | Optional | Provision status. Success or Fail |
| `reason` | `str` | Optional | Detailed reason |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

