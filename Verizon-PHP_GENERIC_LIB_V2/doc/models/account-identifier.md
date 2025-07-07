
# Account Identifier

The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.

*This model accepts additional fields of type array.*

## Structure

`AccountIdentifier`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `billingaccountid` | `?string` | Optional | - | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "billingaccountid": "0000000000-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

