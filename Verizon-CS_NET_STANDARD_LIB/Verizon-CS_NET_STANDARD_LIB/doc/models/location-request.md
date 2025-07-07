
# Location Request

The body contains the the account name and list of devices that you want to locate, plus other options.

*This model accepts additional fields of type object.*

## Structure

`LocationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier in "##########-#####". |
| `DeviceList` | [`List<DeviceInfo>`](../../doc/models/device-info.md) | Required | Device list. |
| `AccuracyMode` | [`AccuracyMode?`](../../doc/models/accuracy-mode.md) | Optional | Accurary, currently only 0-coarse supported. |
| `CacheMode` | [`CacheMode?`](../../doc/models/cache-mode.md) | Optional | Location cache mode. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

