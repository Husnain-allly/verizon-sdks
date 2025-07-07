
# Managed Accounts Add Request

*This model accepts additional fields of type array.*

## Structure

`ManagedAccountsAddRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier | getAccountName(): string | setAccountName(string accountName): void |
| `serviceName` | [`string(ServiceName)`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName::LOCATION` | getServiceName(): string | setServiceName(string serviceName): void |
| `type` | `string` | Required | SKU name | getType(): string | setType(string type): void |
| `managedAccList` | `string[]` | Required | managed account list | getManagedAccList(): array | setManagedAccList(array managedAccList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

