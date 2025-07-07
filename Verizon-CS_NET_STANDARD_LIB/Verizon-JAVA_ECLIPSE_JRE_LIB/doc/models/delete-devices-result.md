
# Delete Devices Result

Response for a request made to delete a device.

*This model accepts additional fields of type Object.*

## Structure

`DeleteDevicesResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceIds` | [`DeleteDevicesResultDeviceIds`](../../doc/models/containers/delete-devices-result-device-ids.md) | Optional | This is a container for one-of cases. | DeleteDevicesResultDeviceIds getDeviceIds() | setDeviceIds(DeleteDevicesResultDeviceIds deviceIds) |
| `Status` | `String` | Optional | “Success” if the device was deleted, or “Failed” if there was a problem. | String getStatus() | setStatus(String status) |
| `Message` | `String` | Optional | Not present if status=Success. One of these messages if status=Failed:The device is not in deactivate state.The user does not have access to delete the device. | String getMessage() | setMessage(String message) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "09005470263",
      "kind": "esn",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "status": "Success",
  "message": "message6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

