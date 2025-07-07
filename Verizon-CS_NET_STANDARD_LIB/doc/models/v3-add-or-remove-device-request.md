
# V3 Add or Remove Device Request

Devices to add or remove from existing software upgrade information.

*This model accepts additional fields of type object.*

## Structure

`V3AddOrRemoveDeviceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | Operation either 'append' or 'remove' |
| `DeviceList` | `List<string>` | Required | Device IMEI list. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "Type": "remove",
  "deviceList": [
    "15-digit IMEI"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

