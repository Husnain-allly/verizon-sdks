
# Device Provisioning History List Request

Request to return the provisioning history of a specified device during a specified time period.

*This model accepts additional fields of type object.*

## Structure

`DeviceProvisioningHistoryListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`DeviceId`](../../doc/models/device-id.md) | Required | An identifier for a single device. |
| `Earliest` | `string` | Required | The earliest date and time for which you want provisioning data. |
| `Latest` | `string` | Required | The last date and time for which you want provisioning data. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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
  "latest": "2015-09-18T00:00:01Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

