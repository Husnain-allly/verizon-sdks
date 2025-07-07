
# V2 Campaign Device

List of devices in a campaign.

*This model accepts additional fields of type Object.*

## Structure

`V2CampaignDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TotalDevice` | `Integer` | Optional | Total device count. | Integer getTotalDevice() | setTotalDevice(Integer totalDevice) |
| `HasMoreData` | `boolean` | Required | Has more report flag. | boolean getHasMoreData() | setHasMoreData(boolean hasMoreData) |
| `LastSeenDeviceId` | `String` | Optional | Device identifier. | String getLastSeenDeviceId() | setLastSeenDeviceId(String lastSeenDeviceId) |
| `MaxPageSize` | `int` | Required | Maximum page size. | int getMaxPageSize() | setMaxPageSize(int maxPageSize) |
| `DeviceList` | [`List<V2DeviceStatus>`](../../doc/models/v2-device-status.md) | Required | List of devices with id in IMEI. | List<V2DeviceStatus> getDeviceList() | setDeviceList(List<V2DeviceStatus> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "totalDevice": 1148,
  "hasMoreData": true,
  "lastSeenDeviceId": "15-digit IMEI",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded",
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

