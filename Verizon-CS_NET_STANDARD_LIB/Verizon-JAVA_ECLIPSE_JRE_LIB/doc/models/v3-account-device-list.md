
# V3 Account Device List

Array of devices.

*This model accepts additional fields of type Object.*

## Structure

`V3AccountDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account name. | String getAccountName() | setAccountName(String accountName) |
| `HasMoreData` | `boolean` | Required | Has more device flag? | boolean getHasMoreData() | setHasMoreData(boolean hasMoreData) |
| `LastSeenDeviceId` | `String` | Optional | Last seen device identifier. | String getLastSeenDeviceId() | setLastSeenDeviceId(String lastSeenDeviceId) |
| `MaxPageSize` | `int` | Required | Maximum page size. | int getMaxPageSize() | setMaxPageSize(int maxPageSize) |
| `DeviceList` | [`List<V3AccountDevice>`](../../doc/models/v3-account-device.md) | Required | Account device list. | List<V3AccountDevice> getDeviceList() | setDeviceList(List<V3AccountDevice> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "hasMoreData": true,
  "lastSeenDeviceId": "15-digit IMEI",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit device ID",
      "mdn": "10-digit MDN",
      "model": "BG96",
      "make": "QUECTEL",
      "firmware": "BG96MAR04A04M1G",
      "fotaEligible": false,
      "status": "Active",
      "licenseAssigned": true,
      "protocol": "LWM2M",
      "softwareList": [
        {
          "name": "VZ_MDM_IOT",
          "version": "0.14",
          "upgradeTime": "2012-04-23T18:25:43.511Z",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "fileList": [
        {
          "name": "VZ_MDM_IOT",
          "version": "0.14",
          "upgradeTime": "2012-04-23T18:25:43.511Z",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
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

