
# Managed Accounts Add Request

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountsAddRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | Account identifier |
| `service_name` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName::LOCATION` |
| `type` | `String` | Required | SKU name |
| `managed_acc_list` | `Array<String>` | Required | managed account list |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "1234567890-00001",
  "serviceName": "Location",
  "type": "TS-LOC-COARSE-CellID-Aggr",
  "managedAccList": [
    "1223334444-00001",
    "2334445555-00001",
    "3445556666-00001"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

