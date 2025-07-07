
# Change Pwn Device Profile Request

*This model accepts additional fields of type array.*

## Structure

`ChangePwnDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | - | getAccountName(): string | setAccountName(string accountName): void |
| `deviceList` | [`PwnDeviceList[]`](../../doc/models/pwn-device-list.md) | Required | - | getDeviceList(): array | setDeviceList(array deviceList): void |
| `newProfile` | `string` | Required | - | getNewProfile(): string | setNewProfile(string newProfile): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0342351414-00001",
  "deviceList": [
    {
      "deviceIds": [
        {
          "id": "99948099913024600000",
          "kind": "iccid",
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
  ],
  "newProfile": "HSS EsmProfile Enterprise 5G internet",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

