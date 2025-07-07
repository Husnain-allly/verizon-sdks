
# Device List Query Result

List of devices.

*This model accepts additional fields of type Object.*

## Structure

`DeviceListQueryResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | Account identifier in "##########-#####". |
| `has_more_data` | `TrueClass \| FalseClass` | Optional | True if there are more devices to retrieve. |
| `last_seen_device_id` | `Integer` | Optional | If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false. |
| `device_list` | [`Array<DeviceListQueryItem>`](../../doc/models/device-list-query-item.md) | Optional | The list of devices in the account. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0242078698-00001",
  "hasMoreData": true,
  "lastSeenDeviceId": 900000000001000,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "mdn": "0000040881",
      "model": "Model-A",
      "make": "Verizon",
      "firmware": "VerizonFirmwareVersion-01",
      "fotaEligible": true,
      "licenseAssigned": true,
      "upgradeTime": "2018-03-03T16:03:33.000Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "900000000000999",
      "mdn": "0000041879",
      "model": "Model-A",
      "make": "Verizon",
      "firmware": "VerizonFirmwareVersion-01",
      "fotaEligible": true,
      "licenseAssigned": true,
      "upgradeTime": "2018-03-03T16:03:33.000Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "900000000001000",
      "mdn": "0000041880",
      "model": "Model-A",
      "make": "Verizon",
      "firmware": "VerizonFirmwareVersion-01",
      "fotaEligible": true,
      "licenseAssigned": true,
      "upgradeTime": "2018-03-03T16:03:33.000Z",
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

