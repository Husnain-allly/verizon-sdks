
# Delete Devices Result

Response for a request made to delete a device.

*This model accepts additional fields of type unknown.*

## Structure

`DeleteDevicesResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceIds` | [`DeleteDevicesResultDeviceIds \| undefined`](../../doc/models/containers/delete-devices-result-device-ids.md) | Optional | This is a container for one-of cases. |
| `status` | `string \| undefined` | Optional | “Success” if the device was deleted, or “Failed” if there was a problem. |
| `message` | `string \| undefined` | Optional | Not present if status=Success. One of these messages if status=Failed:The device is not in deactivate state.The user does not have access to delete the device. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

