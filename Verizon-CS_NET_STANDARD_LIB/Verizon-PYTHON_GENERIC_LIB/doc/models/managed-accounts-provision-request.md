
# Managed Accounts Provision Request

*This model accepts additional fields of type Any.*

## Structure

`ManagedAccountsProvisionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | Managed account identifier |
| `paccount_name` | `str` | Required | Primary Account identifier |
| `service_name` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `'Location'` |
| `mtype` | `str` | Required | SKU name |
| `txid` | `str` | Required | Transaction identifier returned by add request |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

