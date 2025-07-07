
# Managed Account Cancel Response

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountCancelResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `String` | Required | Transaction identifier |
| `account_name` | `String` | Required | Managed account identifier |
| `paccount_name` | `String` | Required | Primary account identifier |
| `service_name` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName::LOCATION` |
| `status` | `String` | Required | Deactivate/cancel status, Success or Fail |
| `reason` | `String` | Required | Detailed reason |
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

