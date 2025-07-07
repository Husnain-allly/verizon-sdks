
# Device Connection List Request

Request to list of network connection events for a device during a specified time period.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceConnectionListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`models.DeviceId`](../../doc/models/device-id.md) | Required | An identifier for a single device. |
| `Earliest` | `string` | Required | The earliest date and time for which you want connection events. |
| `Latest` | `string` | Required | The last date and time for which you want connection events. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

