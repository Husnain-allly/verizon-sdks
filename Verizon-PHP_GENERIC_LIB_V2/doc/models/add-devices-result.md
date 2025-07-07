
# Add Devices Result

Contains the device identifiers and a success or failure response for each device in the request.

*This model accepts additional fields of type array.*

## Structure

`AddDevicesResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceIds` | [`?(DeviceId[])`](../../doc/models/device-id.md) | Optional | Identifiers for the device. | getDeviceIds(): ?array | setDeviceIds(?array deviceIds): void |
| `response` | `?string` | Optional | The success message or error message for the current device. | getResponse(): ?string | setResponse(?string response): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "89148000000800784259",
      "kind": "iccid",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "response": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

