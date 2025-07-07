
# Managed Accounts Provision Response

*This model accepts additional fields of type interface{}.*

## Structure

`ManagedAccountsProvisionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `*string` | Optional | Transaction identifier |
| `AccountName` | `*string` | Optional | Account identifier |
| `PaccountName` | `*string` | Optional | Primary Account identifier |
| `ServiceName` | [`*models.ServiceName`](../../doc/models/service-name.md) | Optional | Service name<br><br>**Default**: `"Location"` |
| `Status` | `*string` | Optional | Provision status. Success or Fail |
| `Reason` | `*string` | Optional | Detailed reason |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

