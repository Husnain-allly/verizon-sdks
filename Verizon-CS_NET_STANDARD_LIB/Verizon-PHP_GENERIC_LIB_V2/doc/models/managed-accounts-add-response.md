
# Managed Accounts Add Response

*This model accepts additional fields of type array.*

## Structure

`ManagedAccountsAddResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `txId` | `?string` | Optional | Transaction identifier | getTxId(): ?string | setTxId(?string txId): void |
| `statusList` | [`?(StatusList[])`](../../doc/models/status-list.md) | Optional | - | getStatusList(): ?array | setStatusList(?array statusList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "TxId": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "statusList": [
    {
      "id": "id6",
      "status": "status8",
      "reason": "reason8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

