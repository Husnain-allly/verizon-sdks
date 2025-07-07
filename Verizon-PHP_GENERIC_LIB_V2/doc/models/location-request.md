
# Location Request

The body contains the the account name and list of devices that you want to locate, plus other options.

*This model accepts additional fields of type array.*

## Structure

`LocationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier in "##########-#####". | getAccountName(): string | setAccountName(string accountName): void |
| `deviceList` | [`DeviceInfo[]`](../../doc/models/device-info.md) | Required | Device list. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `accuracyMode` | [`?string(AccuracyMode)`](../../doc/models/accuracy-mode.md) | Optional | Accurary, currently only 0-coarse supported. | getAccuracyMode(): ?string | setAccuracyMode(?string accuracyMode): void |
| `cacheMode` | [`?string(CacheMode)`](../../doc/models/cache-mode.md) | Optional | Location cache mode. | getCacheMode(): ?string | setCacheMode(?string cacheMode): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "1234567890-00001",
  "accuracyMode": "0",
  "cacheMode": "1",
  "deviceList": [
    {
      "id": "980003420535573",
      "kind": "imei",
      "mdn": "7892345678",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "375535024300089",
      "kind": "imei",
      "mdn": "7897654321",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "A100003861E585",
      "kind": "meid",
      "mdn": "7897650914",
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

