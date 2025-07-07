
# Delete Devices Result

Response for a request made to delete a device.

*This model accepts additional fields of type Any.*

## Structure

`DeleteDevicesResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | `Any` | Optional | One object per device to be deleted. Each object must contain a kind and id element identifying the device. |
| `status` | `str` | Optional | “Success” if the device was deleted, or “Failed” if there was a problem. |
| `message` | `str` | Optional | Not present if status=Success. One of these messages if status=Failed:The device is not in deactivate state.The user does not have access to delete the device. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "09005470263",
      "kind": "esn"
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

