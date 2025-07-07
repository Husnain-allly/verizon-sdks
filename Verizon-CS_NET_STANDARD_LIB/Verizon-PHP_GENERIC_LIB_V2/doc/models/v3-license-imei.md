
# V3 License Imei

List of devices.

*This model accepts additional fields of type array.*

## Structure

`V3LicenseImei`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceList` | `string[]` | Required | Device IMEI list. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceList": [
    "15-digit IMEI",
    "15-digit IMEI"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

