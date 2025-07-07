
# Account Consent Update

*This model accepts additional fields of type array.*

## Structure

`AccountConsentUpdate`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The numeric name of the account, including leading zeros. | getAccountName(): ?string | setAccountName(?string accountName): void |
| `allDeviceConsent` | `?int` | Optional | The consent setting to use for all the devices in the account. | getAllDeviceConsent(): ?int | setAllDeviceConsent(?int allDeviceConsent): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "allDeviceConsent": 0,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

