
# Firmware Upgrade Change Request

List of devices to add or remove.

*This model accepts additional fields of type Object.*

## Structure

`FirmwareUpgradeChangeRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | [`FirmwareTypeList`](../../doc/models/firmware-type-list.md) | Required | Possible values are `append` or `remove` | FirmwareTypeList getType() | setType(FirmwareTypeList type) |
| `DeviceList` | `List<String>` | Required | The IMEIs of the devices. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

