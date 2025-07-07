
# Managed Accounts Add Request

*This model accepts additional fields of type unknown.*

## Structure

`ManagedAccountsAddRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier |
| `serviceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.Location` |
| `type` | `string` | Required | SKU name |
| `managedAccList` | `string[]` | Required | managed account list |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

