
# M 5G Bidevice Id

*This model accepts additional fields of type Object.*

## Structure

`M5GBideviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`M5GBideviceId1`](../../doc/models/m-5g-bidevice-id-1.md) | Optional | - | M5GBideviceId1 getDeviceId() | setDeviceId(M5GBideviceId1 deviceId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": {
    "id": "id0",
    "kind": "kind8",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

