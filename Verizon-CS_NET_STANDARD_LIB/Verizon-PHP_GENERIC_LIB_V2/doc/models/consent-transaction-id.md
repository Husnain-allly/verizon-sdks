
# Consent Transaction Id

The transaction ID of the request that you want to cancel, from the POST /devicelocations synchronus response.

*This model accepts additional fields of type array.*

## Structure

`ConsentTransactionId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `transactionId` | `?string` | Optional | - | getTransactionId(): ?string | setTransactionId(?string transactionId): void |
| `status` | `?string` | Optional | - | getStatus(): ?string | setStatus(?string status): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "transactionId": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "QUEUED",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

