
# V1 List of Licenses to Remove Result

List of licenses assigned.

*This model accepts additional fields of type Object.*

## Structure

`V1ListOfLicensesToRemoveResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Count` | `Integer` | Optional | The total number of devices on the cancellation candidate list. | Integer getCount() | setCount(Integer count) |
| `DeviceList` | `List<String>` | Optional | The IMEIs of the devices. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "count": 2,
  "deviceList": [
    "900000000000001",
    "900000000000999"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

