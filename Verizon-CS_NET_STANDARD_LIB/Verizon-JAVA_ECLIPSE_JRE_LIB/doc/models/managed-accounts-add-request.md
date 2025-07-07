
# Managed Accounts Add Request

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountsAddRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account identifier | String getAccountName() | setAccountName(String accountName) |
| `ServiceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.LOCATION` | ServiceName getServiceName() | setServiceName(ServiceName serviceName) |
| `Type` | `String` | Required | SKU name | String getType() | setType(String type) |
| `ManagedAccList` | `List<String>` | Required | managed account list | List<String> getManagedAccList() | setManagedAccList(List<String> managedAccList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

