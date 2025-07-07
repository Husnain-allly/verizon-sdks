
# M 5G Bidevice Idarray

*This model accepts additional fields of type Object.*

## Structure

`M5GBideviceIdarray`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`List<M5GBideviceIdarrayDeviceId>`](../../doc/models/containers/m-5g-bidevice-idarray-device-id.md) | Optional | This is List of a container for any-of cases. | List<M5GBideviceIdarrayDeviceId> getDeviceId() | setDeviceId(List<M5GBideviceIdarrayDeviceId> deviceId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": [
    {
      "id": "id0",
      "kind": "kind8",
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

