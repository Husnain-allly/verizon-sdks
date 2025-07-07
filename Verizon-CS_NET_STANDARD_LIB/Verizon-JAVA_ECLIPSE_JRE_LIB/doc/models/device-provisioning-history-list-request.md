
# Device Provisioning History List Request

Request to return the provisioning history of a specified device during a specified time period.

*This model accepts additional fields of type Object.*

## Structure

`DeviceProvisioningHistoryListRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`DeviceId`](../../doc/models/device-id.md) | Required | An identifier for a single device. | DeviceId getDeviceId() | setDeviceId(DeviceId deviceId) |
| `Earliest` | `String` | Required | The earliest date and time for which you want provisioning data. | String getEarliest() | setEarliest(String earliest) |
| `Latest` | `String` | Required | The last date and time for which you want provisioning data. | String getLatest() | setLatest(String latest) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

