
# Managed Accounts Provision Request

*This model accepts additional fields of type interface{}.*

## Structure

`ManagedAccountsProvisionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Managed account identifier |
| `PaccountName` | `string` | Required | Primary Account identifier |
| `ServiceName` | [`models.ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `"Location"` |
| `Type` | `string` | Required | SKU name |
| `Txid` | `string` | Required | Transaction identifier returned by add request |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

