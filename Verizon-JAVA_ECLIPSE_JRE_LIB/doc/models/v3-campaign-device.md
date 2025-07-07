
# V3 Campaign Device

Campaign history.

*This model accepts additional fields of type Object.*

## Structure

`V3CampaignDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TotalDevice` | `Integer` | Optional | Total device count. | Integer getTotalDevice() | setTotalDevice(Integer totalDevice) |
| `HasMoreData` | `boolean` | Required | Has more report flag. | boolean getHasMoreData() | setHasMoreData(boolean hasMoreData) |
| `LastSeenDeviceId` | `String` | Optional | Device identifier. | String getLastSeenDeviceId() | setLastSeenDeviceId(String lastSeenDeviceId) |
| `MaxPageSize` | `int` | Required | Maximum page size. | int getMaxPageSize() | setMaxPageSize(int maxPageSize) |
| `DeviceList` | [`List<V3DeviceStatus>`](../../doc/models/v3-device-status.md) | Required | List of devices with id in IMEI. | List<V3DeviceStatus> getDeviceList() | setDeviceList(List<V3DeviceStatus> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "totalDevice": 2689,
  "hasMoreData": true,
  "lastSeenDeviceId": "15-digit IMEI",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradePending",
      "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
      "updatedTime": "2022-08-05T21:05:27.129Z",
      "recentAttemptTime": "2022-10-05T21:05:01.19Z",
      "nextAttemptTime": "2022-10-06T18:35:00Z",
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

