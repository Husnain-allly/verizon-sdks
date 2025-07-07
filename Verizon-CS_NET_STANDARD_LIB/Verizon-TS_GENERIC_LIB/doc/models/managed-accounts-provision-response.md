
# Managed Accounts Provision Response

*This model accepts additional fields of type unknown.*

## Structure

`ManagedAccountsProvisionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `string \| undefined` | Optional | Transaction identifier |
| `accountName` | `string \| undefined` | Optional | Account identifier |
| `paccountName` | `string \| undefined` | Optional | Primary Account identifier |
| `serviceName` | [`ServiceName \| undefined`](../../doc/models/service-name.md) | Optional | Service name<br><br>**Default**: `ServiceName.Location` |
| `status` | `string \| undefined` | Optional | Provision status. Success or Fail |
| `reason` | `string \| undefined` | Optional | Detailed reason |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

