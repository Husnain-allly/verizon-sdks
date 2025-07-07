
# V2 Add or Remove Device Request

Add or remove device to existing software upgrade information.

*This model accepts additional fields of type Object.*

## Structure

`V2AddOrRemoveDeviceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | `String` | Required | Operation either 'append' or 'remove'. | String getType() | setType(String type) |
| `DeviceList` | `List<String>` | Required | Device IMEI list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "Type": "remove",
  "deviceList": [
    "990013907884259",
    "990013907835573",
    "990013907833575"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

