
# Accountid

*This model accepts additional fields of type array.*

## Structure

`Accountid`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The numeric name of the account and must include leading zeroes | getAccountName(): ?string | setAccountName(?string accountName): void |
| `mtasAccountNumber` | `?string` | Optional | - | getMtasAccountNumber(): ?string | setMtasAccountNumber(?string mtasAccountNumber): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "mtasAccountNumber": "0000123456-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

