
# Add Devices Result

Contains the device identifiers and a success or failure response for each device in the request.

*This model accepts additional fields of type Any.*

## Structure

`AddDevicesResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | [`List[DeviceId]`](../../doc/models/device-id.md) | Optional | Identifiers for the device. |
| `response` | `str` | Optional | The success message or error message for the current device. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

