
# V3 Add or Remove Device Request

Devices to add or remove from existing software upgrade information.

*This model accepts additional fields of type Object.*

## Structure

`V3AddOrRemoveDeviceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | `String` | Required | Operation either 'append' or 'remove' | String getType() | setType(String type) |
| `DeviceList` | `List<String>` | Required | Device IMEI list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

