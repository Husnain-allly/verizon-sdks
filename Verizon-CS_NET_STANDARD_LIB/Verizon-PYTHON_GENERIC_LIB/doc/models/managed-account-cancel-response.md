
# Managed Account Cancel Response

*This model accepts additional fields of type Any.*

## Structure

`ManagedAccountCancelResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `str` | Required | Transaction identifier |
| `account_name` | `str` | Required | Managed account identifier |
| `paccount_name` | `str` | Required | Primary account identifier |
| `service_name` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `'Location'` |
| `status` | `str` | Required | Deactivate/cancel status, Success or Fail |
| `reason` | `str` | Required | Detailed reason |
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

