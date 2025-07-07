
# Firmware Upgrade Change Request

List of devices to add or remove.

*This model accepts additional fields of type object.*

## Structure

`FirmwareUpgradeChangeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`FirmwareTypeList`](../../doc/models/firmware-type-list.md) | Required | Possible values are `append` or `remove` |
| `DeviceList` | `List<string>` | Required | The IMEIs of the devices. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

