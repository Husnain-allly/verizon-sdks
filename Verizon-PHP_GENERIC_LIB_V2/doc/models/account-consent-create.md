
# Account Consent Create

*This model accepts additional fields of type array.*

## Structure

`AccountConsentCreate`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceList` | `?(array[])` | Optional | An array of device identifiers | getDeviceList(): ?array | setDeviceList(?array deviceList): void |
| `accountName` | `?string` | Optional | The numeric name of the account, including leading zeros. | getAccountName(): ?string | setAccountName(?string accountName): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "deviceList": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

