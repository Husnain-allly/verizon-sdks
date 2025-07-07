
# Location Request

The body contains the the account name and list of devices that you want to locate, plus other options.

*This model accepts additional fields of type Object.*

## Structure

`LocationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account identifier in "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `DeviceList` | [`List<DeviceInfo>`](../../doc/models/device-info.md) | Required | Device list. | List<DeviceInfo> getDeviceList() | setDeviceList(List<DeviceInfo> deviceList) |
| `AccuracyMode` | [`AccuracyMode`](../../doc/models/accuracy-mode.md) | Optional | Accurary, currently only 0-coarse supported. | AccuracyMode getAccuracyMode() | setAccuracyMode(AccuracyMode accuracyMode) |
| `CacheMode` | [`CacheMode`](../../doc/models/cache-mode.md) | Optional | Location cache mode. | CacheMode getCacheMode() | setCacheMode(CacheMode cacheMode) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "1234567890-00001",
  "accuracyMode": "0",
  "cacheMode": "1",
  "deviceList": [
    {
      "id": "980003420535573",
      "kind": "imei",
      "mdn": "7892345678",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "375535024300089",
      "kind": "imei",
      "mdn": "7897654321",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "A100003861E585",
      "kind": "meid",
      "mdn": "7897650914",
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

