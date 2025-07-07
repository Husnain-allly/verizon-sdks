
# Delete Devices Result

Response for a request made to delete a device.

*This model accepts additional fields of type array.*

## Structure

`DeleteDevicesResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceIds` | [DeviceId](../../doc/models/device-id.md)[]\|[DeviceId](../../doc/models/device-id.md)\|null | Optional | This is a container for one-of cases. | getDeviceIds(): | setDeviceIds( deviceIds): void |
| `status` | `?string` | Optional | “Success” if the device was deleted, or “Failed” if there was a problem. | getStatus(): ?string | setStatus(?string status): void |
| `message` | `?string` | Optional | Not present if status=Success. One of these messages if status=Failed:The device is not in deactivate state.The user does not have access to delete the device. | getMessage(): ?string | setMessage(?string message): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

