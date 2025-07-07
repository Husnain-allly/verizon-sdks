
# V2 Licenses Assigned Removed Result

License assignment or removal confirmation.

*This model accepts additional fields of type Object.*

## Structure

`V2LicensesAssignedRemovedResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account name. | String getAccountName() | setAccountName(String accountName) |
| `LicTotalCount` | `int` | Required | Total license count. | int getLicTotalCount() | setLicTotalCount(int licTotalCount) |
| `LicUsedCount` | `int` | Required | Assigned license count. | int getLicUsedCount() | setLicUsedCount(int licUsedCount) |
| `DeviceList` | [`List<V2DeviceStatus>`](../../doc/models/v2-device-status.md) | Required | List of devices with id in IMEI. | List<V2DeviceStatus> getDeviceList() | setDeviceList(List<V2DeviceStatus> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0242078689-00001",
  "licTotalCount": 1000,
  "licUsedCount": 502,
  "deviceList": [
    {
      "deviceId": "990003425730524",
      "status": "Success",
      "resultReason": "Success",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "990000473475967",
      "status": "Failure",
      "resultReason": "Device does not exist.",
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

