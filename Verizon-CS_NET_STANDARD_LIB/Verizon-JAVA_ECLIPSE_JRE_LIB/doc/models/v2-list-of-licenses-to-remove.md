
# V2 List of Licenses to Remove

A list of license cancellation candidate devices.

*This model accepts additional fields of type Object.*

## Structure

`V2ListOfLicensesToRemove`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Count` | `int` | Required | Cancellation candidate devices count. | int getCount() | setCount(int count) |
| `HasMoreData` | `boolean` | Required | Flag to indicat more devices. | boolean getHasMoreData() | setHasMoreData(boolean hasMoreData) |
| `UpdateTime` | `String` | Required | Last update time. | String getUpdateTime() | setUpdateTime(String updateTime) |
| `DeviceList` | `List<String>` | Required | Device IMEI list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "count": 6,
  "hasMoreData": false,
  "updateTime": "2018-03-22 00:06:00.069 +0000 UTC",
  "deviceList": [
    "990003425730535",
    "990000473475989",
    "990005733420535",
    "990000347475989",
    "990007303425535",
    "990007590473489"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

