
# Firmware Imei

A list of IMEIs for devices to be synchronized between ThingSpace and the FOTA server.

*This model accepts additional fields of type array.*

## Structure

`FirmwareImei`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceList` | `string[]` | Required | Device IMEI list.<br><br>**Constraints**: *Maximum Items*: `1000` | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceList": [
    "15-digit IMEI"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

