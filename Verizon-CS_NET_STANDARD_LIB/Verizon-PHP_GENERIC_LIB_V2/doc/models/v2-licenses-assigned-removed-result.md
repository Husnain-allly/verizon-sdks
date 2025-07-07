
# V2 Licenses Assigned Removed Result

License assignment or removal confirmation.

*This model accepts additional fields of type array.*

## Structure

`V2LicensesAssignedRemovedResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account name. | getAccountName(): string | setAccountName(string accountName): void |
| `licTotalCount` | `int` | Required | Total license count. | getLicTotalCount(): int | setLicTotalCount(int licTotalCount): void |
| `licUsedCount` | `int` | Required | Assigned license count. | getLicUsedCount(): int | setLicUsedCount(int licUsedCount): void |
| `deviceList` | [`V2DeviceStatus[]`](../../doc/models/v2-device-status.md) | Required | List of devices with id in IMEI. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0242078689-00001",
  "licTotalCount": 1000,
  "licUsedCount": 502,
  "deviceList": [
    {
      "deviceId": "990003425730524",
      "status": "Success",
      "resultReason": "Success",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "990000473475967",
      "status": "Failure",
      "resultReason": "Device does not exist.",
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

