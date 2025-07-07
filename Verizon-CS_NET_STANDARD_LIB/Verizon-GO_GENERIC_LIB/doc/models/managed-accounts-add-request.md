
# Managed Accounts Add Request

*This model accepts additional fields of type interface{}.*

## Structure

`ManagedAccountsAddRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier |
| `ServiceName` | [`models.ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `"Location"` |
| `Type` | `string` | Required | SKU name |
| `ManagedAccList` | `[]string` | Required | managed account list |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

