
# V1 Licenses Assigned Removed Result

License assignment or removal confirmation.

*This model accepts additional fields of type array.*

## Structure

`V1LicensesAssignedRemovedResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | Account identifier in "##########-#####". | getAccountName(): ?string | setAccountName(?string accountName): void |
| `licCount` | `?int` | Optional | Total number of monthly licenses in an MRC subscription. | getLicCount(): ?int | setLicCount(?int licCount): void |
| `licUsedCount` | `?int` | Optional | Number of licenses assigned to devices after the request completed. | getLicUsedCount(): ?int | setLicUsedCount(?int licUsedCount): void |
| `deviceList` | [`?(V1DeviceListItem[])`](../../doc/models/v1-device-list-item.md) | Optional | A JSON object for each device that was in the request. | getDeviceList(): ?array | setDeviceList(?array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0242078689-00001",
  "licCount": 9000,
  "licUsedCount": 1000,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "status": "LicenseAssignSuccess",
      "Reason": "Success",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "900000000000999",
      "status": "LicenseAssignSuccess",
      "Reason": "Success",
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

