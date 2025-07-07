
# V3 Campaign Device

Campaign history.

*This model accepts additional fields of type Object.*

## Structure

`V3CampaignDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `total_device` | `Integer` | Optional | Total device count. |
| `has_more_data` | `TrueClass \| FalseClass` | Required | Has more report flag. |
| `last_seen_device_id` | `String` | Optional | Device identifier. |
| `max_page_size` | `Integer` | Required | Maximum page size. |
| `device_list` | [`Array<V3DeviceStatus>`](../../doc/models/v3-device-status.md) | Required | List of devices with id in IMEI. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

