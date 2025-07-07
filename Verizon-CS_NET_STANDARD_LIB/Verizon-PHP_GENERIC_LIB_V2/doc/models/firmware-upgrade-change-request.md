
# Firmware Upgrade Change Request

List of devices to add or remove.

*This model accepts additional fields of type array.*

## Structure

`FirmwareUpgradeChangeRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `type` | [`string(FirmwareTypeList)`](../../doc/models/firmware-type-list.md) | Required | Possible values are `append` or `remove` | getType(): string | setType(string type): void |
| `deviceList` | `string[]` | Required | The IMEIs of the devices. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "type": "append",
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

