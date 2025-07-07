
# Account Device List

A list of deviceId objects to use when requesting information from multiple devices.

*This model accepts additional fields of type Object.*

## Structure

`AccountDeviceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | [`Array<DeviceId>`](../../doc/models/device-id.md) | Required | All identifiers for the device. |
| `ipaddress` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9].[0-9].[0-9].[0-9]{3,32}$` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "kind": "imei",
      "id": "990013907835573",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "kind": "iccid",
      "id": "89141390780800784259",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "ipAddress": "ipAddress2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

