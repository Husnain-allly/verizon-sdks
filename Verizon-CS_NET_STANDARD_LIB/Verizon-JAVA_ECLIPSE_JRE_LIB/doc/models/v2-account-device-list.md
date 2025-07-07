
# V2 Account Device List

List of device information for an account.

*This model accepts additional fields of type Object.*

## Structure

`V2AccountDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account name. | String getAccountName() | setAccountName(String accountName) |
| `HasMoreData` | `boolean` | Required | Has more device flag? | boolean getHasMoreData() | setHasMoreData(boolean hasMoreData) |
| `LastSeenDeviceId` | `String` | Optional | Last seen device identifier. | String getLastSeenDeviceId() | setLastSeenDeviceId(String lastSeenDeviceId) |
| `MaxPageSize` | `int` | Required | Maximum page size. | int getMaxPageSize() | setMaxPageSize(int maxPageSize) |
| `DeviceList` | [`List<V2AccountDevice>`](../../doc/models/v2-account-device.md) | Required | Account device list. | List<V2AccountDevice> getDeviceList() | setDeviceList(List<V2AccountDevice> deviceList) |
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
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z",
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
    },
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z",
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
    },
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z",
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

