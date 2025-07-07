
# V2 Campaign Device

List of devices in a campaign.

*This model accepts additional fields of type object.*

## Structure

`V2CampaignDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalDevice` | `int?` | Optional | Total device count. |
| `HasMoreData` | `bool` | Required | Has more report flag. |
| `LastSeenDeviceId` | `string` | Optional | Device identifier. |
| `MaxPageSize` | `int` | Required | Maximum page size. |
| `DeviceList` | [`List<V2DeviceStatus>`](../../doc/models/v2-device-status.md) | Required | List of devices with id in IMEI. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

