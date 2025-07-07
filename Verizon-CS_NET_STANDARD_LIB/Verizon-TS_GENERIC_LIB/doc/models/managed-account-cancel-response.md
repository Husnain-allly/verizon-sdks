
# Managed Account Cancel Response

*This model accepts additional fields of type unknown.*

## Structure

`ManagedAccountCancelResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `string` | Required | Transaction identifier |
| `accountName` | `string` | Required | Managed account identifier |
| `paccountName` | `string` | Required | Primary account identifier |
| `serviceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.Location` |
| `status` | `string` | Required | Deactivate/cancel status, Success or Fail |
| `reason` | `string` | Required | Detailed reason |
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

