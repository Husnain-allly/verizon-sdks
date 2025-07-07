
# Managed Accounts Provision Response

*This model accepts additional fields of type array.*

## Structure

`ManagedAccountsProvisionResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `txid` | `?string` | Optional | Transaction identifier | getTxid(): ?string | setTxid(?string txid): void |
| `accountName` | `?string` | Optional | Account identifier | getAccountName(): ?string | setAccountName(?string accountName): void |
| `paccountName` | `?string` | Optional | Primary Account identifier | getPaccountName(): ?string | setPaccountName(?string paccountName): void |
| `serviceName` | [`?string(ServiceName)`](../../doc/models/service-name.md) | Optional | Service name<br><br>**Default**: `ServiceName::LOCATION` | getServiceName(): ?string | setServiceName(?string serviceName): void |
| `status` | `?string` | Optional | Provision status. Success or Fail | getStatus(): ?string | setStatus(?string status): void |
| `reason` | `?string` | Optional | Detailed reason | getReason(): ?string | setReason(?string reason): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

