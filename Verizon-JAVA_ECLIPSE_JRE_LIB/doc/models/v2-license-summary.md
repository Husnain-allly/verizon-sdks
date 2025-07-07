
# V2 License Summary

Summary of license assignment.

*This model accepts additional fields of type Object.*

## Structure

`V2LicenseSummary`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `TotalLicense` | `Integer` | Optional | Total FOTA license count. | Integer getTotalLicense() | setTotalLicense(Integer totalLicense) |
| `AssignedLicenses` | `int` | Required | Assigned FOTA license count. | int getAssignedLicenses() | setAssignedLicenses(int assignedLicenses) |
| `HasMoreData` | `boolean` | Required | True if there are more devices to retrieve. | boolean getHasMoreData() | setHasMoreData(boolean hasMoreData) |
| `LastSeenDeviceId` | `String` | Optional | Last seen device identifier. | String getLastSeenDeviceId() | setLastSeenDeviceId(String lastSeenDeviceId) |
| `MaxPageSize` | `int` | Required | Maximum page size. | int getMaxPageSize() | setMaxPageSize(int maxPageSize) |
| `DeviceList` | [`List<V2LicenseDevice>`](../../doc/models/v2-license-device.md) | Optional | Device IMEI list. | List<V2LicenseDevice> getDeviceList() | setDeviceList(List<V2LicenseDevice> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0402196254-00001",
  "totalLicense": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": "1000",
  "maxPageSize": 10,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "assignmentTime": "2017-11-29T16:03:42.000Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "990000473475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "990000347475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "990007303425535",
      "assignmentTime": "2017-11-29T16:03:42.000Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

