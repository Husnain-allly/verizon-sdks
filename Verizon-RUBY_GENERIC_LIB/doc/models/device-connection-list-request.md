
# Device Connection List Request

Request to list of network connection events for a device during a specified time period.

*This model accepts additional fields of type Object.*

## Structure

`DeviceConnectionListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | [`DeviceId`](../../doc/models/device-id.md) | Required | An identifier for a single device. |
| `earliest` | `String` | Required | The earliest date and time for which you want connection events. |
| `latest` | `String` | Required | The last date and time for which you want connection events. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": {
    "id": "89141390780800784259",
    "kind": "iccid",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "earliest": "2015-09-16T00:00:01Z",
  "latest": "2010-09-18T00:00:01Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

