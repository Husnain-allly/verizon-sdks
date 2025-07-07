
# Managed Acc Provisioned List

*This model accepts additional fields of type array.*

## Structure

`ManagedAccProvisionedList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | Account name | getId(): ?string | setId(?string id): void |
| `txid` | `?string` | Optional | Transaction identifier | getTxid(): ?string | setTxid(?string txid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "id": "2334445555-00001",
  "txid": "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

