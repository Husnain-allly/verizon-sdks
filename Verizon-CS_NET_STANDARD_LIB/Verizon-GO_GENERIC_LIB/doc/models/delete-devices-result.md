
# Delete Devices Result

Response for a request made to delete a device.

*This model accepts additional fields of type interface{}.*

## Structure

`DeleteDevicesResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceIds` | [`*models.DeleteDevicesResultDeviceIds`](../../doc/models/containers/delete-devices-result-device-ids.md) | Optional | This is a container for one-of cases. |
| `Status` | `*string` | Optional | “Success” if the device was deleted, or “Failed” if there was a problem. |
| `Message` | `*string` | Optional | Not present if status=Success. One of these messages if status=Failed:The device is not in deactivate state.The user does not have access to delete the device. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

