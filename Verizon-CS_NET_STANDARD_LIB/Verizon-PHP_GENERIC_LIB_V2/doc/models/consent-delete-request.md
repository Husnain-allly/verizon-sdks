
# Consent Delete Request

*This model accepts additional fields of type array.*

## Structure

`ConsentDeleteRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | Account identifier. | getAccountName(): ?string | setAccountName(?string accountName): void |
| `deviceList` | `?(string[])` | Optional | Device ID list. | getDeviceList(): ?array | setDeviceList(?array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "MyAccount-1",
  "deviceList": [
    "deviceList2",
    "deviceList3"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

