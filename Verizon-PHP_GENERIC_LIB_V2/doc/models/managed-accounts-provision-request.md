
# Managed Accounts Provision Request

*This model accepts additional fields of type array.*

## Structure

`ManagedAccountsProvisionRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Managed account identifier | getAccountName(): string | setAccountName(string accountName): void |
| `paccountName` | `string` | Required | Primary Account identifier | getPaccountName(): string | setPaccountName(string paccountName): void |
| `serviceName` | [`string(ServiceName)`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName::LOCATION` | getServiceName(): string | setServiceName(string serviceName): void |
| `type` | `string` | Required | SKU name | getType(): string | setType(string type): void |
| `txid` | `string` | Required | Transaction identifier returned by add request | getTxid(): string | setTxid(string txid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "paccountName": "1223334444-00001",
  "serviceName": "Location",
  "type": "TS-LOC-COARSE-CellID-5K",
  "txid": "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

