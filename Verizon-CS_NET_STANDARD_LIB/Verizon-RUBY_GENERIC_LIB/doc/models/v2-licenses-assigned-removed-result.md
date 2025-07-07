
# V2 Licenses Assigned Removed Result

License assignment or removal confirmation.

*This model accepts additional fields of type Object.*

## Structure

`V2LicensesAssignedRemovedResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | Account name. |
| `lic_total_count` | `Integer` | Required | Total license count. |
| `lic_used_count` | `Integer` | Required | Assigned license count. |
| `device_list` | [`Array<V2DeviceStatus>`](../../doc/models/v2-device-status.md) | Required | List of devices with id in IMEI. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

