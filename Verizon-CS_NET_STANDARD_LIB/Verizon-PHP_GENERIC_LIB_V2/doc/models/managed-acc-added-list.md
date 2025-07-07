
# Managed Acc Added List

*This model accepts additional fields of type array.*

## Structure

`ManagedAccAddedList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | Account name | getId(): ?string | setId(?string id): void |
| `txid` | `?string` | Optional | Transaction identifier | getTxid(): ?string | setTxid(?string txid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "id": "1223334444-00001",
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

