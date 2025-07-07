
# Firmware Upgrade Change Request

List of devices to add or remove.

*This model accepts additional fields of type Any.*

## Structure

`FirmwareUpgradeChangeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mtype` | [`FirmwareTypeList`](../../doc/models/firmware-type-list.md) | Required | Possible values are `append` or `remove` |
| `device_list` | `List[str]` | Required | The IMEIs of the devices. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

